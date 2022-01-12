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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kendaraan MobilPertamaku = new Kendaraan();
            Produksi YearProduct = new Produksi();

            YearProduct.TahunProduksi = 2004;

            MobilPertamaku.PlatNomor = "R 1234 AA";
            MobilPertamaku.Model = "Toyota Fortuner";
            MobilPertamaku.Manufaktur = "Toyota";
            MobilPertamaku.SpeedMax = 200;
            MobilPertamaku.KeteranganMobil = YearProduct;

            inputPlat.Text = MobilPertamaku.PlatNomor;
            inputModel.Text = MobilPertamaku.Model;
            inputManufaktur.Text = MobilPertamaku.Manufaktur;
            inputSpeed.Text = MobilPertamaku.SpeedMax.ToString();
            inputTahun.Text = MobilPertamaku.KeteranganMobil.TahunProduksi.ToString();
        }
    }
}
