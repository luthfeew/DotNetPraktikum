using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persegi square = new Persegi(int.Parse(textBox1.Text));
            Kubus cube = new Kubus(int.Parse(textBox1.Text));

            MessageBox.Show("Luas Persegi = " + square.luas() +
                "\nLuas Permukaan Kubus = " + cube.luas(), "HASIL");
        }
    }
}
