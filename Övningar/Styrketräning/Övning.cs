using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrketräning
{
    class Övning
    {
        //Medlemsvariabler (Privata by default)
        string namn;
        int sets;
        int reps;
        int vikt;

        //Konstruktor

        public Övning(string n, int s, int r, int v)
        {
            namn = n;
            sets = s;
            reps = r;
            vikt = v;
        }

        public Övning()
        {
            namn = "?";
            sets = 0;
            reps = 0;
            vikt = 0;
        }

        public string resultat()
        {
            return (sets * reps * vikt).ToString();
        }

        //Egenskaper
        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }

        public int Sets
        {
            get { return sets; }
            set { sets = value; }
        }

        public int Reps
        {
            get { return reps; }
            set { reps = value; }
        }

        public int Vikt
        {
            get { return vikt; }
            set { vikt = value; }
        }
    }
}

