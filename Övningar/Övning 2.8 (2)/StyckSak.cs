using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._8__2_
{
    class StyckSak : Vara
    {
        protected double styckPris = 0;
        protected int antal = 0;

        public StyckSak(string namn, double styckPris, int antal): base (namn)
        {
            this.namn = namn;
            this.styckPris = styckPris;
            this.antal = antal;
        }

        public double StyckPris
        {
            get { return this.styckPris; }
            set { this.styckPris = value; }
        }

        public int Antal
        {
            get { return this.antal; }
            set { this.antal = value; }
        }

        public override double BeräknaPris()
        {
            return styckPris * antal;
        }

        public override string ToString()
        {
            return namn + " " + antal + " st," + styckPris + " kr/st." + "\n" + BeräknaPris() + " kr";
        }
    }
}
