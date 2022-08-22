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

namespace test_arduino_3
{
    public partial class Form1 : Form
    {
        string serialDataIn;
        sbyte indexOfB;
        sbyte indexOfA;
        sbyte indexOfZ;
        string derajat, derajat2;
        string open;
        int sudutservo1 = 45;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = true;
            btnControlInit(true);
            tbarSudut.Value = 45;
            cmbBaudRate.Text = "9600";
        }

        private void cmbComPort1_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            cmbComPort1.Items.Clear();
            cmbComPort1.Items.AddRange(portLists);
        }

        private void btnControlInit(bool state)
        {
            btnON1.Enabled = state;
            btnOFF1.Enabled = state;
            btnON2.Enabled = state;
            btnOFF2.Enabled = state;
            btnON3.Enabled = state;
            btnOFF3.Enabled = state;
            btnON4.Enabled = state;
            btnOFF4.Enabled = state;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cmbComPort1.Text;
                serialPort1.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                serialPort1.Open();


                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                btnControlInit(true);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                //serialPort1.PortName = cmbComPort1.Text;
                //serialPort1.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                serialPort1.Close();

                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                btnControlInit(false);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void btnON1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("ON1#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnOFF1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("OFF1#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnON2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("ON2#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnOFF2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("OFF2#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnON3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("ON3#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnOFF3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("OFF3#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnON4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("ON4#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnOFF4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("OFF4#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {

                indexOfA = Convert.ToSByte(serialDataIn.IndexOf("A"));
                derajat = serialDataIn.Substring(0, indexOfA);
                //tboxSudut.Text = derajat;
                tbarSudut.Value = Convert.ToInt32(derajat);
                serialPort1.Write(derajat.ToString() + "\n");
                lblSudut.Text = String.Format("Sudut Elevasi = " + derajat + "°");
                if (serialDataIn.Length > 4)
                {
                    indexOfB = Convert.ToSByte(serialDataIn.IndexOf("B"));
                    derajat2 = serialDataIn.Substring(3, indexOfB - 3);
                    tboxSudut.Text = derajat2;
                }
           }



            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }   
    }
}