using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kali(int a, int b)
        {
            return a * b;
        }

        private void btnNilai_Click(object sender, EventArgs e)
        {
            int a, b, c;

            a = int.Parse(inputBil1.Text);
            b = int.Parse(inputBil2.Text);
            c = kali(a, b);
            inputHasilNilai.Text = c.ToString();
        }

        void tambahlima(ref int a)
        {
            a += 5;
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            int c;
            c = int.Parse(inputAngka.Text);
            tambahlima(ref c);
            inputHasilRef.Text = c.ToString();
        }

        void bagidua(float a, out float b)
        {
            b = a / 2;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            float c, hasil;

            c = float.Parse(inputAngkaOut.Text);
            bagidua(c, out hasil);
            inputHasilOut.Text = hasil.ToString();
        }
    }
}
