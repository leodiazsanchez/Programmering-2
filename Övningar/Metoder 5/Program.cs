using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_5
{
    class Program
    {
        static string RequestPony(int age, int weight)
        {
            if (age < 12)
            {
                return "Too young to compete.";
           
            } else{
                if (weight <= 30){
                    return "Class[A] pony";
                } else if (weight <= 50)
                {
                    return "Class[B] pony";
                }
                else if (weight <= 50)
                {
                    return "Class[B] pony";
                } else if (weight <=65)
                {
                    return "Class[C] pony";
                } else
                {
                    return "No ponies available for the given weight class.";
                }
            
            }

            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ålder?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Vikt?");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine(RequestPony(age,weight));
            Console.ReadKey();
        }
    }
}
