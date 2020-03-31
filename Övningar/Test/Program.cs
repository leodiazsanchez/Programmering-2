using System;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                StreamWriter sw = new StreamWriter("total.txt");
                using (StreamReader sr = new StreamReader("resultat.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        string[] words = line.Split(" ");
                        string str = words[0];
                        double medelvärde = (double.Parse(words[1]) + double.Parse(words[2]))/2;
                        double total = double.Parse(words[1]) + double.Parse(words[2]);
                        sw.WriteLine(words[0] + "\t" + total);
                        str += " Medelvärde: " + medelvärde.ToString() + " Total: " + total.ToString();
                        Console.WriteLine(str);
                    }
                    sw.Close();

                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
