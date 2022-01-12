
namespace Praktikum3
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
            this.inputBilangan = new System.Windows.Forms.TextBox();
            this.buttonProses = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNonStatic = new System.Windows.Forms.TextBox();
            this.textBoxStatic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILANGAN";
            // 
            // inputBilangan
            // 
            this.inputBilangan.Location = new System.Drawing.Point(253, 56);
            this.inputBilangan.Name = "inputBilangan";
            this.inputBilangan.Size = new System.Drawing.Size(100, 22);
            this.inputBilangan.TabIndex = 1;
            // 
            // buttonProses
            // 
            this.buttonProses.Location = new System.Drawing.Point(116, 109);
            this.buttonProses.Name = "buttonProses";
            this.buttonProses.Size = new System.Drawing.Size(237, 43);
            this.buttonProses.TabIndex = 2;
            this.buttonProses.Text = "STATIC DAN NON STATIC";
            this.buttonProses.UseVisualStyleBackColor = true;
            this.buttonProses.Click += new System.EventHandler(this.buttonProses_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "HASIL STATIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "HASIL NON STATIC";
            // 
            // textBoxNonStatic
            // 
            this.textBoxNonStatic.Location = new System.Drawing.Point(253, 237);
            this.textBoxNonStatic.Name = "textBoxNonStatic";
            this.textBoxNonStatic.Size = new System.Drawing.Size(100, 22);
            this.textBoxNonStatic.TabIndex = 5;
            // 
            // textBoxStatic
            // 
            this.textBoxStatic.Location = new System.Drawing.Point(253, 187);
            this.textBoxStatic.Name = "textBoxStatic";
            this.textBoxStatic.Size = new System.Drawing.Size(100, 22);
            this.textBoxStatic.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 311);
            this.Controls.Add(this.textBoxStatic);
            this.Controls.Add(this.textBoxNonStatic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonProses);
            this.Controls.Add(this.inputBilangan);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "CONTOH STATIC & NON STATIC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBilangan;
        private System.Windows.Forms.Button buttonProses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNonStatic;
        private System.Windows.Forms.TextBox textBoxStatic;
    }
}