using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExArv
{
    //Basklass / Superklass
    class Djur
    {
        protected string namn;

        public Djur(string n)
        {
            namn = n;
        }

        public override string ToString()
        {
            return "Namn:" + namn;
        }

        public virtual string Ät()
        {
            return "Djur äter";
        }
    }
}
