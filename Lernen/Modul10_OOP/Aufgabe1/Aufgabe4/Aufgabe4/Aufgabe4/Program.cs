using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Person[] peaopleinClass =
            {
                new Teacher ("John", "Smith", 32),
                new Student ("Sabrina", "Müller", 18),
                new Student ("Anna", "Matt", 18),
                new Student ("Peter", "Fredl", 18),
                new Student ("Matthias", "Maier", 18)
            };
            
            foreach(Person p in peaopleinClass) 
            {
                p.PrintInformationen();

                if (p is Teacher) 
                { 
                    (p as Teacher).Teach();
                }
                else if (p is Student) 
                { 
                    (p as Student).ListenToTeach();
                }

                Console.WriteLine();
            }

            Console.ReadKey();


        }

        

        
    }

    class Person
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        
        public Person(string firstname, string secondname, int age)
        {
            FirstName = firstname;
            LastName = secondname;
            Age = age;
        }

        public void PrintInformationen() 
        {
            Console.WriteLine("Name: {0} {1}",FirstName, LastName);
            Console.WriteLine("Alter: {0}",Age);

        }
    }

    class Teacher : Person
    {
        public Teacher(string firstname, string secondname, int age) : base(firstname, secondname, age)
        {
        }

        public void Teach()
        {

            Console.WriteLine("Herr/Frau {0} unterrichten die Klasse!", LastName);

        }
    }
    class Student : Person 
    {
        public Student(string firstname, string secondname, int age) : base(firstname, secondname, age)
        {
        }

        public void ListenToTeach()
        {
            Console.WriteLine("Der / Die Schüler /in {0} {1} hört dem Lehrer zu!", FirstName, LastName);

        }
    }
}
