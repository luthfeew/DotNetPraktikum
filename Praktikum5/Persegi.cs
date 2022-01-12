using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum5
{
    class Persegi
    {
        int x;

        public Persegi(int x)
        {
            this.x = x;
        }

        public virtual int luas()
        {
            return x * x;
        }
    }
}
