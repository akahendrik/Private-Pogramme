using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hund Franzi = new Hund();
            Hund Coco = new Hund("Coco", 5, "Schäferhund", "Männlich");
            //Franzi.Name = "Franzi";
            //Franzi.Alter = 10;
            //Franzi.Rasse = "Golden ret";
            //Franzi.Geschlecht = "Weiblich";


            //Franzi.Fressen(Franzi.Name);
            //Franzi.Bellen(Franzi.Name);

            Coco.Fressen(Coco.Name);
            Coco.Bellen(Coco.Name);
            Coco.AlterAbfrage(Coco.Alter);

            Console.ReadKey();  


        }
    }
}
