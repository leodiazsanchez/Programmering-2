using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism_Exempel
{
    class Cirkel : Figur
    {
        //Medlemsvaribelerna
        private double radie;

        public Cirkel(string färg,double radie) : base(färg)
        {
            this.radie = radie;
        }

        public override double BeräknaArea()
        {
            return Math.PI * radie * radie;
        }
    }
}
