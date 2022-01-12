
namespace Praktikum1T
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioR = new System.Windows.Forms.RadioButton();
            this.btnHitung = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuhu = new System.Windows.Forms.TextBox();
            this.comboSuhu = new System.Windows.Forms.ComboBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "KONVERSI SUHU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SUHU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "KE:";
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Location = new System.Drawing.Point(123, 151);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(76, 24);
            this.radioC.TabIndex = 3;
            this.radioC.TabStop = true;
            this.radioC.Text = "Celcius";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(123, 182);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(98, 24);
            this.radioF.TabIndex = 4;
            this.radioF.TabStop = true;
            this.radioF.Text = "Fahrenheit";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // radioR
            // 
            this.radioR.AutoSize = true;
            this.radioR.Location = new System.Drawing.Point(123, 213);
            this.radioR.Name = "radioR";
            this.radioR.Size = new System.Drawing.Size(81, 24);
            this.radioR.TabIndex = 5;
            this.radioR.TabStop = true;
            this.radioR.Text = "Reamur";
            this.radioR.UseVisualStyleBackColor = true;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(43, 261);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(366, 49);
            this.btnHitung.TabIndex = 6;
            this.btnHitung.Text = "KONVERSI";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "HASIL";
            // 
            // txtSuhu
            // 
            this.txtSuhu.Location = new System.Drawing.Point(123, 101);
            this.txtSuhu.Name = "txtSuhu";
            this.txtSuhu.Size = new System.Drawing.Size(125, 27);
            this.txtSuhu.TabIndex = 8;
            // 
            // comboSuhu
            // 
            this.comboSuhu.FormattingEnabled = true;
            this.comboSuhu.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Reamur"});
            this.comboSuhu.Location = new System.Drawing.Point(258, 101);
            this.comboSuhu.Name = "comboSuhu";
            this.comboSuhu.Size = new System.Drawing.Size(151, 28);
            this.comboSuhu.TabIndex = 9;
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(192, 334);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(217, 27);
            this.txtHasil.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 408);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.comboSuhu);
            this.Controls.Add(this.txtSuhu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.radioR);
            this.Controls.Add(this.radioF);
            this.Controls.Add(this.radioC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TUGAS PRAKTIKUM 1 (19SA1198)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioR;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuhu;
        private System.Windows.Forms.ComboBox comboSuhu;
        private System.Windows.Forms.TextBox txtHasil;
    }
}

