namespace test_arduino_3
{
    partial class Form1
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
            this.gbServo = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tboxSudut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSudut = new System.Windows.Forms.Label();
            this.tbarSudut = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cmbComPort1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOFF4 = new System.Windows.Forms.Button();
            this.btnON4 = new System.Windows.Forms.Button();
            this.btnOFF3 = new System.Windows.Forms.Button();
            this.btnON3 = new System.Windows.Forms.Button();
            this.btnOFF2 = new System.Windows.Forms.Button();
            this.btnON2 = new System.Windows.Forms.Button();
            this.btnOFF1 = new System.Windows.Forms.Button();
            this.btnON1 = new System.Windows.Forms.Button();
            this.gbServo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSudut)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbServo
            // 
            this.gbServo.Controls.Add(this.btnSend);
            this.gbServo.Controls.Add(this.tboxSudut);
            this.gbServo.Controls.Add(this.label4);
            this.gbServo.Controls.Add(this.label3);
            this.gbServo.Controls.Add(this.label2);
            this.gbServo.Controls.Add(this.lblSudut);
            this.gbServo.Controls.Add(this.tbarSudut);
            this.gbServo.Location = new System.Drawing.Point(12, 12);
            this.gbServo.Name = "gbServo";
            this.gbServo.Size = new System.Drawing.Size(388, 160);
            this.gbServo.TabIndex = 4;
            this.gbServo.TabStop = false;
            this.gbServo.Text = "Servo Position";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(298, 113);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tboxSudut
            // 
            this.tboxSudut.Location = new System.Drawing.Point(141, 115);
            this.tboxSudut.Name = "tboxSudut";
            this.tboxSudut.ReadOnly = true;
            this.tboxSudut.Size = new System.Drawing.Size(116, 20);
            this.tboxSudut.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ditembakkan pada sudut:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "100°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "0°";
            // 
            // lblSudut
            // 
            this.lblSudut.AutoSize = true;
            this.lblSudut.Location = new System.Drawing.Point(122, 26);
            this.lblSudut.Name = "lblSudut";
            this.lblSudut.Size = new System.Drawing.Size(84, 13);
            this.lblSudut.TabIndex = 1;
            this.lblSudut.Text = "Sudut Elevasi = ";
            // 
            // tbarSudut
            // 
            this.tbarSudut.Location = new System.Drawing.Point(33, 51);
            this.tbarSudut.Maximum = 90;
            this.tbarSudut.Minimum = 45;
            this.tbarSudut.Name = "tbarSudut";
            this.tbarSudut.Size = new System.Drawing.Size(293, 45);
            this.tbarSudut.TabIndex = 0;
            this.tbarSudut.Value = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbBaudRate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.cmbComPort1);
            this.groupBox2.Location = new System.Drawing.Point(407, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 160);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM PORT SETTING";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(153, 113);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "BAUD RATE :";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(107, 70);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cmbBaudRate.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "COM PORT :";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(35, 113);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cmbComPort1
            // 
            this.cmbComPort1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort1.FormattingEnabled = true;
            this.cmbComPort1.Location = new System.Drawing.Point(107, 43);
            this.cmbComPort1.Name = "cmbComPort1";
            this.cmbComPort1.Size = new System.Drawing.Size(121, 21);
            this.cmbComPort1.TabIndex = 8;
            this.cmbComPort1.DropDown += new System.EventHandler(this.cmbComPort1_DropDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnOFF4);
            this.groupBox1.Controls.Add(this.btnON4);
            this.groupBox1.Controls.Add(this.btnOFF3);
            this.groupBox1.Controls.Add(this.btnON3);
            this.groupBox1.Controls.Add(this.btnOFF2);
            this.groupBox1.Controls.Add(this.btnON2);
            this.groupBox1.Controls.Add(this.btnOFF1);
            this.groupBox1.Controls.Add(this.btnON1);
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lampu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Lampu 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Lampu 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Lampu 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lampu 1";
            // 
            // btnOFF4
            // 
            this.btnOFF4.Location = new System.Drawing.Point(486, 87);
            this.btnOFF4.Name = "btnOFF4";
            this.btnOFF4.Size = new System.Drawing.Size(75, 23);
            this.btnOFF4.TabIndex = 7;
            this.btnOFF4.Text = "OFF";
            this.btnOFF4.UseVisualStyleBackColor = true;
            this.btnOFF4.Click += new System.EventHandler(this.btnOFF4_Click);
            // 
            // btnON4
            // 
            this.btnON4.Location = new System.Drawing.Point(486, 41);
            this.btnON4.Name = "btnON4";
            this.btnON4.Size = new System.Drawing.Size(75, 23);
            this.btnON4.TabIndex = 6;
            this.btnON4.Text = "ON";
            this.btnON4.UseVisualStyleBackColor = true;
            this.btnON4.Click += new System.EventHandler(this.btnON4_Click);
            // 
            // btnOFF3
            // 
            this.btnOFF3.Location = new System.Drawing.Point(335, 87);
            this.btnOFF3.Name = "btnOFF3";
            this.btnOFF3.Size = new System.Drawing.Size(75, 23);
            this.btnOFF3.TabIndex = 5;
            this.btnOFF3.Text = "OFF";
            this.btnOFF3.UseVisualStyleBackColor = true;
            this.btnOFF3.Click += new System.EventHandler(this.btnOFF3_Click);
            // 
            // btnON3
            // 
            this.btnON3.Location = new System.Drawing.Point(335, 41);
            this.btnON3.Name = "btnON3";
            this.btnON3.Size = new System.Drawing.Size(75, 23);
            this.btnON3.TabIndex = 4;
            this.btnON3.Text = "ON";
            this.btnON3.UseVisualStyleBackColor = true;
            this.btnON3.Click += new System.EventHandler(this.btnON3_Click);
            // 
            // btnOFF2
            // 
            this.btnOFF2.Location = new System.Drawing.Point(182, 87);
            this.btnOFF2.Name = "btnOFF2";
            this.btnOFF2.Size = new System.Drawing.Size(75, 23);
            this.btnOFF2.TabIndex = 3;
            this.btnOFF2.Text = "OFF";
            this.btnOFF2.UseVisualStyleBackColor = true;
            this.btnOFF2.Click += new System.EventHandler(this.btnOFF2_Click);
            // 
            // btnON2
            // 
            this.btnON2.Location = new System.Drawing.Point(182, 41);
            this.btnON2.Name = "btnON2";
            this.btnON2.Size = new System.Drawing.Size(75, 23);
            this.btnON2.TabIndex = 2;
            this.btnON2.Text = "ON";
            this.btnON2.UseVisualStyleBackColor = true;
            this.btnON2.Click += new System.EventHandler(this.btnON2_Click);
            // 
            // btnOFF1
            // 
            this.btnOFF1.Location = new System.Drawing.Point(33, 87);
            this.btnOFF1.Name = "btnOFF1";
            this.btnOFF1.Size = new System.Drawing.Size(75, 23);
            this.btnOFF1.TabIndex = 1;
            this.btnOFF1.Text = "OFF";
            this.btnOFF1.UseVisualStyleBackColor = true;
            this.btnOFF1.Click += new System.EventHandler(this.btnOFF1_Click);
            // 
            // btnON1
            // 
            this.btnON1.Location = new System.Drawing.Point(33, 41);
            this.btnON1.Name = "btnON1";
            this.btnON1.Size = new System.Drawing.Size(75, 23);
            this.btnON1.TabIndex = 0;
            this.btnON1.Text = "ON";
            this.btnON1.UseVisualStyleBackColor = true;
            this.btnON1.Click += new System.EventHandler(this.btnON1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 292);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbServo);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbServo.ResumeLayout(false);
            this.gbServo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSudut)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tboxSudut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSudut;
        private System.Windows.Forms.TrackBar tbarSudut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cmbComPort1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOFF4;
        private System.Windows.Forms.Button btnON4;
        private System.Windows.Forms.Button btnOFF3;
        private System.Windows.Forms.Button btnON3;
        private System.Windows.Forms.Button btnOFF2;
        private System.Windows.Forms.Button btnON2;
        private System.Windows.Forms.Button btnOFF1;
        private System.Windows.Forms.Button btnON1;
    }
}

