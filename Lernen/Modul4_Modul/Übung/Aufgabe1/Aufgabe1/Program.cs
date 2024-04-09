using System;

namespace Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = GetTextImput("Gebe deinen Vornamen an: ");
            string secondname = GetTextImput("Gebe deinen nachnamen an: ");

            Console.WriteLine("Hallo {0} {1}", firstname ,secondname);

            Console.ReadKey();

        }

        static string GetTextImput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
