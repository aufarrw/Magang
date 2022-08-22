
namespace testarray
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxJarak = new System.Windows.Forms.TextBox();
            this.tboxIsi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.tboxSudut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jarak";
            // 
            // tboxJarak
            // 
            this.tboxJarak.Location = new System.Drawing.Point(83, 27);
            this.tboxJarak.Name = "tboxJarak";
            this.tboxJarak.Size = new System.Drawing.Size(100, 20);
            this.tboxJarak.TabIndex = 1;
            // 
            // tboxIsi
            // 
            this.tboxIsi.Location = new System.Drawing.Point(83, 65);
            this.tboxIsi.Name = "tboxIsi";
            this.tboxIsi.Size = new System.Drawing.Size(100, 20);
            this.tboxIsi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Isi";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(83, 115);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // tboxSudut
            // 
            this.tboxSudut.Location = new System.Drawing.Point(83, 159);
            this.tboxSudut.Name = "tboxSudut";
            this.tboxSudut.Size = new System.Drawing.Size(100, 20);
            this.tboxSudut.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sudut";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 204);
            this.Controls.Add(this.tboxSudut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.tboxIsi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxJarak);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxJarak;
        private System.Windows.Forms.TextBox tboxIsi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox tboxSudut;
        private System.Windows.Forms.Label label3;
    }
}

