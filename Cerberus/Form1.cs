using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Cerberus
{
    public partial class Cerberus : Form
    {
        public string ultima_leida;
        Registro reg;
        public string _data;

        public delegate void RFID();
        public RFID myDelegate;

        public Cerberus()
        {
            InitializeComponent();
            SerialPort serialPort = new SerialPort();

            myDelegate = new RFID(registrar);

            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM3";

            serialPort.DataReceived += new SerialDataReceivedEventHandler(leerSerialArduino);
            serialPort.Open();

        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            reg = new Registro();
            reg.Show();     
        }

        public void registrar()
        {
            reg = new Registro(_data);
            this.reg.Show();
            Console.WriteLine(_data);
        }

        private void leerSerialArduino(object sender, EventArgs e)
        {

            SerialPort puertoActual = (SerialPort)sender;
            //int n_data = puertoActual.BytesToRead;
            string data = puertoActual.ReadExisting();
            ultima_leida = data;
            _data = data;

            this.Invoke(this.myDelegate);
        }
    }
}
