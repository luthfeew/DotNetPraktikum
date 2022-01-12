using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum4
{
    class Mahasiswa
    {
        public string Nama, NIM;
        public int NilaiInggris, NilaiManajemen, NilaiBahasa, totalNilai;
        public double RataRata;

        public void hitungTotalNilai()
        {
            totalNilai = NilaiInggris + NilaiManajemen + NilaiBahasa;
        }

        public void hitungRataRata()
        {
            RataRata = (double) totalNilai / 3;
        }
    }
}
