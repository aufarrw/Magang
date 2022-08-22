namespace test_arduino_2
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.cmbComPort1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gbServo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSudut)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.gbServo.Location = new System.Drawing.Point(9, 12);
            this.gbServo.Name = "gbServo";
            this.gbServo.Size = new System.Drawing.Size(388, 160);
            this.gbServo.TabIndex = 2;
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
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tboxSudut
            // 
            this.tboxSudut.Location = new System.Drawing.Point(17, 116);
            this.tboxSudut.Name = "tboxSudut";
            this.tboxSudut.Size = new System.Drawing.Size(116, 20);
            this.tboxSudut.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Masukan Sudut Elevasi";
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
            this.tbarSudut.Maximum = 180;
            this.tbarSudut.Name = "tbarSudut";
            this.tbarSudut.Size = new System.Drawing.Size(293, 45);
            this.tbarSudut.TabIndex = 0;
            this.tbarSudut.Scroll += new System.EventHandler(this.tbarSudut_Scroll_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.cmbComPort1);
            this.groupBox2.Location = new System.Drawing.Point(404, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 160);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM PORT";
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
            this.cmbComPort1.Location = new System.Drawing.Point(65, 43);
            this.cmbComPort1.Name = "cmbComPort1";
            this.cmbComPort1.Size = new System.Drawing.Size(121, 21);
            this.cmbComPort1.TabIndex = 8;
            this.cmbComPort1.DropDown += new System.EventHandler(this.cmbComPort1_DropDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 186);
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
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cmbComPort1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

