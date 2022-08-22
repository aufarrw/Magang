using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.Threading;

namespace WpfApp2
{

    public partial class MainWindow : Window
    {
        string Responce;
        System.IO.Ports.SerialPort ArduinoPort = new System.IO.Ports.SerialPort();
        public MainWindow()
        {

            InitializeComponent();
            btnOn1.IsEnabled = false;
            btnOff1.IsEnabled = false;
            btnOn2.IsEnabled = false;
            btnOff2.IsEnabled = false;
            btnOn3.IsEnabled = false;
            btnOff3.IsEnabled = false;
            btnOn3.IsEnabled = false;
            btnOff4.IsEnabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoPort.PortName = cmbComPort1.Text;
                ArduinoPort.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                ArduinoPort.Open();
                ArduinoPort.WriteLine("open#");
                Thread.Sleep(10);
                Responce = ArduinoPort.ReadLine();
                if (Responce.Contains("open#"))
                {

                    btnOpen.IsEnabled = false;
                    btnClose.IsEnabled = true;
                    btnOpen.IsEnabled = true;
                    btnClose.IsEnabled = false;
                    btnFire.IsEnabled = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            ArduinoPort.PortName = cmbComPort1.Text;
            ArduinoPort.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
            ArduinoPort.close();
            ArduinoPort.WriteLine("close#");
            Thread.Sleep(10);
            Responce = ArduinoPort.ReadLine();
            if (Responce.Contains("close#"))
            {

                btnOpen.IsEnabled = true;
                btnClose.IsEnabled = false;
                btnFire.IsEnabled = false;
            }
        }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
}



        private void btnOn1_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoPort.WriteLine("on1");
                Thread.Sleep(10);
                Responce = ArduinoPort.ReadLine();
                if (Responce.Contains("On1"))
                {
                    btnOn1.IsEnabled = false;
                    btnOff1.IsEnabled = true;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnOff1_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoPort.WriteLine("Off1");
                Thread.Sleep(10);
                Responce = ArduinoPort.ReadLine();
                if (Responce.Contains("Off1"))
                {
                    btnOn1.IsEnabled = true;
                    btnOff1.IsEnabled = false;
                }
            }
            catch
            {

            }
        }

        private void btnOn2_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoPort.WriteLine("on2");
                Thread.Sleep(10);
                Responce = ArduinoPort.ReadLine();
                if (Responce.Contains("On2"))
                {
                    btnOn2.IsEnabled = false;
                    btnOff2.IsEnabled = true;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnOff2_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoPort.WriteLine("Off2");
                Thread.Sleep(10);
                Responce = ArduinoPort.ReadLine();
                if (Responce.Contains("Off2"))
                {
                    btnOn2.IsEnabled = true;
                    btnOff2.IsEnabled = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnOn3_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoPort.WriteLine("on3");
                Thread.Sleep(10);
                Responce = ArduinoPort.ReadLine();
                if (Responce.Contains("On3"))
                {
                    btnOn3.IsEnabled = false;
                    btnOff3.IsEnabled = true;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnOff3_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoPort.WriteLine("Off3");
                Thread.Sleep(10);
                Responce = ArduinoPort.ReadLine();
                if (Responce.Contains("Off3"))
                {
                    btnOn3.IsEnabled = true;
                    btnOff3.IsEnabled = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnOn4_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoPort.WriteLine("on4");
                Thread.Sleep(10);
                Responce = ArduinoPort.ReadLine();
                if (Responce.Contains("On4"))
                {
                    btnOn4.IsEnabled = false;
                    btnOff4.IsEnabled = true;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void btnOff4_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoPort.WriteLine("Off4");
                Thread.Sleep(10);
                Responce = ArduinoPort.ReadLine();
                if (Responce.Contains("Off4"))
                {
                    btnOn4.IsEnabled = true;
                    btnOff4.IsEnabled = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
