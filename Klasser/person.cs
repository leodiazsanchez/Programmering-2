using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Person
    {
        //Medlemsvariabler (Privata by default)
        string namn;
        double ålder;

        //Konstruktor

        public Person(string n, double å)
        {
            namn = n;
            ålder = å;
        }

        public Person()
        {
            namn = "???";
            ålder = 0;
        }

        public string skrivUt()
        {
            return "Namn:  " + namn + "\n" + "Ålder: " + ålder;
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

    }
}
