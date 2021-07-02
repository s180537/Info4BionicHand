﻿
namespace BionicHand_BETA_2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.comboBox_BAUDRATE = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_COMPORT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_sensor5 = new System.Windows.Forms.TextBox();
            this.textBox_sensor4 = new System.Windows.Forms.TextBox();
            this.textBox_sensor3 = new System.Windows.Forms.TextBox();
            this.textBox_sensor2 = new System.Windows.Forms.TextBox();
            this.textBox_sensor1 = new System.Windows.Forms.TextBox();
            this.verticalProgressBar5_sensor5 = new BionicHand_BETA_2.VerticalProgressBar();
            this.verticalProgressBar4_sensor4 = new BionicHand_BETA_2.VerticalProgressBar();
            this.verticalProgressBar3_sensor3 = new BionicHand_BETA_2.VerticalProgressBar();
            this.verticalProgressBar2_sensor2 = new BionicHand_BETA_2.VerticalProgressBar();
            this.verticalProgressBar1_sensor1 = new BionicHand_BETA_2.VerticalProgressBar();
            this.StatusCOM = new BionicHand_BETA_2.VerticalProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StatusCOM);
            this.groupBox1.Controls.Add(this.button_close);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.comboBox_BAUDRATE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_COMPORT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT SETTINGS";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(628, 44);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "CLOSE";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(547, 44);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 4;
            this.button_open.Text = "OPEN";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // comboBox_BAUDRATE
            // 
            this.comboBox_BAUDRATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BAUDRATE.FormattingEnabled = true;
            this.comboBox_BAUDRATE.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox_BAUDRATE.Location = new System.Drawing.Point(379, 56);
            this.comboBox_BAUDRATE.Name = "comboBox_BAUDRATE";
            this.comboBox_BAUDRATE.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BAUDRATE.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "BAUD RATE : ";
            // 
            // comboBox_COMPORT
            // 
            this.comboBox_COMPORT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_COMPORT.FormattingEnabled = true;
            this.comboBox_COMPORT.Location = new System.Drawing.Point(379, 29);
            this.comboBox_COMPORT.Name = "comboBox_COMPORT";
            this.comboBox_COMPORT.Size = new System.Drawing.Size(121, 21);
            this.comboBox_COMPORT.TabIndex = 1;
            this.comboBox_COMPORT.DropDown += new System.EventHandler(this.comboBox_COMPORT_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "COM PORT : ";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(705, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Sensor5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Sensor4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sensor3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Sensor2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Sensor1";
            // 
            // textBox_sensor5
            // 
            this.textBox_sensor5.Location = new System.Drawing.Point(757, 268);
            this.textBox_sensor5.Name = "textBox_sensor5";
            this.textBox_sensor5.Size = new System.Drawing.Size(36, 20);
            this.textBox_sensor5.TabIndex = 24;
            // 
            // textBox_sensor4
            // 
            this.textBox_sensor4.Location = new System.Drawing.Point(620, 268);
            this.textBox_sensor4.Name = "textBox_sensor4";
            this.textBox_sensor4.Size = new System.Drawing.Size(36, 20);
            this.textBox_sensor4.TabIndex = 23;
            // 
            // textBox_sensor3
            // 
            this.textBox_sensor3.Location = new System.Drawing.Point(475, 268);
            this.textBox_sensor3.Name = "textBox_sensor3";
            this.textBox_sensor3.Size = new System.Drawing.Size(36, 20);
            this.textBox_sensor3.TabIndex = 22;
            // 
            // textBox_sensor2
            // 
            this.textBox_sensor2.Location = new System.Drawing.Point(324, 268);
            this.textBox_sensor2.Name = "textBox_sensor2";
            this.textBox_sensor2.Size = new System.Drawing.Size(36, 20);
            this.textBox_sensor2.TabIndex = 21;
            // 
            // textBox_sensor1
            // 
            this.textBox_sensor1.Location = new System.Drawing.Point(183, 268);
            this.textBox_sensor1.Name = "textBox_sensor1";
            this.textBox_sensor1.Size = new System.Drawing.Size(36, 20);
            this.textBox_sensor1.TabIndex = 20;
            // 
            // verticalProgressBar5_sensor5
            // 
            this.verticalProgressBar5_sensor5.Location = new System.Drawing.Point(757, 65);
            this.verticalProgressBar5_sensor5.Maximum = 1023;
            this.verticalProgressBar5_sensor5.Name = "verticalProgressBar5_sensor5";
            this.verticalProgressBar5_sensor5.Size = new System.Drawing.Size(36, 197);
            this.verticalProgressBar5_sensor5.TabIndex = 19;
            // 
            // verticalProgressBar4_sensor4
            // 
            this.verticalProgressBar4_sensor4.Location = new System.Drawing.Point(620, 65);
            this.verticalProgressBar4_sensor4.Maximum = 1023;
            this.verticalProgressBar4_sensor4.Name = "verticalProgressBar4_sensor4";
            this.verticalProgressBar4_sensor4.Size = new System.Drawing.Size(36, 197);
            this.verticalProgressBar4_sensor4.TabIndex = 18;
            // 
            // verticalProgressBar3_sensor3
            // 
            this.verticalProgressBar3_sensor3.Location = new System.Drawing.Point(475, 65);
            this.verticalProgressBar3_sensor3.Maximum = 1023;
            this.verticalProgressBar3_sensor3.Name = "verticalProgressBar3_sensor3";
            this.verticalProgressBar3_sensor3.Size = new System.Drawing.Size(36, 197);
            this.verticalProgressBar3_sensor3.TabIndex = 17;
            // 
            // verticalProgressBar2_sensor2
            // 
            this.verticalProgressBar2_sensor2.Location = new System.Drawing.Point(324, 65);
            this.verticalProgressBar2_sensor2.Maximum = 1023;
            this.verticalProgressBar2_sensor2.Name = "verticalProgressBar2_sensor2";
            this.verticalProgressBar2_sensor2.Size = new System.Drawing.Size(36, 197);
            this.verticalProgressBar2_sensor2.TabIndex = 16;
            // 
            // verticalProgressBar1_sensor1
            // 
            this.verticalProgressBar1_sensor1.Location = new System.Drawing.Point(183, 65);
            this.verticalProgressBar1_sensor1.Maximum = 1023;
            this.verticalProgressBar1_sensor1.Name = "verticalProgressBar1_sensor1";
            this.verticalProgressBar1_sensor1.Size = new System.Drawing.Size(36, 197);
            this.verticalProgressBar1_sensor1.TabIndex = 15;
            // 
            // StatusCOM
            // 
            this.StatusCOM.Location = new System.Drawing.Point(239, 24);
            this.StatusCOM.Name = "StatusCOM";
            this.StatusCOM.Size = new System.Drawing.Size(26, 54);
            this.StatusCOM.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1004, 481);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_sensor5);
            this.Controls.Add(this.textBox_sensor4);
            this.Controls.Add(this.textBox_sensor3);
            this.Controls.Add(this.textBox_sensor2);
            this.Controls.Add(this.textBox_sensor1);
            this.Controls.Add(this.verticalProgressBar5_sensor5);
            this.Controls.Add(this.verticalProgressBar4_sensor4);
            this.Controls.Add(this.verticalProgressBar3_sensor3);
            this.Controls.Add(this.verticalProgressBar2_sensor2);
            this.Controls.Add(this.verticalProgressBar1_sensor1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Bionic Hand (beta)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.ComboBox comboBox_BAUDRATE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_COMPORT;
        private System.Windows.Forms.Label label3;
        private VerticalProgressBar StatusCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_sensor5;
        private System.Windows.Forms.TextBox textBox_sensor4;
        private System.Windows.Forms.TextBox textBox_sensor3;
        private System.Windows.Forms.TextBox textBox_sensor2;
        private System.Windows.Forms.TextBox textBox_sensor1;
        private VerticalProgressBar verticalProgressBar5_sensor5;
        private VerticalProgressBar verticalProgressBar4_sensor4;
        private VerticalProgressBar verticalProgressBar3_sensor3;
        private VerticalProgressBar verticalProgressBar2_sensor2;
        private VerticalProgressBar verticalProgressBar1_sensor1;
    }
}