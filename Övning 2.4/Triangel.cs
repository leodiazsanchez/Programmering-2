using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._4
{
    class Triangel : Figur,IArea
    {
        public Triangel (double bredd, double höjd) : base (höjd, bredd)
        {
            this.bredd = bredd;
            this.höjd = höjd;
        }

        public double Area()
        {
            return (bredd * höjd) / 2;
        }

        public override string ToString()
        {
            return "Triangel: " + base.ToString();
        }
    }
}
