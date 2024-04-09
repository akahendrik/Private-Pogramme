using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventArgss
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
        static void OnAdded(object sender, AddedEventArgs args)
        {
            Console.WriteLine("Das Object " + args.AddedItem.ToString() + "wurde hinzugefügt");
        }
    }
    
    class BetterList<T> : List<T>
    {
        public new void Add(T item)
        {
            base.Add(item);
            OnAdded(item);//Triggern des Events
        }

        public event AddEventHandler Added; //aufruf vom Event
        private void OnAdded(T item)
        {
           if (Added != null)
            {
                Added(this, new AddedEventArgs(item));
            }
        }

    }
    class AddedEventArgs : EventArgs
    { 
        public object AddedItem { get; set; }

        public AddedEventArgs(object addedItem) 
        {
            AddedItem = addedItem;
        }
    }
    delegate void AddEventHandler(object sender, AddedEventArgs args); //unbedingt notwendig für ein Event!!
}
