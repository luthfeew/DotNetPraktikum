
namespace Praktikum2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.RM = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.RMenikah = new System.Windows.Forms.RadioButton();
            this.inputJanak = new System.Windows.Forms.TextBox();
            this.inputGapok = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.inputTunj = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah Anak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gaji Pokok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tunjangan";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.RM);
            this.panel1.Location = new System.Drawing.Point(182, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 28);
            this.panel1.TabIndex = 5;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(173, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Perempuan";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // RM
            // 
            this.RM.AutoSize = true;
            this.RM.Location = new System.Drawing.Point(4, 4);
            this.RM.Name = "RM";
            this.RM.Size = new System.Drawing.Size(81, 21);
            this.RM.TabIndex = 0;
            this.RM.Text = "Laki-laki";
            this.RM.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.RMenikah);
            this.panel2.Location = new System.Drawing.Point(182, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 27);
            this.panel2.TabIndex = 6;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(173, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(125, 21);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "Belum Menikah";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // RMenikah
            // 
            this.RMenikah.AutoSize = true;
            this.RMenikah.Location = new System.Drawing.Point(4, 4);
            this.RMenikah.Name = "RMenikah";
            this.RMenikah.Size = new System.Drawing.Size(127, 21);
            this.RMenikah.TabIndex = 0;
            this.RMenikah.Text = "Sudah Menikah";
            this.RMenikah.UseVisualStyleBackColor = true;
            // 
            // inputJanak
            // 
            this.inputJanak.Location = new System.Drawing.Point(182, 138);
            this.inputJanak.Name = "inputJanak";
            this.inputJanak.Size = new System.Drawing.Size(100, 22);
            this.inputJanak.TabIndex = 7;
            this.inputJanak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputJanak_KeyPress);
            // 
            // inputGapok
            // 
            this.inputGapok.Location = new System.Drawing.Point(182, 188);
            this.inputGapok.Name = "inputGapok";
            this.inputGapok.Size = new System.Drawing.Size(275, 22);
            this.inputGapok.TabIndex = 8;
            this.inputGapok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputGapok_KeyPress);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(182, 231);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(171, 36);
            this.btnHitung.TabIndex = 9;
            this.btnHitung.Text = "Hitung Tunjangan";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // inputTunj
            // 
            this.inputTunj.Location = new System.Drawing.Point(182, 285);
            this.inputTunj.Name = "inputTunj";
            this.inputTunj.Size = new System.Drawing.Size(275, 22);
            this.inputTunj.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 364);
            this.Controls.Add(this.inputTunj);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.inputGapok);
            this.Controls.Add(this.inputJanak);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton RM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton RMenikah;
        private System.Windows.Forms.TextBox inputJanak;
        private System.Windows.Forms.TextBox inputGapok;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.TextBox inputTunj;
    }
}

