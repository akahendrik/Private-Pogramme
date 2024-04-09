using System;
using System.Security.Cryptography;

namespace Aufgabe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gebe einen Radius ein: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = GetCircleArea(radius);
            Console.WriteLine("Die Fläche eines Kreises mit dem Radius {0} cm beträgt {1}cm².",radius, area);
            Console.ReadKey();

        }

        static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
