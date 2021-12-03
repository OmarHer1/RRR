
namespace WindowsFormsAppCOMM_4B
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.port_select_label = new System.Windows.Forms.Label();
            this.comboBox_PORT_NAME = new System.Windows.Forms.ComboBox();
            this.button_OPEN_PORT = new System.Windows.Forms.Button();
            this.label_STATUS_PORT = new System.Windows.Forms.Label();
            this.label_VOLTAGE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // port_select_label
            // 
            this.port_select_label.AutoSize = true;
            this.port_select_label.Location = new System.Drawing.Point(68, 36);
            this.port_select_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.port_select_label.Name = "port_select_label";
            this.port_select_label.Size = new System.Drawing.Size(126, 17);
            this.port_select_label.TabIndex = 0;
            this.port_select_label.Text = "Selecciona puerto:";
            this.port_select_label.Click += new System.EventHandler(this.port_select_label_Click);
            // 
            // comboBox_PORT_NAME
            // 
            this.comboBox_PORT_NAME.FormattingEnabled = true;
            this.comboBox_PORT_NAME.Location = new System.Drawing.Point(16, 75);
            this.comboBox_PORT_NAME.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_PORT_NAME.Name = "comboBox_PORT_NAME";
            this.comboBox_PORT_NAME.Size = new System.Drawing.Size(223, 24);
            this.comboBox_PORT_NAME.TabIndex = 1;
            this.comboBox_PORT_NAME.SelectedIndexChanged += new System.EventHandler(this.comboBox_PORT_NAME_SelectedIndexChanged);
            // 
            // button_OPEN_PORT
            // 
            this.button_OPEN_PORT.Location = new System.Drawing.Point(272, 75);
            this.button_OPEN_PORT.Margin = new System.Windows.Forms.Padding(4);
            this.button_OPEN_PORT.Name = "button_OPEN_PORT";
            this.button_OPEN_PORT.Size = new System.Drawing.Size(193, 64);
            this.button_OPEN_PORT.TabIndex = 2;
            this.button_OPEN_PORT.Text = "Open PORT";
            this.button_OPEN_PORT.UseVisualStyleBackColor = true;
            this.button_OPEN_PORT.Click += new System.EventHandler(this.button_OPEN_PORT_Click);
            // 
            // label_STATUS_PORT
            // 
            this.label_STATUS_PORT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_STATUS_PORT.Location = new System.Drawing.Point(16, 129);
            this.label_STATUS_PORT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_STATUS_PORT.Name = "label_STATUS_PORT";
            this.label_STATUS_PORT.Size = new System.Drawing.Size(223, 38);
            this.label_STATUS_PORT.TabIndex = 3;
            this.label_STATUS_PORT.Text = "label1";
            this.label_STATUS_PORT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_VOLTAGE
            // 
            this.label_VOLTAGE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_VOLTAGE.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VOLTAGE.Location = new System.Drawing.Point(16, 191);
            this.label_VOLTAGE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_VOLTAGE.Name = "label_VOLTAGE";
            this.label_VOLTAGE.Size = new System.Drawing.Size(132, 49);
            this.label_VOLTAGE.TabIndex = 4;
            this.label_VOLTAGE.Click += new System.EventHandler(this.label_VOLTAGE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volts";
            // 
            // button_EXIT
            // 
            this.button_EXIT.Location = new System.Drawing.Point(272, 170);
            this.button_EXIT.Margin = new System.Windows.Forms.Padding(4);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(193, 70);
            this.button_EXIT.TabIndex = 6;
            this.button_EXIT.Text = "Salida";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(48, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 284);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 284);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 354);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_VOLTAGE);
            this.Controls.Add(this.label_STATUS_PORT);
            this.Controls.Add(this.button_OPEN_PORT);
            this.Controls.Add(this.comboBox_PORT_NAME);
            this.Controls.Add(this.port_select_label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label port_select_label;
        private System.Windows.Forms.ComboBox comboBox_PORT_NAME;
        private System.Windows.Forms.Button button_OPEN_PORT;
        private System.Windows.Forms.Label label_STATUS_PORT;
        private System.Windows.Forms.Label label_VOLTAGE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_EXIT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

