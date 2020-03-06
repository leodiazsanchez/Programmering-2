using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._2
{
    class Kontorist : Anställd
    {
        private double månadsLön;

        public Kontorist(string namn, double månadsLön) : base (namn)
        {
            this.månadsLön = månadsLön;
        }

        public override double BeräknaLön()
        {
            return månadsLön;
        }

        public override string ToString()
        {
            return base.ToString() + "(Kontoist)";
        }
    }
}
