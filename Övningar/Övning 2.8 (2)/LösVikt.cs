using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._8__2_
{
    class LösVikt : Vara
    {
        protected double kiloPris = 0;
        protected double vikt = 0;

        public LösVikt(string namn,double kiloPris, double vikt) : base(namn)
        {
            this.namn = namn;
            this.kiloPris = kiloPris;
            this.vikt = vikt;
        }

        public double Vikt
        {
            get { return this.vikt; }
            set { this.vikt = value; }
        }

        public double KiloPris
        {
            get { return this.kiloPris; }
            set { this.kiloPris = value; }
        }

        public override double BeräknaPris()
        {
            return vikt * kiloPris;
        }

        public override string ToString()
        {
            return namn + " " + vikt + " kg," + kiloPris + " kr/kg." + "\n" + BeräknaPris() + " kr";
        }
    }
}
