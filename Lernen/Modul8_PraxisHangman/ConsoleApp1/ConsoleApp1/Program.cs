using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();


        }
      
    
        static void MainMenu()
        {
            while (true)
            {

                Console.WriteLine("##### Hangman #####");
                Console.WriteLine("###################");
                Console.WriteLine(" ");
                Console.WriteLine("Wähle eine Aktion aus:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[1] Spielen");
                Console.WriteLine("[2] Beenden");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Aktion: ");

                int eingabe = Convert.ToInt32(Console.ReadLine());
                bool end = false;

                switch (eingabe)
                {
                    case 1:
                        StartGame();
                        break;

                    case 2:
                        end = true;
                        break;
                }
                if (end)
                {
                    break;
                }
                
                Console.Clear();

            }

        }

        static void StartGame()//zufälliges wort auswählen und starten der gameloop
        {
            string[] words = new string[]
            {
            "Maus",
            "Bildschirm",
            "Tastatur"

            };

            Random rnd = new Random();
            int index = rnd.Next(0,words.Length);
            string word = words[index].ToLower();

            GameLoop(word);






        }

        static void GameLoop(string word)//spielschleife
        {
            int lives = 10;
            string hiddenword = "";

            for (int i = 0; i < word.Length; i++) 
            {
                hiddenword += "_";
            }

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("Gesuchtes Wort: " + hiddenword);
                Console.Write("Noch übrige versuche: ");

                for (int i = 0;i < lives;i++) 
                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                    Console.ResetColor();
                }

                Console.WriteLine();
                Console.Write("Buchstabe: ");
                char charakter = Convert.ToChar(Console.ReadLine().ToLower());

                bool foundcharakterInWord = false;

                for (int i = 0;i < word.Length;i++) 
                {
                    if (word[i] == charakter)
                    {
                        foundcharakterInWord |= true;
                        break;
                    }
                }

                string temohiddenWord = hiddenword;
                hiddenword = "";

                if (foundcharakterInWord) 
                {
                    for (int i = 0; i < word.Length; ++i) 
                    {
                        if (word[i] == charakter)
                        {
                            hiddenword += charakter;
                        }
                        else if (temohiddenWord[i] != ' ') 
                        {
                            hiddenword += temohiddenWord[i];
                        }
                        else
                        {
                            hiddenword += '_';
                        }
                    }    
                    
                    if (hiddenword == word)
                    {
                        Console.Clear();
                        Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine("GEWONNEN");
                        Console.WriteLine("Das Word war: {0}",word);
                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    }
                }
                else
                {
                    hiddenword = temohiddenWord;

                    if (lives > 0)
                    {
                        lives--;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Du hast verloren!!");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                    }
                }

            }
            







        }
    }   
}
