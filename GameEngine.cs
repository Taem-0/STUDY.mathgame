using STUDY.mathgame.MODELS;

namespace STUDY.mathgame
{
    internal class GameEngine
    {
        internal enum MathOperation
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        internal void MathGame(string message, MathOperation operation, MODELS.GameType gameType)
        {
            string operatorSymbol = "";

            Helpers.gameDifficulty();
            Console.WriteLine(message);

            Helpers.GameStopWatch(true);    

            for (int i = 0; i < Globals.MaxGames; i++)
            {

                var numbers = Helpers.GameNumberGenerator(gameType);
                int firstNumber = numbers[0];
                int secondNumber = numbers[1];

                switch (operation)
                { 
                    case MathOperation.Multiplication:
                        operatorSymbol = "x";
                        break;
                    case MathOperation.Division:
                        operatorSymbol = "/";
                        break;
                    case MathOperation.Addition:
                        operatorSymbol = "+";
                        break;
                    case MathOperation.Subtraction:
                        operatorSymbol = "-";
                        break;
                    default:
                        Console.WriteLine("INVALID OPERATION");
                        break;
                }

                do
                {
                    Console.WriteLine($@"ANSWER THIS: {firstNumber} {operatorSymbol} {secondNumber} = ");

                    Globals.ReadResult = Console.ReadLine();
                    if (Globals.ReadResult != null)
                    {
                        Globals.Response = Globals.ReadResult.ToLower().Trim();
                        Globals.ValidEntry = int.TryParse(Globals.Response, out Globals.PlayerAnswer);
                    }

                    if (Globals.ValidEntry)
                    {
                        if (Globals.PlayerAnswer == firstNumber * secondNumber)
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

            GameType historyGameType = operation switch
            {
                MathOperation.Addition => GameType.Addition,
                MathOperation.Subtraction => GameType.Subtraction,
                MathOperation.Multiplication => GameType.Multiplication,
                MathOperation.Division => GameType.Division,
                _ => throw new ArgumentException("Invalid operation")
            };

            Helpers.AddToHistory(Globals.correctAnswers, historyGameType);
            Console.WriteLine($"YOU ANSWERED {Globals.correctAnswers} out of {Globals.MaxGames} in {Globals.TimeTaken:F2}\nPRESS ANY BUTTON TO CONTINUE");
            Console.ReadLine();
            Console.Clear();

        }

        /*
        internal void MultiplicationGame(string message)
        {
            Helpers.gameDifficulty();

            Console.WriteLine($"{message}");

            Helpers.GameStopWatch(true);

            for (int i = 0; i < Globals.MaxGames; i++)
            {
                int firstNumber = Globals.NumberGenerator.Next(1, Globals.NumberRange);
                int secondNumber = Globals.NumberGenerator.Next(1, Globals.NumberRange);

                do
                {
                    Console.WriteLine($@"ANSWER THIS: {firstNumber} x {secondNumber} = ");

                    Globals.ReadResult = Console.ReadLine();
                    if (Globals.ReadResult != null)
                    {
                        Globals.Response = Globals.ReadResult.ToLower().Trim();
                        Globals.ValidEntry = int.TryParse(Globals.Response, out Globals.PlayerAnswer);
                    }

                    if (Globals.ValidEntry)
                    {
                        if (Globals.PlayerAnswer == firstNumber * secondNumber)
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

            Helpers.AddToHistory(Globals.correctAnswers, GameType.Multiplication);
            Console.WriteLine($"YOU ANSWERED {Globals.correctAnswers} out of {Globals.MaxGames} in {Globals.TimeTaken:F2}\nPRESS ANY BUTTON TO CONTINUE");
            Console.ReadLine();
            Console.Clear();
        }
        */

        /*
        internal void DivisionGame(string message)
        {
            Helpers.gameDifficulty();

            Console.WriteLine($"{message}");
            Helpers.GameStopWatch(true);

            for (int i = 0; i < Globals.MaxGames; i++)
            {
                var divisionNumbers = Helpers.DivisionGameNumberGenerator();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                do
                {
                    Console.WriteLine($@"ANSWER THIS: {firstNumber} / {secondNumber} = ");

                    Globals.ReadResult = Console.ReadLine();
                    if (Globals.ReadResult != null)
                    {
                        Globals.Response = Globals.ReadResult.ToLower().Trim();
                        Globals.ValidEntry = int.TryParse(Globals.Response, out Globals.PlayerAnswer);
                    }

                    if (Globals.ValidEntry)
                    {
                        if (Globals.PlayerAnswer == firstNumber / secondNumber)
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

            Helpers.AddToHistory(Globals.correctAnswers, GameType.Division);
            Console.WriteLine($"YOU ANSWERED {Globals.correctAnswers} out of {Globals.MaxGames} in {Globals.TimeTaken:F2}\nPRESS ANY BUTTON TO CONTINUE");
            Console.ReadLine();
            Console.Clear();
        }

        internal void AdditionGame(string message)
        {
            Helpers.gameDifficulty();
            

            Console.WriteLine($"{message}");
            Helpers.GameStopWatch(true);

            for (int i = 0; i < Globals.MaxGames; i++)
            {
                int firstNumber = Globals.NumberGenerator.Next(1, Globals.NumberRange);
                int secondNumber = Globals.NumberGenerator.Next(1, Globals.NumberRange);

                do
                {
                    Console.WriteLine($@"ANSWER THIS: {firstNumber} + {secondNumber} = ");

                    Globals.ReadResult = Console.ReadLine();
                    if (Globals.ReadResult != null)
                    {
                        Globals.Response = Globals.ReadResult.ToLower().Trim();
                        Globals.ValidEntry = int.TryParse(Globals.Response, out Globals.PlayerAnswer);
                    }

                    if (Globals.ValidEntry)
                    {
                        if (Globals.PlayerAnswer == firstNumber + secondNumber)
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

            Helpers.AddToHistory(Globals.correctAnswers, GameType.Addition);
            Console.WriteLine($"YOU ANSWERED {Globals.correctAnswers} out of {Globals.MaxGames} in {Globals.TimeTaken:F2}\nPRESS ANY BUTTON TO CONTINUE");
            Console.ReadLine();
            Console.Clear();
        }

        internal void SubtractionGame(string message)
        {
            Helpers.gameDifficulty();

            Console.WriteLine($"{message}");
            Helpers.GameStopWatch(true);

            for (int i = 0; i < Globals.MaxGames; i++)
            {
                int firstNumber = Globals.NumberGenerator.Next(1, Globals.NumberRange);
                int secondNumber = Globals.NumberGenerator.Next(1, Globals.NumberRange);

                do
                {
                    Console.WriteLine($@"ANSWER THIS: {firstNumber} - {secondNumber} = ");

                    Globals.ReadResult = Console.ReadLine();
                    if (Globals.ReadResult != null)
                    {
                        Globals.Response = Globals.ReadResult.ToLower().Trim();
                        Globals.ValidEntry = int.TryParse(Globals.Response, out Globals.PlayerAnswer);
                    }

                    if (Globals.ValidEntry)
                    {
                        if (Globals.PlayerAnswer == firstNumber - secondNumber)
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

            Helpers.AddToHistory(Globals.correctAnswers, GameType.Subtraction);
            Console.WriteLine($"YOU ANSWERED {Globals.correctAnswers} out of {Globals.MaxGames} in {Globals.TimeTaken:F2}\nPRESS ANY BUTTON TO CONTINUE");
            Console.ReadLine();
            Console.Clear();
        }
        */

    }

}
        