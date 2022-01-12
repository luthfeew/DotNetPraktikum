using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            string hasil;
            double uang = double.Parse(inputUang.Text);

            if (uang >= 2000 && uang < 5000)
            {
                hasil = "Anda bisa membeli Es Teh.";
            } 
            else if (uang >= 5000 && uang < 7000)
            {
                hasil = "Anda bisa membeli Nasi Sayur.";
            }
            else if (uang >= 7000 && uang < 10000)
            {
                hasil = "Anda bisa membeli Nasi Sayur + Es Teh.";
            }
            else if (uang >= 10000)
            {
                hasil = "Anda bisa membeli Nasi Ayam + Es Teh.";
            }
            else
            {
                hasil = "Anda tidak bisa membeli apapun.";
            }

            richTextBoxHasil.Text = hasil;
        }
    }
}
