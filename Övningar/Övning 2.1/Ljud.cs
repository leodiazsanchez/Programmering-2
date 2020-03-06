using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._1
{
    class Ljud : Media
    {

        protected double speltid = 0;

        public Ljud(string titel, double speltid) : base(titel)
        {
            this.speltid = speltid;
        }

        public override string ToString()
        {
            return base.ToString() + speltid + " minuter";
        }
    }
}
