using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Aufgabe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwort = "Gaggi!";
            string eingabe;

            do
            {
                Console.Write("Gebe das Passwort an: ");
                eingabe = Console.ReadLine();


            }while (passwort != eingabe);

            Console.WriteLine("Zugriff gewährt!");
            Console.ReadKey();



        }
    }
}
