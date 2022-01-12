using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int kali(int a, int b)
        {
            return a * b;
        }

        // Method berparameter Nilai
        private void buttonNilai_Click(object sender, EventArgs e)
        {
            int a, b, c;

            a = int.Parse(inputBilangan1.Text);
            b = int.Parse(inputBilangan2.Text);
            c = kali(a, b);
            textBoxNilai.Text = c.ToString();
        }

        void tambahlima(ref int a)
        {
            a += 5;
        }

        // Method berparameter Ref
        private void buttonRef_Click(object sender, EventArgs e)
        {
            int c;
            c = int.Parse(inputAngka.Text);
            tambahlima(ref c);
            textBoxRef.Text = c.ToString();
        }

        void bagidua(float a, out float b)
        {
            b = a / 2;
        }

        // Method berparameter Out
        private void buttonOut_Click(object sender, EventArgs e)
        {
            float c, hasil;

            c = float.Parse(inputAngkaOut.Text);
            bagidua(c, out hasil);
            textBoxOut.Text = hasil.ToString();
        }
    }
}
