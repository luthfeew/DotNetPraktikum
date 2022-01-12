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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        static void add(int a, out int sum)
        {
            sum = 10 + a;
        }

        void add1(int a, out int sum)
        {
            sum = 20 + a;
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            int c;
            int s = 0;

            c = int.Parse(inputBilangan.Text);

            // Method Static
            add(c, out s);
            textBoxStatic.Text = s.ToString();

            // Method Non Static
            Form3 k = new Form3();
            k.add1(c, out s);
            textBoxNonStatic.Text = s.ToString();
        }
    }
}
