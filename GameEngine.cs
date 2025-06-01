
using STUDY.mathgame.MODELS;

namespace STUDY.mathgame
{
    internal class GameEngine
    {

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

    }
}
