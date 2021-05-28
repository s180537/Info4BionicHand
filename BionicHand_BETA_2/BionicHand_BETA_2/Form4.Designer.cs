
namespace BionicHand_BETA_2
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.verticalProgressBar1_sensor1 = new BionicHand_BETA_2.VerticalProgressBar();
            this.verticalProgressBar2_sensor2 = new BionicHand_BETA_2.VerticalProgressBar();
            this.verticalProgressBar3_sensor3 = new BionicHand_BETA_2.VerticalProgressBar();
            this.verticalProgressBar4_sensor4 = new BionicHand_BETA_2.VerticalProgressBar();
            this.verticalProgressBar5_sensor5 = new BionicHand_BETA_2.VerticalProgressBar();
            this.textBox_sensor1 = new System.Windows.Forms.TextBox();
            this.textBox_sensor2 = new System.Windows.Forms.TextBox();
            this.textBox_sensor3 = new System.Windows.Forms.TextBox();
            this.textBox_sensor4 = new System.Windows.Forms.TextBox();
            this.textBox_sensor5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_sensor5);
            this.panel1.Controls.Add(this.textBox_sensor4);
            this.panel1.Controls.Add(this.textBox_sensor3);
            this.panel1.Controls.Add(this.textBox_sensor2);
            this.panel1.Controls.Add(this.textBox_sensor1);
            this.panel1.Controls.Add(this.verticalProgressBar5_sensor5);
            this.panel1.Controls.Add(this.verticalProgressBar4_sensor4);
            this.panel1.Controls.Add(this.verticalProgressBar3_sensor3);
            this.panel1.Controls.Add(this.verticalProgressBar2_sensor2);
            this.panel1.Controls.Add(this.verticalProgressBar1_sensor1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 387);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // verticalProgressBar1_sensor1
            // 
            this.verticalProgressBar1_sensor1.Location = new System.Drawing.Point(185, 98);
            this.verticalProgressBar1_sensor1.Maximum = 1023;
            this.verticalProgressBar1_sensor1.Name = "verticalProgressBar1_sensor1";
            this.verticalProgressBar1_sensor1.Size = new System.Drawing.Size(36, 197);
            this.verticalProgressBar1_sensor1.TabIndex = 0;
            this.verticalProgressBar1_sensor1.Value = 200;
            // 
            // verticalProgressBar2_sensor2
            // 
            this.verticalProgressBar2_sensor2.Location = new System.Drawing.Point(326, 98);
            this.verticalProgressBar2_sensor2.Maximum = 1023;
            this.verticalProgressBar2_sensor2.Name = "verticalProgressBar2_sensor2";
            this.verticalProgressBar2_sensor2.Size = new System.Drawing.Size(36, 197);
            this.verticalProgressBar2_sensor2.TabIndex = 1;
            this.verticalProgressBar2_sensor2.Value = 250;
            // 
            // verticalProgressBar3_sensor3
            // 
            this.verticalProgressBar3_sensor3.Location = new System.Drawing.Point(477, 98);
            this.verticalProgressBar3_sensor3.Maximum = 1023;
            this.verticalProgressBar3_sensor3.Name = "verticalProgressBar3_sensor3";
            this.verticalProgressBar3_sensor3.Size = new System.Drawing.Size(36, 197);
            this.verticalProgressBar3_sensor3.TabIndex = 2;
            this.verticalProgressBar3_sensor3.Value = 900;
            // 
            // verticalProgressBar4_sensor4
            // 
            this.verticalProgressBar4_sensor4.Location = new System.Drawing.Point(622, 98);
            this.verticalProgressBar4_sensor4.Maximum = 1023;
            this.verticalProgressBar4_sensor4.Name = "verticalProgressBar4_sensor4";
            this.verticalProgressBar4_sensor4.Size = new System.Drawing.Size(36, 197);
            this.verticalProgressBar4_sensor4.TabIndex = 3;
            this.verticalProgressBar4_sensor4.Value = 300;
            // 
            // verticalProgressBar5_sensor5
            // 
            this.verticalProgressBar5_sensor5.Location = new System.Drawing.Point(759, 98);
            this.verticalProgressBar5_sensor5.Maximum = 1023;
            this.verticalProgressBar5_sensor5.Name = "verticalProgressBar5_sensor5";
            this.verticalProgressBar5_sensor5.Size = new System.Drawing.Size(36, 197);
            this.verticalProgressBar5_sensor5.TabIndex = 4;
            this.verticalProgressBar5_sensor5.Value = 50;
            // 
            // textBox_sensor1
            // 
            this.textBox_sensor1.Location = new System.Drawing.Point(185, 301);
            this.textBox_sensor1.Name = "textBox_sensor1";
            this.textBox_sensor1.Size = new System.Drawing.Size(36, 20);
            this.textBox_sensor1.TabIndex = 5;
            // 
            // textBox_sensor2
            // 
            this.textBox_sensor2.Location = new System.Drawing.Point(326, 301);
            this.textBox_sensor2.Name = "textBox_sensor2";
            this.textBox_sensor2.Size = new System.Drawing.Size(36, 20);
            this.textBox_sensor2.TabIndex = 6;
            // 
            // textBox_sensor3
            // 
            this.textBox_sensor3.Location = new System.Drawing.Point(477, 301);
            this.textBox_sensor3.Name = "textBox_sensor3";
            this.textBox_sensor3.Size = new System.Drawing.Size(36, 20);
            this.textBox_sensor3.TabIndex = 7;
            // 
            // textBox_sensor4
            // 
            this.textBox_sensor4.Location = new System.Drawing.Point(622, 301);
            this.textBox_sensor4.Name = "textBox_sensor4";
            this.textBox_sensor4.Size = new System.Drawing.Size(36, 20);
            this.textBox_sensor4.TabIndex = 8;
            // 
            // textBox_sensor5
            // 
            this.textBox_sensor5.Location = new System.Drawing.Point(759, 301);
            this.textBox_sensor5.Name = "textBox_sensor5";
            this.textBox_sensor5.Size = new System.Drawing.Size(36, 20);
            this.textBox_sensor5.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(367, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visualisierung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sensor1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sensor2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sensor3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sensor4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(707, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sensor5";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1004, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Bionic Hand (beta)";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private VerticalProgressBar verticalProgressBar5_sensor5;
        private VerticalProgressBar verticalProgressBar4_sensor4;
        private VerticalProgressBar verticalProgressBar3_sensor3;
        private VerticalProgressBar verticalProgressBar2_sensor2;
        private VerticalProgressBar verticalProgressBar1_sensor1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_sensor5;
        private System.Windows.Forms.TextBox textBox_sensor4;
        private System.Windows.Forms.TextBox textBox_sensor3;
        private System.Windows.Forms.TextBox textBox_sensor2;
        private System.Windows.Forms.TextBox textBox_sensor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serialPort1;
    }
}