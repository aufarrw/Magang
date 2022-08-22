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

namespace Tabel_Tembak
{
    public static class Extensions
    {
        public static int findIndex<T>(this T[] isian0, T stringToFind)
        {
            return Array.IndexOf(isian0, stringToFind);
        }
    }

    public partial class Form1 : Form
    {
        string serialDataIn;
        string derajat;
        sbyte indexOfC;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            cmbBaudRate.Text = "9600";
        }

        private void cmbComPort1_DropDown_1(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            cmbComPort1.Items.Clear();
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
                serialPort1.Close();

                btnOpen.Enabled = true;
                btnClose.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
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

        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {
                indexOfC = Convert.ToSByte(serialDataIn.IndexOf("C"));
                derajat = serialDataIn.Substring(0, indexOfC);
                tboxSudut.Text = derajat;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string[] isian0 = { "100", "150", "200", "250", "300", "350", "400", "450"};
            int[] derajat0 = { 83, 80, 76, 73, 69, 64, 58, 45 };

            string[] isian1 = { "200", "250", "300", "350", "400", "450", "500", "550", "600", "650", "700", "750", "800" };
            int[] derajat1 = { 82, 80, 78, 77, 74, 72, 70, 68, 65, 62, 59, 55, 45 };

            string[] isian2 = {"300", "350", "400", "450", "500", "550", "600", "650", "700", "750", "800", "850", "900", "950",
                      "1000", "1050", "1100", "1150", "1200", "1250", "1300", "1350" };
            int[] derajat2 = { 83, 82, 81, 80, 79, 77, 76, 75, 74, 73, 71, 70, 68, 67, 65, 64, 62, 60, 58, 55, 52, 45 };

            string[] isian3 = {"600", "700", "800", "900", "1000", "1100", "1200", "1300", "1400", "1500", "1600", "1700", "1800",
                      "1900", "2000", "2100", "2200", "2300", "2400", "2500", "2600"};
            int[] derajat3 = { 83, 82, 81, 79, 78, 77, 76, 75, 73, 72, 71, 69, 68, 66, 64, 63, 61, 58, 56, 53, 46 };

            string[] isian4 = {"1900", "2000", "2100", "2200", "2300", "2400", "2500", "2600", "2700", "2800", "2900", "3000",
                      "3100", "3200", "3300", "3400", "3500", "3600", "3700" };
            int[] derajat4 = { 74, 73, 72, 71, 70, 69, 68, 67, 66, 65, 64, 62, 61, 60, 58, 56, 54, 51, 46 };

            string[] isian5 = {"2400", "2500", "2600", "2700", "2800", "2900", "3000", "3100", "3200", "3300", "3400", "3500",
                      "3600", "3700", "3800", "3900", "4000", "4100", "4200", "4300", "4400", "4500", "4600", "4700" };
            int[] derajat5 = { 74, 73, 72, 72, 71, 70, 69, 68, 68, 67, 66, 65, 64, 63, 62, 61, 60, 59, 57, 56, 54, 54, 49, 46 };

            string[] isian6 = {"3500", "3600", "3700", "3800", "3900", "4000", "4100", "4200", "4300", "4400", "4500", "4600",
                      "4700", "4800", "4900", "5000", "5100", "5200", "5300", "5400", "5500", "5600"};
            int[] derajat6 = { 69, 69, 68, 67, 67, 66, 65, 64, 63, 63, 62, 61, 60, 59, 58, 57, 55, 54, 52, 50, 47, 45 };

            string[] isian7 = {"3900", "4000", "4100", "4200", "4300", "4400", "4500", "4600", "4700", "4800", "4900", "5000",
                      "5100", "5200", "5300", "5400", "5500", "5600", "5700", "5800", "5900", "6000", "6100", "6200", "6300" };
            int[] derajat7 = { 69, 69, 68, 68, 67, 66, 66, 65, 64, 64, 63, 62, 61, 60, 60, 59, 58, 57, 55, 54, 53, 51, 49, 47, 45 };

            string[] isian8 = {"4500", "4600", "4700", "4800", "4900", "5000", "5100", "5200", "5300", "5400", "5500", "5600",
                      "5700", "5800", "5900", "6000", "6100", "6200", "6300", "6400", "6500"};
            int[] derajat8 = {68, 67, 66, 66, 65, 64, 64, 63, 62, 61, 61, 60, 59, 58, 57, 56, 55, 53, 52, 50, 45};

            if (tboxIsi.Text == "0")
            {
                string jarak = tboxJarak.Text;
                int a = isian0.findIndex(jarak);
                int b = derajat0[a];
                tboxSudut.Text = Convert.ToString(b);
                serialPort1.Write(b + "A" + "\n");
            }
            if (tboxIsi.Text == "1")
            {
                string jarak = tboxJarak.Text;
                int a = isian1.findIndex(jarak);
                int b = derajat1[a];
                tboxSudut.Text = Convert.ToString(b);
                serialPort1.Write(b + "A" + "\n");
            }
            if (tboxIsi.Text == "2")
            {
                string jarak = tboxJarak.Text;
                int a = isian2.findIndex(jarak);
                int b = derajat2[a];
                tboxSudut.Text = Convert.ToString(b);
                serialPort1.Write(b + "A" + "\n");
            }
            if (tboxIsi.Text == "3")
            {
                string jarak = tboxJarak.Text;
                int a = isian3.findIndex(jarak);
                int b = derajat3[a];
                tboxSudut.Text = Convert.ToString(b);
                serialPort1.Write(b + "A" + "\n");
            }
            if (tboxIsi.Text == "4")
            {
                string jarak = tboxJarak.Text;
                int a = isian4.findIndex(jarak);
                int b = derajat4[a];
                tboxSudut.Text = Convert.ToString(b);
                serialPort1.Write(b + "A" + "\n");
            }
            if (tboxIsi.Text == "5")
            {
                string jarak = tboxJarak.Text;
                int a = isian5.findIndex(jarak);
                int b = derajat5[a];
                tboxSudut.Text = Convert.ToString(b);
                serialPort1.Write(b + "A" + "\n");
            }
            if (tboxIsi.Text == "6")
            {
                string jarak = tboxJarak.Text;
                int a = isian6.findIndex(jarak);
                int b = derajat6[a];
                tboxSudut.Text = Convert.ToString(b);
                serialPort1.Write(b + "A" + "\n");
            }
            if (tboxIsi.Text == "7")
            {
                string jarak = tboxJarak.Text;
                int a = isian7.findIndex(jarak);
                int b = derajat7[a];
                tboxSudut.Text = Convert.ToString(b);
                serialPort1.Write(b + "A" + "\n");
            }
            if (tboxIsi.Text == "8")
            {
                string jarak = tboxJarak.Text;
                int a = isian8.findIndex(jarak);
                int b = derajat8[a];
                tboxSudut.Text = Convert.ToString(b);
                serialPort1.Write(b + "A" + "\n");
            }
        }

    }
}
