using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1
{
    class Hund
    {
        public string Name { get; set; }
        public int Alter {  get; set; }
        public string Rasse { get; set; }
        public string Geschlecht { get; set; }

        //Konstruktor
        public Hund(string name,  int alter, string rasse, string geschlecht)
        {
            Name = name;
            Alter = alter;
            Rasse = rasse;
            Geschlecht = geschlecht;
        }


        public void Bellen(string Name)
        {
            
            Console.WriteLine("{0} Bellt!",Name);
        }

        public void Fressen(string Name) 
        {
            Console.WriteLine("{0} Frisst!", Name);
        }

        public void AlterAbfrage(int Alter)
        {
            Console.WriteLine("Der Hund {0} ist {1} Jahre alt!",Name, Alter);

        }

    }
}
