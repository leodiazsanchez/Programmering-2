using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._3
{
    public class SparKonto : BankKonto
    {
        public SparKonto (string personNr, double ränteSats) : base (personNr, ränteSats)
        {

        }

        public override bool Uttag(double belopp)
        {
            if (belopp <= behållning)
            {
                behållning -= belopp;
                return true;
            }
            else return false;
        }

        public override double BeräknaRänta()
        {
            double ränta = behållning * rätesats / 100;
            behållning += ränta;
            return ränta;
        }

        public override string ToString()
        {
            return "Sparkonto" + personNummer + ": " + behållning;
        }
    }
}
