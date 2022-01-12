namespace UTS
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
            this.inputSatu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inputDua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator Cinta Waifu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Kamu : ";
            // 
            // inputSatu
            // 
            this.inputSatu.Location = new System.Drawing.Point(214, 104);
            this.inputSatu.Name = "inputSatu";
            this.inputSatu.Size = new System.Drawing.Size(100, 22);
            this.inputSatu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "HITUNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama Waifumu :";
            // 
            // inputDua
            // 
            this.inputDua.Location = new System.Drawing.Point(214, 139);
            this.inputDua.Name = "inputDua";
            this.inputDua.Size = new System.Drawing.Size(100, 22);
            this.inputDua.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasil : ";
            // 
            // textBoxHasil
            // 
            this.textBoxHasil.Location = new System.Drawing.Point(214, 240);
            this.textBoxHasil.Name = "textBoxHasil";
            this.textBoxHasil.Size = new System.Drawing.Size(61, 22);
            this.textBoxHasil.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 315);
            this.Controls.Add(this.textBoxHasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputDua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputSatu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputSatu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputDua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHasil;
    }
}