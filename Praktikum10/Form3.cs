using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum10
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form1 frm_pengguna = new Form1();
            frm_pengguna.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan keluar?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
