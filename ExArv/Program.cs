using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExArv
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Djur> alladjur = new List<Djur>();
            Djur Jens = new Djur("Jens");
            Fågel f = new Fågel("Kråka", 56.06f);
            alladjur.Add(Jens);
            alladjur.Add(f);
            Console.WriteLine(alladjur[1]);
            foreach (Djur d in alladjur)
            {
                Console.WriteLine(d.Ät());
            }
            Console.ReadKey();
        }
    }
}
