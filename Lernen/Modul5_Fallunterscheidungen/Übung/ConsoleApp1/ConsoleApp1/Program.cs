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
            int zahl1 = ersteZahl();
            int zahl2 = zweiteZahl();


            char op = Operator();

            switch (op)
            {
                case '+':
                    Console.WriteLine("{0} {1} {2} = {3}", zahl1, op, zahl2,zahl1 + zahl2);
                    break;
                case '-':
                    Console.WriteLine("{0} {1} {2} = {3}", zahl1, op, zahl2,zahl1 - zahl2);
                    break;
                case '*':
                    Console.WriteLine("{0} {1} {2} = {3}", zahl1, op, zahl2,zahl1 * zahl2);
                    break;
                case '/':
                    Console.WriteLine("{0} {1} {2} = {3}", zahl1, op, zahl2,zahl1 / zahl2);
                    break;

            }
            Console.ReadLine();
        }
           
            


        static int ersteZahl()
        {
            int eingabe1;
            Console.Write("Gebe eine Zahl an: ");
            eingabe1 = Convert.ToInt32(Console.ReadLine());

            return eingabe1;
        }

        static int zweiteZahl()
        {
            int eingabe2;
            Console.Write("Gebe eine Zahl an: ");
            eingabe2 = Convert.ToInt32(Console.ReadLine());

            return eingabe2;
        }

        static char Operator()
        {
            char eingabe2;
            Console.Write("Gebe einen Operator an: ");
            eingabe2 = Convert.ToChar(Console.ReadLine());

            return eingabe2;
        }

    }
}
