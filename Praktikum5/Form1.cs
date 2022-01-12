using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonManusia_Click(object sender, EventArgs e)
        {
            Manusia mn1 = new Manusia();

            mn1.nama = "Luthfi Wijaya";
            mn1.gender = 'L';
            mn1.tinggibadan = 170;

            textBox1.Text = "-";
            textBox2.Text = mn1.nama;
            textBox3.Text = "-";
            textBox4.Text = mn1.gender.ToString();
            textBox5.Text = mn1.tinggibadan.ToString();
        }

        private void buttonPegawai_Click(object sender, EventArgs e)
        {
            Pegawai pg1 = new Pegawai();

            pg1.nip = "12345";
            pg1.nama = "Luthfi";
            pg1.jabatan = "Manager";
            pg1.gender = 'L';
            pg1.tinggibadan = 170;

            textBox1.Text = pg1.nip;
            textBox2.Text = pg1.nama;
            textBox3.Text = pg1.jabatan;
            textBox4.Text = pg1.gender.ToString();
            textBox5.Text = pg1.tinggibadan.ToString();

            label1.Text = "NIP";
            label3.Text = "Jabatan";
        }

        private void buttonMahasiswa_Click(object sender, EventArgs e)
        {
            Mahasiswa mhs1 = new Mahasiswa();

            mhs1.nim = "19SA1198";
            mhs1.nama = "Luthfi Wijaya";
            mhs1.jurusan = "Teknik Informatika";
            mhs1.gender = 'L';
            mhs1.tinggibadan = 170;

            textBox1.Text = mhs1.nim;
            textBox2.Text = mhs1.nama;
            textBox3.Text = mhs1.jurusan;
            textBox4.Text = mhs1.gender.ToString();
            textBox5.Text = mhs1.tinggibadan.ToString();

            label1.Text = "NIM";
            label3.Text = "Jurusan";
        }
    }
}
