using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._1
{
    class Film : Ljud
    {
        protected string Upplösning = "";

        public Film(string titel, double speltid, string Upplösning) : base(titel,speltid)
        {
            this.Upplösning = Upplösning;
        }
        public override string ToString()
        {
            return base.ToString() + " " +  Upplösning;
        }
    }
}
