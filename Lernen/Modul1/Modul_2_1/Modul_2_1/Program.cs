using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2_1
{
    internal class Program
    {
        static void Main()
        {
            /*byte age;
            ulong money = 185000000000;
            bool married;
            string name;
            char a;
            decimal müsli = 4.98m;
            */

            Console.WriteLine("Dein Vorname ist:");
            string name1 = Console.ReadLine();

            Console.WriteLine("Dein Nachname ist:");
            string name2 = Console.ReadLine();

            Console.WriteLine("Du bist wie alt?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine(name1);
            Console.WriteLine(name2);   
            Console.WriteLine(age);

            Console.WriteLine("Hallo {0} {1} ,willkommen zurück!",name1,name2);
            Console.ReadKey();







        }
    }
}
