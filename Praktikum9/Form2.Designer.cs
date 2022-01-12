namespace Praktikum9
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.textBoxTanggal = new System.Windows.Forms.TextBox();
            this.textBoxIdCustomer = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga";
            // 
            // textBoxNo
            // 
            this.textBoxNo.Location = new System.Drawing.Point(174, 52);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.ReadOnly = true;
            this.textBoxNo.Size = new System.Drawing.Size(121, 22);
            this.textBoxNo.TabIndex = 5;
            // 
            // textBoxTanggal
            // 
            this.textBoxTanggal.Location = new System.Drawing.Point(174, 91);
            this.textBoxTanggal.Name = "textBoxTanggal";
            this.textBoxTanggal.ReadOnly = true;
            this.textBoxTanggal.Size = new System.Drawing.Size(121, 22);
            this.textBoxTanggal.TabIndex = 6;
            // 
            // textBoxIdCustomer
            // 
            this.textBoxIdCustomer.Location = new System.Drawing.Point(174, 127);
            this.textBoxIdCustomer.Name = "textBoxIdCustomer";
            this.textBoxIdCustomer.Size = new System.Drawing.Size(121, 22);
            this.textBoxIdCustomer.TabIndex = 7;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(174, 252);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.ReadOnly = true;
            this.textBoxHarga.Size = new System.Drawing.Size(100, 22);
            this.textBoxHarga.TabIndex = 9;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(298, 333);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(174, 207);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(199, 24);
            this.comboBoxMenu.TabIndex = 11;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxMenu);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxIdCustomer);
            this.Controls.Add(this.textBoxTanggal);
            this.Controls.Add(this.textBoxNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Contoh Trigger";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNo;
        private System.Windows.Forms.TextBox textBoxTanggal;
        private System.Windows.Forms.TextBox textBoxIdCustomer;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ComboBox comboBoxMenu;
    }
}