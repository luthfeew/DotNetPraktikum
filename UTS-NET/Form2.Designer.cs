﻿namespace UTS_NET
{
    partial class Form2
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
            this.inputWaktu = new System.Windows.Forms.TextBox();
            this.inputJarak = new System.Windows.Forms.TextBox();
            this.buttonHitung = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKecepatan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator Kecepatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jarak : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Waktu : ";
            // 
            // inputWaktu
            // 
            this.inputWaktu.Location = new System.Drawing.Point(163, 156);
            this.inputWaktu.Name = "inputWaktu";
            this.inputWaktu.Size = new System.Drawing.Size(73, 22);
            this.inputWaktu.TabIndex = 3;
            // 
            // inputJarak
            // 
            this.inputJarak.Location = new System.Drawing.Point(163, 111);
            this.inputJarak.Name = "inputJarak";
            this.inputJarak.Size = new System.Drawing.Size(73, 22);
            this.inputJarak.TabIndex = 4;
            // 
            // buttonHitung
            // 
            this.buttonHitung.Location = new System.Drawing.Point(97, 202);
            this.buttonHitung.Name = "buttonHitung";
            this.buttonHitung.Size = new System.Drawing.Size(184, 38);
            this.buttonHitung.TabIndex = 5;
            this.buttonHitung.Text = "HITUNG";
            this.buttonHitung.UseVisualStyleBackColor = true;
            this.buttonHitung.Click += new System.EventHandler(this.buttonHitung_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kecepatan : ";
            // 
            // textBoxKecepatan
            // 
            this.textBoxKecepatan.Location = new System.Drawing.Point(181, 270);
            this.textBoxKecepatan.Name = "textBoxKecepatan";
            this.textBoxKecepatan.Size = new System.Drawing.Size(100, 22);
            this.textBoxKecepatan.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "menit";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 356);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxKecepatan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonHitung);
            this.Controls.Add(this.inputJarak);
            this.Controls.Add(this.inputWaktu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputWaktu;
        private System.Windows.Forms.TextBox inputJarak;
        private System.Windows.Forms.Button buttonHitung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKecepatan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}