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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            int bil1, bil2, hasil;

            try
            {
                bil1 = int.Parse(inputBilangan1.Text);
                bil2 = int.Parse(inputBilangan2.Text);

                if (bil1 < 0 | bil2 < 0)
                {
                    throw new Exception("Angka tidak boleh minus");
                }
                else
                {
                    hasil = bil1 + bil2;
                    richTextBoxHasil.Text = hasil.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                inputBilangan1.Text = "";
                inputBilangan2.Text = "";
                richTextBoxHasil.Text = "";
                inputBilangan1.Focus();
            }
            finally
            {
                richTextBoxHasil.ReadOnly = true;
                richTextBoxHasil.BackColor = Color.LightGreen;
            }
        }
    }
}
