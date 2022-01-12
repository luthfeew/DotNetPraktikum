using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum5
{
    class Kubus:Persegi
    {
        public Kubus(int x)
        : base(x)
        {
        }

        public override int luas()
        {
            return 6 * base.luas();
        }
    }
}
