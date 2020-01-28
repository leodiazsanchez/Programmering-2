using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism_Exempel
{
    class Figur
    {
        private string färg;

        public Figur(string färg)
        {
            this.färg = färg;
        }

        public virtual double BeräknaArea()
        {
            return 0;
        }
    }
}
