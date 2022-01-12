using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mahasiswa MHS = new Mahasiswa();

            MHS.NIM = inputNim.Text;
            MHS.Nama = inputNama.Text;
            MHS.NilaiInggris = int.Parse(inputInggris.Text);
            MHS.NilaiManajemen = int.Parse(inputManajemen.Text);
            MHS.NilaiBahasa = int.Parse(inputBahasa.Text);

            MHS.hitungTotalNilai();
            MHS.hitungRataRata();

            MessageBox.Show("Mahasiswa dengan NIM : " + MHS.NIM +
                " dan Nama : " + MHS.Nama +
                "\nMendapat total nilai : " + MHS.totalNilai +
                " dan nilai rata-rata : " + MHS.RataRata, "Hasil Perhitungan");
        }
    }
}
