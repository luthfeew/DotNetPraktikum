
namespace Praktikum3C
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
            this.inputBilangan = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputStatic = new System.Windows.Forms.TextBox();
            this.inputNonStatic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILANGAN";
            // 
            // inputBilangan
            // 
            this.inputBilangan.Location = new System.Drawing.Point(194, 51);
            this.inputBilangan.Name = "inputBilangan";
            this.inputBilangan.Size = new System.Drawing.Size(100, 22);
            this.inputBilangan.TabIndex = 1;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(49, 107);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(245, 43);
            this.btnProses.TabIndex = 2;
            this.btnProses.Text = "STATIC DAN NON STATIC";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "HASIL STATIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "HASIL NON STATIC";
            // 
            // inputStatic
            // 
            this.inputStatic.Location = new System.Drawing.Point(194, 186);
            this.inputStatic.Name = "inputStatic";
            this.inputStatic.Size = new System.Drawing.Size(100, 22);
            this.inputStatic.TabIndex = 5;
            // 
            // inputNonStatic
            // 
            this.inputNonStatic.Location = new System.Drawing.Point(194, 232);
            this.inputNonStatic.Name = "inputNonStatic";
            this.inputNonStatic.Size = new System.Drawing.Size(100, 22);
            this.inputNonStatic.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 303);
            this.Controls.Add(this.inputNonStatic);
            this.Controls.Add(this.inputStatic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.inputBilangan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CONTOH STATIC & NON STATIC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBilangan;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputStatic;
        private System.Windows.Forms.TextBox inputNonStatic;
    }
}

