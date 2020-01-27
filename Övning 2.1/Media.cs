using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._1
{
    class Media
    {
        public string titel = "";

        public Media(string titel)
        {
            this.titel = titel;
        }

        public override string ToString()
        {
            return titel+":";
        }
    }
}
