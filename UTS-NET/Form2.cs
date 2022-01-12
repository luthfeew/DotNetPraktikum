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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double hitungKecepatan(double a, double b)
        {
            return a / (b / 60);
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            double a, b, c;

            a = double.Parse(inputJarak.Text);
            b = double.Parse(inputWaktu.Text);
            c = hitungKecepatan(a, b);

            textBoxKecepatan.Text = c.ToString() + " km/jam";
        }
    }
}
