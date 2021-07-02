using System;
/*
 using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
*/
using System.IO.Ports;
/*
 using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
using System.Windows.Forms;

namespace BionicHand_BETA_2
{
    public partial class Form2 : Form
    {
        string serialDataIn = "0A0B0C0D";
        sbyte indexofA = 1, indexofB = 1, indexofC = 1, indexofD = 1;
        string dataSensor1 = "1", dataSensor2 = "1", dataSensor3 = "1", dataSensor4 = "1";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button_open.Enabled = true;
            button_close.Enabled = false;
            StatusCOM.Value = 0;
            comboBox_BAUDRATE.Text = "115200";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void comboBox_COMPORT_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            comboBox_COMPORT.Items.Clear();
            comboBox_COMPORT.Items.AddRange(portLists);
        }

        public void button_open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_COMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_BAUDRATE.Text);
                serialPort1.Open();

                button_open.Enabled = false;
                button_close.Enabled = true;
                StatusCOM.Value = 100;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void button_close_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();

                button_open.Enabled = true;
                button_close.Enabled = false;
                StatusCOM.Value = 0;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort1.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
                serialDataIn = serialPort1.ReadLine();
                this.BeginInvoke(new EventHandler(ProcessData));
        }

        public void ProcessData(object sender, EventArgs e)
        {
            try
            {
                indexofA = Convert.ToSByte(serialDataIn.IndexOf("A"));
                indexofB = Convert.ToSByte(serialDataIn.IndexOf("B"));
                indexofC = Convert.ToSByte(serialDataIn.IndexOf("C"));
                indexofD = Convert.ToSByte(serialDataIn.IndexOf("D"));

                dataSensor1 = serialDataIn.Substring(0, indexofA);
                dataSensor2 = serialDataIn.Substring(indexofA +1, (indexofB - indexofA)-1);
                dataSensor3 = serialDataIn.Substring(indexofB + 1, (indexofC - indexofB) - 1);
                dataSensor4 = serialDataIn.Substring(indexofC + 1, (indexofD - indexofC) - 1);

                textBox_sensor1.Text = dataSensor1;
                textBox_sensor2.Text = dataSensor2;
                textBox_sensor3.Text = dataSensor3;
                textBox_sensor4.Text = dataSensor4;

                verticalProgressBar1_sensor1.Value = Convert.ToInt16(dataSensor1);
                verticalProgressBar2_sensor2.Value = Convert.ToInt16(dataSensor2);
                verticalProgressBar3_sensor3.Value = Convert.ToInt16(dataSensor3);
                verticalProgressBar4_sensor4.Value = Convert.ToInt16(dataSensor4);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                
            }
        }
    }
}
