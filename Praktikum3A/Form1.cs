using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum3A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string luaspersegi()
        {
            int p, l, luas;
            p = int.Parse(inputPanjang.Text);
            l = int.Parse(inputLebar.Text);
            luas = p * l;
            return luas.ToString();
        }

        private void hitungluas()
        {
            int p, l, luas;
            p = int.Parse(inputPanjang.Text);
            l = int.Parse(inputLebar.Text);
            luas = p * l;
            inputHasilVoid.Text = luas.ToString();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            hitungluas();
        }

        private void btnFungsi_Click(object sender, EventArgs e)
        {
            inputHasilFungsi.Text = luaspersegi();
        }
    }
}
