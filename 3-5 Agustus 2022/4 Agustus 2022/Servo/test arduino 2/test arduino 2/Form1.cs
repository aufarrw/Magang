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

namespace test_arduino_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbServo.Enabled = false;
        }

        private void cmbComPort1_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            cmbComPort1.Items.Clear();
            cmbComPort1.Items.AddRange(portLists);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = cmbComPort1.Text;
            serialPort1.BaudRate = 9600;
            serialPort1.Open();

            gbServo.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
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
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                String str_sudut = tboxSudut.Text;

                serialPort1.Write(str_sudut + "\n");
                lblSudut.Text = "Sudut Elevasi = " + str_sudut + "°";
                tbarSudut.Value = Convert.ToInt32(str_sudut);
            }
        }

        private void tbarSudut_Scroll_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int int_sudut = tbarSudut.Value;

                serialPort1.Write(int_sudut.ToString() + "A" + "\n");
                lblSudut.Text = String.Format("Sudut Elevasi = " + int_sudut + "°");
                tboxSudut.Text = int_sudut.ToString();
            }
        }
    }
}
