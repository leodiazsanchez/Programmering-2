using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser__mer__1
{
    class Resa
    {
        string kund;
        string dest;
        int dagar;

        public Resa(string k, string d, int d2)
        {
            kund = k;
            dest = d;
            dagar = d2;
        }

        public Resa()
        {
            kund = "?";
            dest = "?";
            dagar = 0;
        }

        public override string ToString()
        {
            return dest + ": " + dagar + " dagar";
        }

        public string Kund
        {
            get { return kund; }
        }
    }
}
