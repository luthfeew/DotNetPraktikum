
namespace Praktikum4
{
    partial class Form3
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
            this.inputNim = new System.Windows.Forms.TextBox();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.inputInggris = new System.Windows.Forms.TextBox();
            this.inputManajemen = new System.Windows.Forms.TextBox();
            this.inputBahasa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai Inggris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nilai Manajemen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nilai Bahasa";
            // 
            // inputNim
            // 
            this.inputNim.Location = new System.Drawing.Point(202, 57);
            this.inputNim.Name = "inputNim";
            this.inputNim.Size = new System.Drawing.Size(100, 22);
            this.inputNim.TabIndex = 5;
            // 
            // inputNama
            // 
            this.inputNama.Location = new System.Drawing.Point(202, 85);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(232, 22);
            this.inputNama.TabIndex = 6;
            // 
            // inputInggris
            // 
            this.inputInggris.Location = new System.Drawing.Point(202, 113);
            this.inputInggris.Name = "inputInggris";
            this.inputInggris.Size = new System.Drawing.Size(100, 22);
            this.inputInggris.TabIndex = 7;
            // 
            // inputManajemen
            // 
            this.inputManajemen.Location = new System.Drawing.Point(202, 141);
            this.inputManajemen.Name = "inputManajemen";
            this.inputManajemen.Size = new System.Drawing.Size(100, 22);
            this.inputManajemen.TabIndex = 8;
            // 
            // inputBahasa
            // 
            this.inputBahasa.Location = new System.Drawing.Point(202, 169);
            this.inputBahasa.Name = "inputBahasa";
            this.inputBahasa.Size = new System.Drawing.Size(100, 22);
            this.inputBahasa.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "HITUNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputBahasa);
            this.Controls.Add(this.inputManajemen);
            this.Controls.Add(this.inputInggris);
            this.Controls.Add(this.inputNama);
            this.Controls.Add(this.inputNim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Contoh Class dengan Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputNim;
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.TextBox inputInggris;
        private System.Windows.Forms.TextBox inputManajemen;
        private System.Windows.Forms.TextBox inputBahasa;
        private System.Windows.Forms.Button button1;
    }
}