
namespace Praktikum3
{
    partial class Form4
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
            this.inputBilangan1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBilangan2 = new System.Windows.Forms.TextBox();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.richTextBoxHasil = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // inputBilangan1
            // 
            this.inputBilangan1.Location = new System.Drawing.Point(253, 36);
            this.inputBilangan1.Name = "inputBilangan1";
            this.inputBilangan1.Size = new System.Drawing.Size(100, 22);
            this.inputBilangan1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "BILANGAN 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "BILANGAN 2";
            // 
            // inputBilangan2
            // 
            this.inputBilangan2.Location = new System.Drawing.Point(253, 81);
            this.inputBilangan2.Name = "inputBilangan2";
            this.inputBilangan2.Size = new System.Drawing.Size(100, 22);
            this.inputBilangan2.TabIndex = 3;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(139, 131);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(214, 47);
            this.buttonTambah.TabIndex = 4;
            this.buttonTambah.Text = "TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // richTextBoxHasil
            // 
            this.richTextBoxHasil.Location = new System.Drawing.Point(139, 204);
            this.richTextBoxHasil.Name = "richTextBoxHasil";
            this.richTextBoxHasil.Size = new System.Drawing.Size(214, 68);
            this.richTextBoxHasil.TabIndex = 5;
            this.richTextBoxHasil.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 308);
            this.Controls.Add(this.richTextBoxHasil);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.inputBilangan2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBilangan1);
            this.Name = "Form4";
            this.Text = "CONTOH EXCEPTION HANDLING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBilangan1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputBilangan2;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.RichTextBox richTextBoxHasil;
    }
}