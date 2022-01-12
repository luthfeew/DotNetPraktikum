namespace UTS_NET
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
            this.inputUang = new System.Windows.Forms.TextBox();
            this.buttonHitung = new System.Windows.Forms.Button();
            this.richTextBoxHasil = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator Budget";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uang Rp.";
            // 
            // inputUang
            // 
            this.inputUang.Location = new System.Drawing.Point(189, 93);
            this.inputUang.Name = "inputUang";
            this.inputUang.Size = new System.Drawing.Size(100, 22);
            this.inputUang.TabIndex = 2;
            // 
            // buttonHitung
            // 
            this.buttonHitung.Location = new System.Drawing.Point(119, 140);
            this.buttonHitung.Name = "buttonHitung";
            this.buttonHitung.Size = new System.Drawing.Size(170, 43);
            this.buttonHitung.TabIndex = 3;
            this.buttonHitung.Text = "HITUNG";
            this.buttonHitung.UseVisualStyleBackColor = true;
            this.buttonHitung.Click += new System.EventHandler(this.buttonHitung_Click);
            // 
            // richTextBoxHasil
            // 
            this.richTextBoxHasil.Location = new System.Drawing.Point(51, 208);
            this.richTextBoxHasil.Name = "richTextBoxHasil";
            this.richTextBoxHasil.Size = new System.Drawing.Size(297, 79);
            this.richTextBoxHasil.TabIndex = 4;
            this.richTextBoxHasil.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 335);
            this.Controls.Add(this.richTextBoxHasil);
            this.Controls.Add(this.buttonHitung);
            this.Controls.Add(this.inputUang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputUang;
        private System.Windows.Forms.Button buttonHitung;
        private System.Windows.Forms.RichTextBox richTextBoxHasil;
    }
}

