﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;



namespace Cerberus
{
    public partial class Registro : Form
    {

        public bool existe = false;
        public string _rfid;

        public Registro(string rfid="fffffffffff")
        {
            InitializeComponent();
            _rfid = rfid;

            if(rfid != "fffffffffff")
            {
                rfidTextBox.Text = _rfid;
                rfidTextBox.Enabled = false;

                MySqlConnection conn = conecta();
                conn.Open();

                string consulta = "SELECT Count(*) FROM control WHERE rfid = '" + _rfid + "';";
                MySqlCommand query = new MySqlCommand(consulta, conn);
                int d = Convert.ToInt32(query.ExecuteScalar());

                if(d == 1)
                {
                    consulta = "SELECT nombre, apellidos, dni, fecha, localidad, direccion, rfid FROM control WHERE rfid = '" + _rfid + "';";
                    query = new MySqlCommand(consulta, conn);
                    MySqlDataReader read = query.ExecuteReader();



                    while (read.Read())
                    {
                        nombreTextBox.Text = read.GetString(0);
                        apellidosTextBox.Text = read.GetString(1);
                        dniTextBox.Text = read.GetString(2);
                        nacimientoDateTimePicker1.Text = read.GetString(3);
                        localidadTextBox.Text = read.GetString(4);
                        direccionTextBox.Text = read.GetString(5);
                        rfidTextBox.Text = read.GetString(6);
                    }
                }

            }
        }

        private void registrarButton_Click(object sender, EventArgs e)
        {
            string nombre = nombreTextBox.Text;
            string apellidos = apellidosTextBox.Text;
            string dni = dniTextBox.Text;
            nacimientoDateTimePicker1.Format = DateTimePickerFormat.Custom;
            nacimientoDateTimePicker1.CustomFormat = "yyyy/MM/dd";
            string fecha = nacimientoDateTimePicker1.Text;
            nacimientoDateTimePicker1.Format = DateTimePickerFormat.Long;
            string localidad = localidadTextBox.Text;
            string direccion = direccionTextBox.Text;
            _rfid = rfidTextBox.Text;

            if(String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(_rfid) || String.IsNullOrEmpty(apellidos) || String.IsNullOrEmpty(dni) || String.IsNullOrEmpty(fecha))
            {
                MessageBox.Show("Debes introducir Nombre, Apellidos, DNI, Fecha y RFID");
                return;
            }



            MySqlConnection conn = conecta();
            conn.Open();

            string consulta = "SELECT Count(*) FROM control WHERE dni = '" + dni + "';";
            MySqlCommand query = new MySqlCommand(consulta, conn);
            int d = Convert.ToInt32(query.ExecuteScalar());

            Console.WriteLine(d);

            if(d == 0) //NO EXISTE EL MISMO DNI DENTRO DE LA BASE DE DATOS
            {
                consulta = "INSERT INTO control (nombre, apellidos, dni, fecha, localidad, direccion, rfid) VALUES ('" + nombre + "','" + apellidos + "','" + dni + "','" + fecha + "','" + localidad + "','" + direccion + "', '"+ _rfid +"');";
                query = new MySqlCommand(consulta, conn);
                if(query.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Usuario registrado!");
                }

                conn.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario con DNI: " + dni + " ya se encuentra registrado.");
                conn.Close();
                this.Close();
            }
            

            conn.Close();
            

            



        }

        public MySqlConnection conecta()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "30121994";
            builder.Database = "cerberus";
            builder.Port = 3306;

            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            return conn;

        }


        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
