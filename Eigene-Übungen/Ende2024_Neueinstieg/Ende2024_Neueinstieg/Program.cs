using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ende2024_Neueinstieg
{
    internal class Program
    {
        static void Main()
        {
            // Deklarierung
            string username1 = "Hendrik";
            string username2 = "Massel";
            string password = "password";
            string geburtsdatum = "24.11.1998";
            int alter = 26;

            


            Console.WriteLine("Willkommen");
            Console.Write("Bitte gebe dein Vorname an:");
            string inputusername1 = Console.ReadLine();
            inputusername1 

            while (inputusername1 == username1)
            {
                if (inputusername1 == username1)
                {
                    Console.WriteLine("Willkommen {0}", inputusername1);
                    Console.ReadKey();
                }
                else if (inputusername1 != username1)

                {
                    Console.Clear();
                    Console.WriteLine("Falsche eingabe!");
                    Console.WriteLine("Bitte gebe dein Vorname an:");
                    Console.ReadLine(inputusername1);
                }

            }

            
            

         Console.ReadKey();



        }
    }
}
