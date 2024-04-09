using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dreieck: " + AreaCalculator.GetTriangleArea(5, 12));
            Console.WriteLine("Rechteck: " + AreaCalculator.GetRectangleArea(10, 4));
            Console.WriteLine("Quadrat: " + AreaCalculator.GetSquareArea(4));
            Console.WriteLine("Kreis: " + AreaCalculator.GetCircleArea(10));

            Console.ReadLine();




        }
    }

    class AreaCalculator
    {

        //Dreieck
        static public double GetTriangleArea(double Seitenlänge, double höhe)
        {
            

            return (höhe * Seitenlänge) / 2;
        }

        //Rechteck
        static public double GetRectangleArea(double höhe, double breite)
        {
            return höhe * breite;
        }

        //Quadrat
        static public double GetSquareArea(double seitenlänge)
        {
            return seitenlänge * seitenlänge;
        }

        //Kreis
        static public double GetCircleArea(double radius)
        {
            return radius * radius * Math.PI;
        }


    }
}
