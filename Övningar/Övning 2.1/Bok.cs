using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._1
{
    class Bok : Media
    {
        protected int antalsidor=0;

        public Bok(string titel, int antalsidor) : base(titel)
        {
            this.antalsidor = antalsidor;
        }

        public override string ToString()
        {
            return base.ToString() + antalsidor + " sidor";
        }
    }
}
