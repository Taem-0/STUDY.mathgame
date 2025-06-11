using STUDY.mathgame.MODELS;
//finished
namespace STUDY.mathgame
{
    internal class GameEngine
    {
        
        internal void MathGame(string message, MODELS.GameType gameType)
        {
            string operatorSymbol = "";
            GameType currentGameType = new GameType();
            Globals.correctAnswers = 0;
            Random randomGame = new Random();
            string? readResult;
            Helpers.gameDifficulty();
            Console.WriteLine(message);

            Helpers.GameStopWatch(true);

            for (int i = 0; i < Globals.MaxGames; i++)
            {

                if (gameType == GameType.Random)
                {
                    int randomOperation = randomGame.Next(0, 4);
                    currentGameType = (GameType)randomOperation;
                    
                }
                else
                {
                    currentGameType = gameType;
                }

                var numbers = Helpers.GameNumberGenerator(gameType);
                int firstNumber = numbers[0];
                int secondNumber = numbers[1];
                int correctAnswer = 0;

                switch (currentGameType)
                {
                    case GameType.Multiplication:
                        operatorSymbol = "x";
                        currentGameType = GameType.Multiplication;
                        correctAnswer = firstNumber * secondNumber;
                        break;
                    case GameType.Division:
                        operatorSymbol = "/";
                        currentGameType = GameType.Division;
                        correctAnswer = firstNumber / secondNumber;
                        break;
                    case GameType.Addition:
                        operatorSymbol = "+";
                        currentGameType = GameType.Addition;
                        correctAnswer = firstNumber + secondNumber;
                        break;
                    case GameType.Subtraction:
                        operatorSymbol = "-";
                        currentGameType = GameType.Subtraction;
                        correctAnswer = firstNumber - secondNumber;
                        break;

                    default:
                        Console.WriteLine("INVALID OPERATION");
                        break;
                }

                do
                {
                    Console.WriteLine($"ANSWER THIS: {firstNumber} {operatorSymbol} {secondNumber} = ");

                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        Globals.Response = readResult.ToLower().Trim();
                        Globals.ValidEntry = int.TryParse(Globals.Response, out Globals.PlayerAnswer);
                    }

                    if (Globals.ValidEntry)
                    {
                        if (Globals.PlayerAnswer == correctAnswer)
                        {
                            Console.WriteLine($"CORRECT !! {Globals.Response} IS CORRECT");
                            Globals.correctAnswers++;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"WRONG !! {Globals.Response} IS NOT CORRECT");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("INPUT A NUMBER !!");
                    }

                } while (!Globals.ValidEntry);

            }

            Helpers.GameStopWatch(false);

            Helpers.AddToHistory(Globals.correctAnswers, gameType);
            Console.WriteLine($"YOU ANSWERED {Globals.correctAnswers} out of {Globals.MaxGames} in {Globals.TimeTaken:F2}\nPRESS ANY BUTTON TO CONTINUE");
            Console.ReadLine();
            Console.Clear();

        }

    }

}
