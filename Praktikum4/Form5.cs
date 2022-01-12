using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Segitiga sgtg = new Segitiga();

            sgtg.setAlas(string.IsNullOrEmpty(inputAlas.Text) ? 0 : Convert.ToInt32(inputAlas.Text));
            sgtg.setTinggi(string.IsNullOrEmpty(inputTinggi.Text) ? 0 : Convert.ToInt32(inputTinggi.Text));

            MessageBox.Show("LUAS SEGITIGA = " + sgtg.getLuas(), "HASIL");
        }
    }
}
