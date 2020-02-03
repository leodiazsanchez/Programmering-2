using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._8__2_
{
    abstract class Vara : IComparable<Vara>
    {
        protected string namn = "";

        public Vara(string namn)
        {
            this.namn = namn;
        }

        public int CompareTo(Vara other)
        {
            if (this.BeräknaPris() == other.BeräknaPris())
            {
                return this.namn.CompareTo(other.namn);
            }

            return other.BeräknaPris().CompareTo(this.BeräknaPris());
        }

        abstract public double BeräknaPris();

    }
}
