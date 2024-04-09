using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10
{
    class Bankkonto
    {
        //Eigenschaften

        public decimal Kontostand {  get; set; }
        public string Besitzer { get; set; }

        
         
   

        //Methoden

        public void Einzahlen(decimal betrag)
        {
            Kontostand += betrag;
            Console.WriteLine("Es wurden {0} Euro auf das Konto eingezahlt!",betrag);
            Console.WriteLine("Der neue Kontostand beträgt {0} Euro",Kontostand);
        }   

        public void Auszahlen(decimal betrag)
        {
            Kontostand -= betrag;
            Console.WriteLine("Es wurden {0} Euro von dem Konto Abgehoben!", betrag);
            Console.WriteLine("Der neue Kontostand beträgt {0} Euro", Kontostand);
        }

        




    }
}
