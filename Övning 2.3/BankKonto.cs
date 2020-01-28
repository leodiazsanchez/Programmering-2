using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._3
{
    public abstract class BankKonto
    {
        protected string personNummer = "";
        protected double behållning = 0;
        protected double rätesats = 0;

        protected BankKonto(string personNummer, double rätesats)
        {
            this.personNummer = personNummer;
            this.rätesats = rätesats;
        }

        public double Behållning
        {
            get { return this.behållning; }
            set { this.behållning = value; }
        }

        public void Insättning (double belopp)
        {
            this.behållning += belopp;
        }

        public abstract bool Uttag(double belopp);
        public abstract double BeräknaRänta();
        public abstract override string ToString();

    }
}
