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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kendaraan MobilPertamaku = new Kendaraan();
            Produksi YearProduct = new Produksi();

            MobilPertamaku.KeteranganMobil = YearProduct;

            MobilPertamaku.PlatNomor = inputPlat.Text;
            MobilPertamaku.Model = inputModel.Text;
            MobilPertamaku.Manufaktur = inputManufaktur.Text;
            MobilPertamaku.SpeedMax = int.Parse(inputSpeed.Text);
            MobilPertamaku.KeteranganMobil.TahunProduksi = int.Parse(inputTahun.Text);

            MessageBox.Show("Mobilku : " + MobilPertamaku.Model +
                "\nBuatan : " + MobilPertamaku.Manufaktur +
                "\nDiproduksi tahun : " + MobilPertamaku.KeteranganMobil.TahunProduksi +
                "\nMemiliki kecepatan maksimal : " + MobilPertamaku.SpeedMax +
                "\ndan memiliki plat nomor : " + MobilPertamaku.PlatNomor, "Hasil");
        }
    }
}
