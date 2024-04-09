using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string vorname;
            //Console.WriteLine("Gebe deinen Vornamen an: ");
            //vorname = GetTextInput();

            // string nachname;
            //Console.WriteLine("Gebe deinen Nachnamen an: ");
            // nachname = GetTextInput();

            // Console.WriteLine("Hallo {0} {1} ",vorname, nachname);
            // Console.ReadKey();

            double PI = Math.PI;
            double radius = GetRadius();

            double ergebnis = PI * radius * radius;
            Console.WriteLine("Die fläche eines kreises mit dem Radius von {0}cm beträgt {1}",radius, ergebnis);
            Console.ReadKey();











        }

       //static string GetTextInput()
        //{
            //string message;
            //message = Console.ReadLine();

            //return message;
        
        //}
        static double GetRadius()

        {
            double eingabe;
            Console.WriteLine("Gebe einen Radius an: ");
            eingabe = Convert.ToDouble(Console.ReadLine());

            return eingabe;

        }


    }
}
