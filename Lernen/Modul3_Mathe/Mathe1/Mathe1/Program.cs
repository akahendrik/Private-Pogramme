using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathe1
{
    class Program
    {
        static void Main()
        {
            

            Console.Write("Gebe eine Zahl an: ");
            int eingabe1 = Convert.ToInt32(Console.ReadLine());
            


            Console.Write("Gebe eine zweite Zahl an: ");
            int eingabe2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("{0} + {1} = {2}", eingabe1, eingabe2, eingabe1 + eingabe2);
            Console.WriteLine("{0} - {1} = {2}", eingabe1, eingabe2, eingabe1 - eingabe2);
            Console.WriteLine("{0} * {1} = {2}", eingabe1, eingabe2, eingabe1 * eingabe2);
            Console.WriteLine("{0} / {1} = {2}", eingabe1, eingabe2, eingabe1 / eingabe2);
            Console.WriteLine("{0} % {1} = {2}", eingabe1, eingabe2, eingabe1 % eingabe2);

            Console.ReadKey();





        }
    }
}
