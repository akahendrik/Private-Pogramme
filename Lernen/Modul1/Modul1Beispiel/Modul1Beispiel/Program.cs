using System;


namespace Modul1Beispiel
{
    class Program
    {
        static void Main()
        {
            Console.Write("Gebe deinen Namen ein: ");
            string name = Console.ReadLine();
            
            Console.Write("Gebe dein Alter an: ");
            int age = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine("Hallo {0} du bist {1} Jahre alt",name, age);

            Console.ReadKey();
        }
    }
}
