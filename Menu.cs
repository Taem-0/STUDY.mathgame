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
                        //gameEngine.MultiplicationGame("MULTIPLICATION !! GAME,,,,, START !!");
                        gameEngine.MathGame("MULTIPLICATION !! GAME,,,,, START !!", GameEngine.MathOperation.Multiplication, MODELS.GameType.Multiplication);
                        break;
                    case "d":
                        gameEngine.MathGame("DIVISION !! GAME,,,,, START !!", GameEngine.MathOperation.Division, MODELS.GameType.Division);
                        break;
                    case "a":
                        gameEngine.MathGame("ADDITION !! GAME,,,,, START !!", GameEngine.MathOperation.Addition, MODELS.GameType.Addition);
                        break;
                    case "s":
                        gameEngine.MathGame("SUBTRACTION !! GAME,,,,, START !!", GameEngine.MathOperation.Subtraction, MODELS.GameType.Subtraction);
                        break;
                    case "h":
                        Helpers.DisplayGames();
                        break;  
                    case "q":
                        break;
                    default:
                        Console.WriteLine("INVALID !!");
                        break;
                }

            } while (menuSelect != "q");
        }
    }
}
