using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Hund
    {
        //Medlemsvariabler (Privata by default)
        string namn;
        double ålder;
        string ras;

        //Konstruktor

        public Hund(string n, double å, string r)
        {
            namn = n;
            ålder = å;
            ras = r;
        }

        public Hund()
        {
            namn = "???";
            ålder = 0;
            ras = "???";
        }

        public string skrivUt()
        {
            return "Namn:  " + namn + "\n" + "Ålder: " + ålder + "\n" + "Ras: " + ras;
        }

        //Egenskaper
        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }

        public double Ålder
        {
            get { return ålder; }
            set { ålder = value; }
        }

        public string Ras
        {
            get { return ras; }
            set { ras = value; }
        }
    }
}
