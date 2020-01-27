using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyttetävling2
{
    class Skytt
    {
        //Medlemsvariabler (Privata by default)
        string namn;
        int poäng;

        //Konstruktor

        public Skytt(string n, int p)
        {
            namn = n;
            poäng = p;
        }

        public Skytt()
        {
            namn = "???";
            poäng = 0;
        }

        public string resultat()
        {
            return namn + "\t" + poäng;
        }

        public override string ToString()
        {
            return namn + "\t" + poäng;
        }

        public bool ÄrGodkänd(int gGräns)
        {
            if (poäng < gGräns)
                return false;
            else return true;
        }

        //Egenskaper
        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }

        public int Poäng
        {
            get { return poäng; }
            set { poäng = value; }
        }
    }
}

