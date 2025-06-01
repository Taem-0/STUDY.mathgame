using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDY.mathgame
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void MainMenu()
        {
            string menuSelect = "";

            do
            {
                Console.WriteLine("MATH MINI GAME !!");
                Console.WriteLine("CHOOOOOOSEEEE AN OPERATON:");
                Console.WriteLine("M. MULTIPLICATION");
                Console.WriteLine("D. DIVISION");
                Console.WriteLine("A. ADDITION");
                Console.WriteLine("S. SUBTRACTION");
                Console.WriteLine("H. HISTORY");
                Console.WriteLine("Q. QUIT");

                Globals.ReadResult = Console.ReadLine();

                if (Globals.ReadResult != null)
                {
                    menuSelect = Globals.ReadResult.ToLower().Trim();
                }

                Console.Clear();

                switch (menuSelect)
                {
                    case "m":
                        gameEngine.MultiplicationGame("MULTIPLICATION !! GAME,,,,, START !!");
                        break;
                    case "d":
                        gameEngine.DivisionGame("DIVISION !! GAME,,,,, START !!");
                        break;
                    case "a":
                        gameEngine.AdditionGame("ADDITION !! GAME,,,,, START !!");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("SUBTRACTION !! GAME,,,,, START !!");
                        break;
                    case "h":
                        Console.WriteLine("LOOK INTO THEEE,,,,, CRYSTAL BALL OF RECORDS !!");

                        foreach (string games in Globals.GameRecords)
                        {
                            Console.WriteLine($"{games}\n");
                        }

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("INVALID !!");
                        break;
                }

            } while (menuSelect != "q");
        }
    }
}
