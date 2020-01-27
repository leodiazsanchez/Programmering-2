using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1._5
{
    class Fordon
    {
        public enum Typ { Bil, MC};

        private string regNr;
        private string märke;
        private string modell;
        private Typ fordonsTyp;

        public string RegNr
        {
            get { return regNr; }
            set { this.regNr = value; }
        }

        public string Märke
        {
            get { return märke; }
            set { this.märke = value; }
        }

        public string Modell
        {
            get { return modell; }
            set { this.modell = value; }
        }

        public Typ FordonsTyp
        {
            get { return fordonsTyp; }
            set { this.fordonsTyp = value; }
        }

        public Fordon(string regnr, string märke, string modell, Typ fordonstyp)
        {
            this.regNr = regnr;
            this.märke = märke;
            this.modell = modell;
            this.FordonsTyp = fordonstyp;
        }

        public static string GodkännRegNr (string regNr)
        {
            if (regNr.Length == 6)
            {
                for (int i = 0; i < 3; i++) if (!char.IsLetter(regNr[i])) return null;
                for (int i = 3; i < 6; i++) if (!char.IsDigit(regNr[i])) return null;
                return regNr.ToUpper();
            }
            return null;
        }

        public override string ToString()
        {
            return this.märke + " " + this.modell + " " + "(" + this.regNr + ")";
        }

    }
}
