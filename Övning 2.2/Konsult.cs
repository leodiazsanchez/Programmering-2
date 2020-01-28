using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._2
{
    class Konsult : Anställd
    {
        private double arbetadetimmar;
        private double timlön;

        public Konsult(string n, double arbetadetimmar, double timlön) : base(n)
        {
            this.arbetadetimmar = arbetadetimmar;
            this.timlön = timlön;
        }

        public override double BeräknaLön()
        {
            return (timlön * arbetadetimmar);
        }

        public override string ToString()
        {
            return base.ToString() + "(Konuslt)";
        }
    }
}
