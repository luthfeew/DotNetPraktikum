using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum4
{
    class Segitiga
    {
        private int alas;
        private int tinggi;
        private double luas;

        public void setAlas(int a)
        {
            alas = a;
        }

        public void setTinggi(int t)
        {
            tinggi = t;
        }

        public double getLuas()
        {
            luas = alas * tinggi * 0.5;
            return luas;
        }
    }
}
