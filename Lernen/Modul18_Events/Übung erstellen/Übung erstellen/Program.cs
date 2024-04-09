using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_erstellen
{
    class Program
    {
        static void Main(string[] args)
        {
           BetterList<string> names = new BetterList<string>();
            names.Added += OnAdded;

            names.Add("Sabrina");
            names.Add("Alina");
            names.Add("Peter");
            names.Add("Uwe");

            Console.ReadKey();
        }
        static void OnAdded()
        {
            Console.WriteLine("Ein Objekt wurde hinzugefügt...");
        }
    }
    public delegate void AddEventHandler(); //unbedingt notwendig für ein Event!!
    class BetterList<T> : List<T> 
    {
        public new void Add (T item) 
        {
            base.Add (item);   
            OnAdded ();//Triggern des Events
        }

        public event AddEventHandler Added; //aufruf vom Event
        private void OnAdded() 
        {
                Added();
        }
        
    }


    
}
