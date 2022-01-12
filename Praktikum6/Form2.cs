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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.Items.Clear();
            int[] bilangan = { 1, 3, 5, 7, 9, 11 };
            foreach (int x in bilangan)
            {
                listBox1.Items.Add(x);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string nama = textBox1.Text;
            foreach (char karakter in nama)
            {
                listBox1.Items.Add(karakter);
            }
        }
    }
}
