using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._8__2_
{
    abstract class Vara
    {
        protected string namn = "";

        public Vara(string namn)
        {
            this.namn = namn;
        }

        abstract public double BeräknaPris();

    }
}
