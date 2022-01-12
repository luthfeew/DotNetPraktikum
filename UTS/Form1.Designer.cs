namespace UTS
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
            this.inputWaifu = new System.Windows.Forms.TextBox();
            this.comboBoxTemplate = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(246, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUNIA WAIFU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ungkapkan perasaan ke Waifu tercinta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Waifu mu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Template :";
            // 
            // inputWaifu
            // 
            this.inputWaifu.Location = new System.Drawing.Point(320, 153);
            this.inputWaifu.Name = "inputWaifu";
            this.inputWaifu.Size = new System.Drawing.Size(138, 22);
            this.inputWaifu.TabIndex = 4;
            // 
            // comboBoxTemplate
            // 
            this.comboBoxTemplate.FormattingEnabled = true;
            this.comboBoxTemplate.Items.AddRange(new object[] {
            "Template 1",
            "Template 2",
            "Template 3",
            "Template 4",
            "Template 5"});
            this.comboBoxTemplate.Location = new System.Drawing.Point(320, 201);
            this.comboBoxTemplate.Name = "comboBoxTemplate";
            this.comboBoxTemplate.Size = new System.Drawing.Size(138, 24);
            this.comboBoxTemplate.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate Pesan dan Copy Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 322);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(653, 240);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 574);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxTemplate);
            this.Controls.Add(this.inputWaifu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WAIFU Anda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputWaifu;
        private System.Windows.Forms.ComboBox comboBoxTemplate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

