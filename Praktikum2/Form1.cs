using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            // Deklarasi variabel
            // bool = boolean, laki = nama variabel, RM.Checked = (Radio RM) diceklis. Jadi jika RM diceklis maka value ini menjadi true
            bool laki = RM.Checked;
            // bool = boolean, menikah = nama variabel, RMenikah.Checked = (Radio RMenikah) diceklis. Jadi jika RMenikah diceklis maka value ini menjadi true
            bool menikah = RMenikah.Checked;
            // int = integer, janak = nama variabel, operator ternary (A ? B : C) A = kondisi, B = jika value A benar, C = jika value A salah
            // ex. jika inputJanak IsNullOrEmpty (kosong) maka akan diubah menjadi 0, jika tidak kosong maka akan mengambil value inputJanak di convert ke Int
            int janak = string.IsNullOrEmpty(inputJanak.Text) ? 0 : Convert.ToInt32(inputJanak.Text);
            // double = double, gapok = nama variabel, operator ternary (A ? B : C) sama seperti yang diatas
            double gapok = string.IsNullOrEmpty(inputGapok.Text) ? 0 : Convert.ToDouble(inputGapok.Text);
            // double = double, totalTunjangan = nama variabel, value = 0
            double totalTunjangan = 0;

            // jika laki & menikah bernilai true maka kondisi berikut akan dijalankan
            if (laki & menikah)
            {
                // kondisi yang dijalankan jika if diatas sesuai
                // operator ternary (A ? B : C) jika janak lebih dari 3 maka value = 3, jika janak tidak > 3 maka value = janak
                totalTunjangan = 0.2 * gapok * (janak > 3 ? 3 : janak);
            }

            // kolom inputTunj mengambil value dari total tunjangan diubah ke string supaya bisa ditampilkan
            inputTunj.Text = totalTunjangan.ToString();
        }

        private void inputJanak_KeyPress(object sender, KeyPressEventArgs e)
        {
            // fungsi untuk handle keyboard event [keypress] di inputJanak
            // intinya : hanya membolehkan keypress digit tidak boleh yang lain
            // lengkapnya : jika char BUKAN IsControl DAN BUKAN IsDigit maka...
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Tolak inputan keyboard
                e.Handled = true;
            }
        }

        private void inputGapok_KeyPress(object sender, KeyPressEventArgs e)
        {
            // fungsi untuk handle keyboard event [keypress] di inputGapok
            // intinya : hanya membolehkan keypress digit tidak boleh yang lain
            // lengkapnya : jika char BUKAN IsControl DAN BUKAN IsDigit maka...
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Tolak inputan keyboard
                e.Handled = true;
            }
        }
    }
}
