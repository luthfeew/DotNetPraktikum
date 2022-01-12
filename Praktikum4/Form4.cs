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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sapi, kambing, domba;
            int sapix, kambingx, dombax;

            Hewan Kurban = new Hewan();

            sapi = inputSapi.Text;
            kambing = inputKambing.Text;
            domba = inputDomba.Text;

            if (int.TryParse(sapi, out sapix) && int.TryParse(kambing, out kambingx) && int.TryParse(domba, out dombax))
            {
                MessageBox.Show("HASIL :\n" + Kurban.Hitung(sapix, kambingx, dombax), "HASIL");
            }
            else
            {
                MessageBox.Show("HASIL :\n" + Kurban.Hitung(sapi, kambing, domba), "HASIL");
            }
        }
    }
}
