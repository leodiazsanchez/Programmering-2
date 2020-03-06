using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exempel_1._6
{
    class Konto
    {
        string epost;
        string lösenord;

        public Konto (string epost,string lösen)
        {
            /*int index1 = epost.IndexOf("@");
            int index2 = epost.IndexOf(".");
            if (epost.Contains(".") && epost.Contains("@") && index1 < epost.Length-2 && index1 > 0 && index2 < epost.Length-1) {
                this.epost = epost;
            }

            else
            {
                throw new EpostAdressFormatException();
            }*/
            bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }
            if (IsValidEmail(epost) == true)
            {
                this.epost = epost;
            }
            else {
                throw new EpostAdressFormatException();
            }

            int antal = 0;
            for (int i = 0; i < lösen.Length; i++)
            {
                if (char.IsDigit(lösen[i])) antal++;
            }

            if(0<antal && antal < lösen.Length)
            {
               
                this.lösenord = lösen;

            } else
            {
                throw new LösenFormatException();
            }


        }




    }


}
