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

namespace test_arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            btnOn.Enabled = false;
            btnOff.Enabled = false;
            progressBar1.Value = 0;
            cmbBaudRate.Text = "9600";
            string[] portLists = SerialPort.GetPortNames();
            cmbComPort1.Items.AddRange(portLists);
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
                btnOn.Enabled = true;
                btnOff.Enabled = true;
                progressBar1.Value = 100;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    btnOpen.Enabled = true;
                    btnClose.Enabled = false;
                    btnOn.Enabled = false;
                    btnOff.Enabled = false;
                    progressBar1.Value = 0;
                }
                catch(Exception error) 
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnOn_Click(object sender, EventArgs e)
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

        private void btnOff_Click(object sender, EventArgs e)
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
    }
}
