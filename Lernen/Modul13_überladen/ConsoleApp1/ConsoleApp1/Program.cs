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
            Console.WriteLine(Sum(10.5, 5.5));
            Console.ReadKey();

            double[] numbers = new double[3];

            numbers[0] = 1.5;
            numbers[1] = 1.5;
            numbers[2] = 5.5;

            Console.WriteLine(Sum(numbers));
            Console.ReadKey();


        }

        static double Sum(double a ,double b)
        { 
            return a + b;
        }

        static double Sum(double[] numbers) 
        {
            double sum = 0;

            foreach (double zahl in numbers) 
            {
                sum += zahl;
            }
            return sum;
        }
    }
}
