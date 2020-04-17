using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Elev : IComparable<Elev>
    {
        string namn;
        double prov1, prov2;

        public Elev(string namn, double prov1, double prov2)
        {
            this.namn = namn;
            this.prov1 = prov1;
            this.prov2 = prov2;
        }

        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }

        public double Total()
        {
            return prov1 + prov2;
        }

        public double Medelvärde()
        {
            return (prov1 + prov2)/2;
        }

        public int CompareTo(Elev other)
        {
            if (this.Total() == other.Total())
            {
                return namn.CompareTo(other.namn);
            }

            return Total().CompareTo(other.Total());
        }

        public override string ToString()
        {
            return namn + " Medelvärde: " + Medelvärde() + " Total: " + Total();
        }
    }
}
