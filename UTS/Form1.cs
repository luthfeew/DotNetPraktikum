using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Waifu waifuku = new Waifu();
            waifuku.nama = inputWaifu.Text;

            if (String.IsNullOrEmpty(waifuku.nama) || comboBoxTemplate.SelectedItem == null)
            {
                MessageBox.Show("Isi nama Waifu & pilih template terlebih dahulu.", "Error");
                return;
            }

            if (comboBoxTemplate.SelectedIndex == 0)
            {
                waifuku.template1();
            } 
            else if (comboBoxTemplate.SelectedIndex == 1)
            {
                waifuku.template2();
            }
            else if (comboBoxTemplate.SelectedIndex == 2)
            {
                waifuku.template3();
            }
            else if (comboBoxTemplate.SelectedIndex == 3)
            {
                waifuku.template4();
            }
            else if (comboBoxTemplate.SelectedIndex == 4)
            {
                waifuku.template5();
            }

            richTextBox1.Text = waifuku.pesan;
            Clipboard.SetText(waifuku.pesan);
        }
    }
}
