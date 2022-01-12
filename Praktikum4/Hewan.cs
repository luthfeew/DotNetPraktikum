using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum4
{
    class Hewan
    {
        public double sum;

        public string Hitung(int sapi, int kambing, int domba)
        {
            sum = sapi + kambing + domba;
            return "Anda membeli total " + sum + " hewan.";
        }

        public string Hitung(string sapi, string kambing, string domba)
        {
            string a = sapi == "y" ? "Anda membeli sapi." : "Anda tidak membeli sapi.";
            string b = kambing == "y" ? "\nAnda membeli kambing." : "\nAnda tidak membeli kambing.";
            string c = domba == "y" ? "\nAnda membeli domba." : "\nAnda tidak membeli domba.";
            return a + b + c;
        }
    }
}
