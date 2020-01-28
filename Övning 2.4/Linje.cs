using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._4
{
    class Linje : Figur
    {
        public Linje(double bredd, double höjd) : base(höjd, bredd)
        {
            this.bredd = bredd;
            this.höjd = höjd;
        }

        public override string ToString()
        {
            return "Linje: " + base.ToString();
        }
    }
}
