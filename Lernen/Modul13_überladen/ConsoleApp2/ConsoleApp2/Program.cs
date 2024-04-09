using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog coco = new Dog("Coco", 10);
            Console.WriteLine("Name: "+coco.Name);
            Console.WriteLine("Alter: "+coco.Age);
            Console.WriteLine("Besitzer: "+coco.Owner);

            Dog franzi = new Dog("Franzi", 15, "Hendrik");
            Console.WriteLine("Name: " + franzi.Name);
            Console.WriteLine("Alter: " + franzi.Age);
            Console.WriteLine("Besitzer: " + franzi.Owner);
            Console.ReadKey();

        }
    }
    class Dog
    {

        //Eigenschaften
        public string Name { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }


        //Konstruktor
        public Dog(string name, int age) 
        { 
            Name=name;
            Age = age;
            Owner = "no Owner";
        }
        
        public Dog(string name, int age, string owner) 
        {
            Name = name;
            Age = age;
            Owner = owner;
        }

        

    }
}
