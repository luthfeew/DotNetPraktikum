
namespace Praktikum1
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
            this.cksop = new System.Windows.Forms.CheckBox();
            this.ckrica = new System.Windows.Forms.CheckBox();
            this.ckteh = new System.Windows.Forms.CheckBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.rbYa = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsop = new System.Windows.Forms.TextBox();
            this.txtrica = new System.Windows.Forms.TextBox();
            this.txtteh = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PELANGGAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MENU PILIHAN:";
            // 
            // cksop
            // 
            this.cksop.AutoSize = true;
            this.cksop.Location = new System.Drawing.Point(76, 206);
            this.cksop.Name = "cksop";
            this.cksop.Size = new System.Drawing.Size(171, 21);
            this.cksop.TabIndex = 3;
            this.cksop.Text = "SOP AYAM [Rp 9.000]";
            this.cksop.UseVisualStyleBackColor = true;
            this.cksop.CheckedChanged += new System.EventHandler(this.cksop_CheckedChanged);
            // 
            // ckrica
            // 
            this.ckrica.AutoSize = true;
            this.ckrica.Location = new System.Drawing.Point(76, 252);
            this.ckrica.Name = "ckrica";
            this.ckrica.Size = new System.Drawing.Size(209, 21);
            this.ckrica.TabIndex = 4;
            this.ckrica.Text = "AYAM RICA-RICA [Rp 8.500]";
            this.ckrica.UseVisualStyleBackColor = true;
            this.ckrica.CheckedChanged += new System.EventHandler(this.ckrica_CheckedChanged);
            // 
            // ckteh
            // 
            this.ckteh.AutoSize = true;
            this.ckteh.Location = new System.Drawing.Point(76, 300);
            this.ckteh.Name = "ckteh";
            this.ckteh.Size = new System.Drawing.Size(196, 21);
            this.ckteh.TabIndex = 5;
            this.ckteh.Text = "ES TEH MANIS [Rp 2.000]";
            this.ckteh.UseVisualStyleBackColor = true;
            this.ckteh.CheckedChanged += new System.EventHandler(this.ckteh_CheckedChanged);
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(193, 36);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(273, 22);
            this.txtnama.TabIndex = 6;
            // 
            // rbYa
            // 
            this.rbYa.AutoSize = true;
            this.rbYa.Location = new System.Drawing.Point(193, 83);
            this.rbYa.Name = "rbYa";
            this.rbYa.Size = new System.Drawing.Size(47, 21);
            this.rbYa.TabIndex = 7;
            this.rbYa.TabStop = true;
            this.rbYa.Text = "YA";
            this.rbYa.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(268, 83);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "TIDAK";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "JUMLAH";
            // 
            // txtsop
            // 
            this.txtsop.Location = new System.Drawing.Point(366, 204);
            this.txtsop.Name = "txtsop";
            this.txtsop.Size = new System.Drawing.Size(100, 22);
            this.txtsop.TabIndex = 10;
            // 
            // txtrica
            // 
            this.txtrica.Location = new System.Drawing.Point(366, 250);
            this.txtrica.Name = "txtrica";
            this.txtrica.Size = new System.Drawing.Size(100, 22);
            this.txtrica.TabIndex = 11;
            // 
            // txtteh
            // 
            this.txtteh.Location = new System.Drawing.Point(366, 298);
            this.txtteh.Name = "txtteh";
            this.txtteh.Size = new System.Drawing.Size(100, 22);
            this.txtteh.TabIndex = 12;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(76, 353);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(390, 38);
            this.btnHitung.TabIndex = 13;
            this.btnHitung.Text = "HITUNG";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(366, 423);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 22);
            this.txttotal.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "TOTAL Rp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtteh);
            this.Controls.Add(this.txtrica);
            this.Controls.Add(this.txtsop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbYa);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.ckteh);
            this.Controls.Add(this.ckrica);
            this.Controls.Add(this.cksop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rumah Makan \"Mantul\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cksop;
        private System.Windows.Forms.CheckBox ckrica;
        private System.Windows.Forms.CheckBox ckteh;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.RadioButton rbYa;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsop;
        private System.Windows.Forms.TextBox txtrica;
        private System.Windows.Forms.TextBox txtteh;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label5;
    }
}

