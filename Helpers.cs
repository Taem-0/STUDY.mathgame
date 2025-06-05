
using STUDY.mathgame.MODELS;

namespace STUDY.mathgame
{
    internal class Helpers
    {
        internal static void gameDifficulty()
        {
            string difficulty = "";

            Console.WriteLine("CHOOSE YOUR DIFFICULTY, CHALLENGER !!");
            Console.WriteLine("ONE, EASY");
            Console.WriteLine("TWO, MEDIUM");
            Console.WriteLine("THREE, HARD");

            Globals.ReadResult = Console.ReadLine();

            if (Globals.ReadResult != null)
            {
                difficulty = Globals.ReadResult.ToLower().Trim();
            }

            Console.Clear();

            switch (difficulty)
            {
                case "1":
                    Console.WriteLine("YOU CHOSE EASY !!");
                    Console.ReadLine();
                    Console.Clear();
                    Globals.MaxGames = 5;
                    Globals.NumberRange = 9;
                    break;
                case "2":
                    Console.WriteLine("YOU CHOSE MEDIUM !!");
                    Console.ReadLine();
                    Console.Clear();
                    Globals.MaxGames = 10;
                    Globals.NumberRange = 49;
                    break;
                case "3":
                    Console.WriteLine("YOU CHOSE HARD !!");
                    Console.ReadLine();
                    Console.Clear();
                    Globals.MaxGames = 20;
                    Globals.NumberRange = 99;
                    break;
                default:
                    Console.WriteLine("INVALID !!");
                    break;
            }
        }

        internal static int[] GameNumberGenerator(GameType gameType)
        {
            int firstNumber, secondNumber;

            if (gameType == GameType.Division)
            {

                do
                {
                    firstNumber = Globals.NumberGenerator.Next(1, Globals.NumberRange);
                    secondNumber = Globals.NumberGenerator.Next(1, Globals.NumberRange);
                }

                while (firstNumber % secondNumber != 0);

            }
            else
            {
                firstNumber = Globals.NumberGenerator.Next(1, Globals.NumberRange);
                secondNumber = Globals.NumberGenerator.Next(1, Globals.NumberRange);
            }

            return new int[] { firstNumber, secondNumber };
        }

        internal static void GameStopWatch(bool start)
        {
            if (start)
            {
                Globals.Stopwatch.Restart();
            }
            else
            {
                Globals.Stopwatch.Stop();
                Globals.TimeTaken = Globals.Stopwatch.Elapsed.TotalSeconds;
            }
        }

        internal static void DisplayGames()
        {
            Console.WriteLine("LOOK INTO THEEE,,,,, CRYSTAL BALL OF RECORDS !!");

            foreach (Game game in Globals.GameRecords)
            {
                Console.WriteLine($"DATE: {game.Date}\t\tMODE: {game.Type}\t\tSCORE: {game.Score}\t\tTIME: {game.Time:F2}\n");
            }


            Console.ReadLine();
            Console.Clear();
        }

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            //Globals.GameRecords.Add($"DATE: {DateTime.Now}\t\tMODE: {gameType}\t\tSCORE: {gameScore}\t\tTIME: {Globals.TimeTaken:F2}");

            Globals.GameRecords.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
                Time = Globals.TimeTaken
            });
        }    

    }
}
