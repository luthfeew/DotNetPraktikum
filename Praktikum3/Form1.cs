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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method Void (prosedur)
        private void hitungluas()
        {
            int p, l, luas;
            p = int.Parse(inputPanjang.Text);
            l = int.Parse(inputLebar.Text);
            luas = p * l;
            textBoxHasilVoid.Text = luas.ToString();
        }

        // Method Fungsi
        private string luaspersegi()
        {
            int p, l, luas;
            p = int.Parse(inputPanjang.Text);
            l = int.Parse(inputLebar.Text);
            luas = p * l;
            return luas.ToString();
        }

        private void buttonVoid_Click(object sender, EventArgs e)
        {
            hitungluas();
        }

        private void buttonFungsi_Click(object sender, EventArgs e)
        {
            textBoxHasilFungsi.Text = luaspersegi();
        }
    }
}
