using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Hund hund = new Hund();
            hund.Geschlecht = "Männlich";
            hund.Alter = 10;

            Katze katze = new Katze();
            katze.Geschlecht = "Weiblich";
            katze.Alter = 4;

            Maus maus = new Maus();
            maus.Geschlecht = "Männlich";
            maus.Alter = 1;

            ITier[] tiere = new ITier[3];
            tiere[0] = hund;
            tiere[1] = katze;
            tiere[2] = maus;

            foreach (ITier tier in tiere)
            {
                Console.WriteLine("Geschlecht: {0}",tier.Geschlecht);
                Console.WriteLine("Alter: {0}", tier.Alter);

                tier.Fressen();
                tier.Trinken();
                Console.WriteLine("");

            }
            Console.ReadKey();






        }
    }

    interface ITier
    {
        string Geschlecht { get; set; }
        int Alter {  get; set; }


        void Fressen();

        void Trinken();

    }

    class Hund : ITier 
    { 
        public string Geschlecht { get;set; }
        public int Alter { get; set; } 

        public void Fressen() 
        {
            Console.WriteLine("Der Hund Frisst!");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Hund Trinkt!");
        }
    
    }

    class Katze : ITier
    {
        public string Geschlecht { get; set; }
        public int Alter { get; set; }

        public void Fressen()
        {
            Console.WriteLine("Die Katze Frisst!");
        }

        public void Trinken()
        {
            Console.WriteLine("Die Katze Trinkt!");
        }
    }

    class Maus : ITier
    {
        public string Geschlecht { get; set; }
        public int Alter { get; set; }

        public void Fressen()
        {
            Console.WriteLine("Die Maus Frisst!");
        }

        public void Trinken()
        {
            Console.WriteLine("Die Maus Trinkt!");
        }
    }
}
