using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] namabulan = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli" };

            textBox1.Text = namabulan.Length.ToString();

            for (int i = 0; i < namabulan.Length; i++)
            {
                listBox1.Items.Add("Bulan " + (i + 1) + " = " + namabulan[i]);
            }
        }
    }
}
