using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism_Exempel
{
    class Triangel : Figur
    {
        private double bas;
        private double höjd;

        public Triangel(string färg,double bas, double höjd) : base(färg)
        {
            this.bas = bas;
            this.höjd = höjd;
        }

        public override double BeräknaArea()
        {
            return (bas * höjd)/2;
        }
    }
}
