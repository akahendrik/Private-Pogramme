using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.SqlServer.Server;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pfad = @"C:\Users\Hendrik\Desktop\TestOrdner";
            DirectoryInfo verzeichnis = new DirectoryInfo(pfad);

            DirectoryInfo [] verzeichnisse = verzeichnis.GetDirectories();

            foreach (DirectoryInfo dir in verzeichnisse) 
            {
                Console.WriteLine(dir.Name);
            }

            Console.ReadKey();





        }
    }
}
