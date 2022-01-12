
namespace Praktikum4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputSapi = new System.Windows.Forms.TextBox();
            this.inputKambing = new System.Windows.Forms.TextBox();
            this.inputDomba = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sapi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kambing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Domba";
            // 
            // inputSapi
            // 
            this.inputSapi.Location = new System.Drawing.Point(189, 93);
            this.inputSapi.Name = "inputSapi";
            this.inputSapi.Size = new System.Drawing.Size(100, 22);
            this.inputSapi.TabIndex = 3;
            // 
            // inputKambing
            // 
            this.inputKambing.Location = new System.Drawing.Point(189, 139);
            this.inputKambing.Name = "inputKambing";
            this.inputKambing.Size = new System.Drawing.Size(100, 22);
            this.inputKambing.TabIndex = 4;
            // 
            // inputDomba
            // 
            this.inputDomba.Location = new System.Drawing.Point(189, 190);
            this.inputDomba.Name = "inputDomba";
            this.inputDomba.Size = new System.Drawing.Size(100, 22);
            this.inputDomba.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "HASIL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Isikan dengan (y / n) atau jumlah hewannya.";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 334);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputDomba);
            this.Controls.Add(this.inputKambing);
            this.Controls.Add(this.inputSapi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "OVERLOADING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputSapi;
        private System.Windows.Forms.TextBox inputKambing;
        private System.Windows.Forms.TextBox inputDomba;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}