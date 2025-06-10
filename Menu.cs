//finished
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
                Console.WriteLine("R. RANDOM");
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
                        gameEngine.MathGame("MULTIPLICATION !! GAME,,,,, START !!", MODELS.GameType.Multiplication);
                        break;
                    case "d":
                        gameEngine.MathGame("DIVISION !! GAME,,,,, START !!", MODELS.GameType.Division);
                        break;
                    case "a":
                        gameEngine.MathGame("ADDITION !! GAME,,,,, START !!", MODELS.GameType.Addition);
                        break;
                    case "s":
                        gameEngine.MathGame("SUBTRACTION !! GAME,,,,, START !!", MODELS.GameType.Subtraction);
                        break;
                    case "r":
                        gameEngine.MathGame("RANDOM !! GAME,,,,, START !!", MODELS.GameType.Random);
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
