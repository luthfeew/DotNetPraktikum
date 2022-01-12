
namespace Praktikum4
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputPlat = new System.Windows.Forms.TextBox();
            this.inputModel = new System.Windows.Forms.TextBox();
            this.inputManufaktur = new System.Windows.Forms.TextBox();
            this.inputSpeed = new System.Windows.Forms.TextBox();
            this.inputTahun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plat Nomor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufaktur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "SpeedMax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tahun Produksi";
            // 
            // inputPlat
            // 
            this.inputPlat.Location = new System.Drawing.Point(171, 47);
            this.inputPlat.Name = "inputPlat";
            this.inputPlat.Size = new System.Drawing.Size(144, 22);
            this.inputPlat.TabIndex = 5;
            // 
            // inputModel
            // 
            this.inputModel.Location = new System.Drawing.Point(171, 75);
            this.inputModel.Name = "inputModel";
            this.inputModel.Size = new System.Drawing.Size(144, 22);
            this.inputModel.TabIndex = 6;
            // 
            // inputManufaktur
            // 
            this.inputManufaktur.Location = new System.Drawing.Point(171, 103);
            this.inputManufaktur.Name = "inputManufaktur";
            this.inputManufaktur.Size = new System.Drawing.Size(144, 22);
            this.inputManufaktur.TabIndex = 7;
            // 
            // inputSpeed
            // 
            this.inputSpeed.Location = new System.Drawing.Point(171, 131);
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.Size = new System.Drawing.Size(100, 22);
            this.inputSpeed.TabIndex = 8;
            // 
            // inputTahun
            // 
            this.inputTahun.Location = new System.Drawing.Point(171, 159);
            this.inputTahun.Name = "inputTahun";
            this.inputTahun.Size = new System.Drawing.Size(100, 22);
            this.inputTahun.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 215);
            this.Controls.Add(this.inputTahun);
            this.Controls.Add(this.inputSpeed);
            this.Controls.Add(this.inputManufaktur);
            this.Controls.Add(this.inputModel);
            this.Controls.Add(this.inputPlat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Contoh Class";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputPlat;
        private System.Windows.Forms.TextBox inputModel;
        private System.Windows.Forms.TextBox inputManufaktur;
        private System.Windows.Forms.TextBox inputSpeed;
        private System.Windows.Forms.TextBox inputTahun;
    }
}

