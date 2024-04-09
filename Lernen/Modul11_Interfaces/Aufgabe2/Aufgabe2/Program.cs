using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Gustav";
            Console.WriteLine(person.Name);
            Console.ReadKey();

        }
    }
    interface ILogger
    {
        void Log(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    class OutputLogger : ILogger 
    {
        public void Log(string message) 
        {
            Debug.WriteLine(message);
        }

    }
    class Person 
    {
        private ILogger logger = new OutputLogger();//oder ConsoleLogger verwenden = andere ausgabe ohne große änderungen im Code

        public string name;

        public string Name
        {
            get
            {
                logger.Log("Getter von Name wurde aufgerufen");
                return name;
            }
            set
            {
                logger.Log("Setter von Name wurde aufgerufen");
                name = value;
            }
        }

        
    }
    
}
