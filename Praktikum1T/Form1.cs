using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum1T
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSuhu.Focus();
            txtHasil.ReadOnly = true;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            float x, hasil;
            string satuan = null;

            x = float.Parse(txtSuhu.Text);
            hasil = x;

            if (comboSuhu.SelectedIndex == 0)
            {
                if (radioF.Checked)
                {
                    hasil = (9 * x) / 5 + 32;
                }
                if (radioR.Checked)
                {
                    hasil = x * 4 / 5;
                }
            }
            if (comboSuhu.SelectedIndex == 1)
            {
                if (radioC.Checked)
                {
                    hasil = (x - 32) * 5 / 9;
                }
                if (radioR.Checked)
                {
                    hasil = (x - 32) * 4 / 9;
                }
            }
            if (comboSuhu.SelectedIndex == 2)
            {
                if (radioC.Checked)
                {
                    hasil = x * 5 / 4;
                }
                if (radioF.Checked)
                {
                    hasil = x * 9 / 4 + 32;
                }
            }

            if (radioC.Checked)
            {
                satuan = "Celcius";
            }
            if (radioF.Checked)
            {
                satuan = "Fahrenheit";
            }
            if (radioR.Checked)
            {
                satuan = "Reamur";
            }

            txtHasil.Text = hasil.ToString() + " " + satuan;
        }
    }
}
