using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel_1._6
{
    class LösenFormatException : Exception
    {
        string message = "Lösenordet måste innehålla både bokstäver och siffror";
        public override string ToString()
        {
            return message;
        }
    }
}
