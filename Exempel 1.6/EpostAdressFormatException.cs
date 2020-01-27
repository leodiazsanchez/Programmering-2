using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel_1._6
{
    class EpostAdressFormatException : Exception
    {
        string message = "Eposten måste följa formatet a@b.c";
        public override string ToString()
        {
            return message;
        }
    }
}
