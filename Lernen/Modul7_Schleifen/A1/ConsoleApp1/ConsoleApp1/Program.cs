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
            while (true)
            {
                int zahl1 = Zahl1();
                int zahl2 = Zahl2();
                char op = Op();

                if (op == '+')
                {
                    Console.WriteLine(" {0} {1} {2} = {3}", zahl1 ,op ,zahl2 ,zahl1 + zahl2);
                }
                if (op == '-')
                {
                    Console.WriteLine(" {0} {1} {2} = {3}", zahl1, op, zahl2, zahl1 - zahl2);
                }
                if (op == '*')
                {
                    Console.WriteLine(" {0} {1} {2} = {3}", zahl1, op, zahl2, zahl1 * zahl2);
                }
                if (op == '/')
                {
                    Console.WriteLine(" {0} {1} {2} = {3}", zahl1, op, zahl2, zahl1 / zahl2);
                }
                Console.ReadKey();
                Console.Clear();
                
            }
            


        }

        static int Zahl1()
        {
            Console.Write("Gebe Zahl1 an: ");
            int eingabe1;
            eingabe1 = Convert.ToInt32(Console.ReadLine());

            return eingabe1;

        }

        static int Zahl2()
        {
            Console.Write("Gebe Zahl2 an: ");
            int eingabe2;
            eingabe2 = Convert.ToInt32(Console.ReadLine());

            return eingabe2;

        }

        static char Op()
        {
            Console.Write("Gebe einen Rechenoperator an: ");
            char eingabe3;
            eingabe3 = Convert.ToChar(Console.ReadLine());

            return eingabe3;

        }

    }
}
