using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rechteck = new Rectangle();
            rechteck.Height = 10;
            rechteck.Width = 20;
            
            Console.WriteLine(rechteck.ToString());
            Console.WriteLine(rechteck.GetArea());
            Console.ReadKey();

            Cirle kreis = new Cirle();
            kreis.Radius = 3;
            Console.WriteLine(kreis.ToString());
            Console.WriteLine(kreis.GetArea());
            Console.ReadKey();

        }

    }
    abstract class Shape
    {
        public abstract double GetArea();

    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        
        public override double GetArea() 
        { 
            return Width * Height;
        }
        public override string ToString()
        {
            return "Rechteck mit einer Höhe von " + Height + " und einer Breite von " + Width;
        }

    }
    class Cirle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
        public override string ToString()
        {
            return "Kreis mit einem Radius von " + Radius;
        }
    }


}
