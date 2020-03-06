using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._4
{
    abstract class Figur
    {
        protected double höjd = 0;
        protected double bredd = 0;

        public Figur(double höjd, double bredd)
        {
            this.höjd = höjd;
            this.bredd = bredd;
        }

        public override string ToString()
        {
            return bredd + "x" + höjd;
        }
    }
}
