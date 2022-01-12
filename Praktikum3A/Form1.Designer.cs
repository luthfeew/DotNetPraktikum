
namespace Praktikum3A
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
            this.btnVoid = new System.Windows.Forms.Button();
            this.inputPanjang = new System.Windows.Forms.TextBox();
            this.inputHasilVoid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputLebar = new System.Windows.Forms.TextBox();
            this.btnFungsi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inputHasilFungsi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PANJANG";
            // 
            // btnVoid
            // 
            this.btnVoid.Location = new System.Drawing.Point(39, 89);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(186, 37);
            this.btnVoid.TabIndex = 1;
            this.btnVoid.Text = "LUAS [VOID]";
            this.btnVoid.UseVisualStyleBackColor = true;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // inputPanjang
            // 
            this.inputPanjang.Location = new System.Drawing.Point(125, 44);
            this.inputPanjang.Name = "inputPanjang";
            this.inputPanjang.Size = new System.Drawing.Size(100, 22);
            this.inputPanjang.TabIndex = 2;
            // 
            // inputHasilVoid
            // 
            this.inputHasilVoid.Location = new System.Drawing.Point(125, 154);
            this.inputHasilVoid.Name = "inputHasilVoid";
            this.inputHasilVoid.Size = new System.Drawing.Size(100, 22);
            this.inputHasilVoid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "HASIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "LEBAR";
            // 
            // inputLebar
            // 
            this.inputLebar.Location = new System.Drawing.Point(371, 44);
            this.inputLebar.Name = "inputLebar";
            this.inputLebar.Size = new System.Drawing.Size(100, 22);
            this.inputLebar.TabIndex = 6;
            // 
            // btnFungsi
            // 
            this.btnFungsi.Location = new System.Drawing.Point(285, 89);
            this.btnFungsi.Name = "btnFungsi";
            this.btnFungsi.Size = new System.Drawing.Size(186, 37);
            this.btnFungsi.TabIndex = 7;
            this.btnFungsi.Text = "LUAS [FUNGSI]";
            this.btnFungsi.UseVisualStyleBackColor = true;
            this.btnFungsi.Click += new System.EventHandler(this.btnFungsi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "HASIL";
            // 
            // inputHasilFungsi
            // 
            this.inputHasilFungsi.Location = new System.Drawing.Point(371, 154);
            this.inputHasilFungsi.Name = "inputHasilFungsi";
            this.inputHasilFungsi.Size = new System.Drawing.Size(100, 22);
            this.inputHasilFungsi.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 218);
            this.Controls.Add(this.inputHasilFungsi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFungsi);
            this.Controls.Add(this.inputLebar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputHasilVoid);
            this.Controls.Add(this.inputPanjang);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CONTOH METHOD VOID DAN FUNGSI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.TextBox inputPanjang;
        private System.Windows.Forms.TextBox inputHasilVoid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputLebar;
        private System.Windows.Forms.Button btnFungsi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputHasilFungsi;
    }
}

