using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Modul10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Gebe deinen namen ein: ");
            


                Bankkonto konto = new Bankkonto();
                konto.Kontostand = 2500;
                konto.Besitzer = "Gaggi";
            

                string names = Name();
                

                if (names == konto.Besitzer)
                {
                    Console.WriteLine("Der aktuelle Kontostand beträgt : {0}", konto.Kontostand);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Zu diesem Name wurde kein Konto gefunden!");
                }

                Console.ReadKey();
            }
            
            while (true);
                

        }

        public static string Name()
        {
            string namen;
            
            namen = Console.ReadLine();
            return namen;

        }
    }


}
