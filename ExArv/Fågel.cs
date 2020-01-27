using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExArv
{
    //Subklass
    class Fågel : Djur
    {
        float vingbredd;

        public Fågel(string namn, float v) : base(namn){
            vingbredd = v;
        }

        public override string ToString()
        {
            return base.ToString()+ "\n" + "Vingbredd: " + vingbredd;
        }

        public override string Ät()
        {
            return "Fågel äter fisk";
        }

    }
}
