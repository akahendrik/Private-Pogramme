using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>();
            {
                names.Add("Peter");
                names.Add("Alina");
                names.Add("Sabine");
                names.Add("Florian");
            }
            Console.WriteLine("UNSORTIERT!");
            Console.WriteLine("--------------------");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Sortiert!");
            Console.WriteLine("--------------------");

            names.Sort();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();

        }  
        
        
    }
}
