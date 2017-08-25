namespace Cerberus
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.apellidosLabel = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.localidadLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.localidadTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.nacimientoDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rfidTextBox = new System.Windows.Forms.TextBox();
            this.registrarButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.nombreLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.apellidosLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dniLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fechaLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.localidadLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.direccionLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.nombreTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.apellidosTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dniTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.localidadTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.direccionTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.nacimientoDateTimePicker1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.rfidTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.registrarButton, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 215);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(3, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 0;
            this.nombreLabel.Text = "Nombre";
            // 
            // apellidosLabel
            // 
            this.apellidosLabel.AutoSize = true;
            this.apellidosLabel.Location = new System.Drawing.Point(3, 26);
            this.apellidosLabel.Name = "apellidosLabel";
            this.apellidosLabel.Size = new System.Drawing.Size(49, 13);
            this.apellidosLabel.TabIndex = 1;
            this.apellidosLabel.Text = "Apellidos";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(3, 52);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(26, 13);
            this.dniLabel.TabIndex = 2;
            this.dniLabel.Text = "DNI";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(3, 78);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(93, 13);
            this.fechaLabel.TabIndex = 3;
            this.fechaLabel.Text = "Fecha Nacimiento";
            // 
            // localidadLabel
            // 
            this.localidadLabel.AutoSize = true;
            this.localidadLabel.Location = new System.Drawing.Point(3, 104);
            this.localidadLabel.Name = "localidadLabel";
            this.localidadLabel.Size = new System.Drawing.Size(53, 13);
            this.localidadLabel.TabIndex = 4;
            this.localidadLabel.Text = "Localidad";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(3, 130);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(52, 13);
            this.direccionLabel.TabIndex = 5;
            this.direccionLabel.Text = "Dirección";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(144, 3);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.Location = new System.Drawing.Point(144, 29);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidosTextBox.TabIndex = 7;
            // 
            // dniTextBox
            // 
            this.dniTextBox.Location = new System.Drawing.Point(144, 55);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(100, 20);
            this.dniTextBox.TabIndex = 8;
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.Location = new System.Drawing.Point(144, 107);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.localidadTextBox.TabIndex = 10;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(144, 133);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 11;
            // 
            // nacimientoDateTimePicker1
            // 
            this.nacimientoDateTimePicker1.Location = new System.Drawing.Point(144, 81);
            this.nacimientoDateTimePicker1.Name = "nacimientoDateTimePicker1";
            this.nacimientoDateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.nacimientoDateTimePicker1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "RFID";
            // 
            // rfidTextBox
            // 
            this.rfidTextBox.Location = new System.Drawing.Point(144, 159);
            this.rfidTextBox.Name = "rfidTextBox";
            this.rfidTextBox.Size = new System.Drawing.Size(100, 20);
            this.rfidTextBox.TabIndex = 15;
            // 
            // registrarButton
            // 
            this.registrarButton.Location = new System.Drawing.Point(144, 185);
            this.registrarButton.Name = "registrarButton";
            this.registrarButton.Size = new System.Drawing.Size(75, 23);
            this.registrarButton.TabIndex = 12;
            this.registrarButton.Text = "Aceptar";
            this.registrarButton.UseVisualStyleBackColor = true;
            this.registrarButton.Click += new System.EventHandler(this.registrarButton_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(306, 235);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label apellidosLabel;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label localidadLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox localidadTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Button registrarButton;
        private System.Windows.Forms.DateTimePicker nacimientoDateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rfidTextBox;
    }
}