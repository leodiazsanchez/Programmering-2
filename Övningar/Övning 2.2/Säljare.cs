using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._2
{
    class Säljare : Anställd
    {
        private double provision;
        private double försäljning;

        public Säljare(string n, double provision, double försäljning) : base (n)
        {
            this.provision = provision;
            this.försäljning = försäljning;
        }

        public override double BeräknaLön()
        {
            return (försäljning * provision) / 100;
        }

        public override string ToString()
        {
            return base.ToString() + "(Säljare)";
        }
    }
}
