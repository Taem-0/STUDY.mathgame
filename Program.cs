using System;
using System.Collections.Generic;
//Global Variables
int maxGames = 0;
int numberRange = 0;
string? readResult;
string menuSelect = "";
bool validEntry = false;
int playerAnswer = 0;
var response = "";
List<string> gameRecords = new List<string>(); 
Random numberGenerator = new Random();

MainMenu();     

void MainMenu()
{
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

        readResult = Console.ReadLine();

        if (readResult != null)
        {
            menuSelect = readResult.ToLower().Trim();
        }

        Console.Clear();

        switch (menuSelect)
        {
            case "m":
                MultiplicationGame("MULTIPLICATION !! GAME,,,,, START !!");
                break;
            case "d":
                DivisionGame("DIVISION !! GAME,,,,, START !!");
                break;
            case "a":
                AdditionGame("ADDITION !! GAME,,,,, START !!");
                break;
            case "s":
                SubtractionGame("SUBTRACTION !! GAME,,,,, START !!");
                break;
            case "h":
                Console.WriteLine("LOOK INTO THEEE,,,,, CRYSTAL BALL OF RECORDS !!");

                foreach (string games in gameRecords)
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
    }
    while (menuSelect != "q");
}


//GAMES
void MultiplicationGame(string message)
{
    gameDifficulty(maxGames, numberRange);

    int correctAnswers = 0;

    Console.WriteLine($"{message}");

    for (int i = 0; i < maxGames; i++)
    {
        int firstNumber = numberGenerator.Next(1, numberRange);
        int secondNumber = numberGenerator.Next(1, numberRange);


        do
        {
            Console.WriteLine($@"ANSWER THIS: {firstNumber} x {secondNumber} = ");


            readResult = Console.ReadLine();
            if (readResult != null)
            {
                response = readResult.ToLower().Trim();
                validEntry = int.TryParse(response, out playerAnswer);
            }

            if (validEntry == true)
            {
                if (playerAnswer == firstNumber * secondNumber)
                {
                    Console.WriteLine($"CORRECT !! {response} IS CORRECT");
                    correctAnswers++;
                    Console.WriteLine();
                }
                else if (playerAnswer != firstNumber * secondNumber)
                {
                    Console.WriteLine($"WRONG !! {response} IS NOT CORRECT");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("INPUT A NUMBER !!");
            }

        } while (validEntry == false);



    }

    gameRecords.Add($"DATE: {DateTime.Now}\t\tMODE: MULTIPLICATION\t\tSCORE: {correctAnswers}");
    Console.WriteLine($"YOU ANSWERED {correctAnswers} out of {maxGames}\nPRESS ANY BUTTON TO CONTINUE");
    Console.ReadLine();
    Console.Clear();    
}

void DivisionGame(string message) 
{
    gameDifficulty(maxGames, numberRange);

    int correctAnswers = 0;

    Console.WriteLine($"{message}");

    for (int i = 0; i < maxGames; i++)
    {
        var divisionNumbers = DivisionGameNumberGenerator();
        int firstNumber = divisionNumbers[0];
        int secondNumber = divisionNumbers[1];


        do
        {
            Console.WriteLine($@"ANSWER THIS: {firstNumber} / {secondNumber} = ");


            readResult = Console.ReadLine();
            if (readResult != null)
            {
                response = readResult.ToLower().Trim();
                validEntry = int.TryParse(response, out playerAnswer);
            }

            if (validEntry == true)
            {
                if (playerAnswer == firstNumber / secondNumber)
                {
                    Console.WriteLine($"CORRECT !! {response} IS CORRECT");
                    correctAnswers++;
                    Console.WriteLine();
                }
                else if (playerAnswer != firstNumber / secondNumber)
                {
                    Console.WriteLine($"WRONG !! {response} IS NOT CORRECT");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("INPUT A NUMBER !!");
            }

        } while (validEntry == false);



    }

    gameRecords.Add($"DATE: {DateTime.Now}\t\tMODE: DIVISION\t\tSCORE: {correctAnswers}");
    Console.WriteLine($"YOU ANSWERED {correctAnswers} out of {maxGames}\nPRESS ANY BUTTON TO CONTINUE");
    Console.ReadLine();
    Console.Clear();





}

void AdditionGame(string message)
{
    gameDifficulty(maxGames, numberRange);

    int correctAnswers = 0;

    Console.WriteLine($"{message}");

    for (int i = 0; i < maxGames; i++)
    {
        int firstNumber = numberGenerator.Next(1, numberRange);
        int secondNumber = numberGenerator.Next(1, numberRange);


        do
        {
            Console.WriteLine($@"ANSWER THIS: {firstNumber} + {secondNumber} = ");


            readResult = Console.ReadLine();
            if (readResult != null)
            {
                response = readResult.ToLower().Trim();
                validEntry = int.TryParse(response, out playerAnswer);
            }

            if (validEntry == true)
            {
                if (playerAnswer == firstNumber + secondNumber)
                {
                    Console.WriteLine($"CORRECT !! {response} IS CORRECT");
                    correctAnswers++;
                    Console.WriteLine();
                }
                else if (playerAnswer != firstNumber + secondNumber)
                {
                    Console.WriteLine($"WRONG !! {response} IS NOT CORRECT");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("INPUT A NUMBER !!");
            }

        } while (validEntry == false);



    }

    gameRecords.Add($"DATE: {DateTime.Now}\t\tMODE: ADDITION\t\tSCORE: {correctAnswers}");
    Console.WriteLine($"YOU ANSWERED {correctAnswers} out of {maxGames}\nPRESS ANY BUTTON TO CONTINUE");
    Console.ReadLine();
    Console.Clear();


}

void SubtractionGame(string message)
{
    gameDifficulty(maxGames, numberRange);

    int correctAnswers = 0;

    Console.WriteLine($"{message}");

    for (int i = 0; i < maxGames; i++)
    {
        int firstNumber = numberGenerator.Next(1, numberRange);
        int secondNumber = numberGenerator.Next(1, numberRange);


        do
        {
            Console.WriteLine($@"ANSWER THIS: {firstNumber} - {secondNumber} = ");


            readResult = Console.ReadLine();
            if (readResult != null)
            {
                response = readResult.ToLower().Trim();
                validEntry = int.TryParse(response, out playerAnswer);
            }

            if (validEntry == true)
            {
                if (playerAnswer == firstNumber - secondNumber)
                {
                    Console.WriteLine($"CORRECT !! {response} IS CORRECT");
                    correctAnswers++;
                    Console.WriteLine();
                }
                else if (playerAnswer != firstNumber - secondNumber)
                {
                    Console.WriteLine($"WRONG !! {response} IS NOT CORRECT");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("INPUT A NUMBER !!");
            }

        } while (validEntry == false);



    }

    gameRecords.Add($"DATE: {DateTime.Now}\t\tMODE: SUBTRACTION\t\tSCORE: {correctAnswers}");
    Console.WriteLine($"YOU ANSWERED {correctAnswers} out of {maxGames}\nPRESS ANY BUTTON TO CONTINUE");
    Console.ReadLine();
    Console.Clear();
}



int[] gameDifficulty(int levels, int difficultyRange)
{
    string difficulty = "";

    int[] results = new int[2];
  
    Console.WriteLine("CHOOSE YOUR DIFFICULTY, CHALLENGER !!");
    Console.WriteLine("ONE, EASY");
    Console.WriteLine("TWO, MEDIUM");
    Console.WriteLine("THREE, HARD");

    readResult = Console.ReadLine();

    if (readResult != null)
    {
            difficulty = readResult.ToLower().Trim();
    }

    Console.Clear();

    switch(difficulty)
    {
        case "1":
            Console.WriteLine("YOU CHOSE EASY !!");
            Console.ReadLine();
            Console.Clear();

            levels = 5;
            difficultyRange = 9;

            break;
        case "2":
            Console.WriteLine("YOU CHOSE MEDIUM !!");
            Console.ReadLine();
            Console.Clear();


            levels = 10;
            difficultyRange = 49;

            break;
        case "3":
            Console.WriteLine("YOU CHOSE HARD !!");
            Console.ReadLine();
            Console.Clear();

            levels = 20;
            difficultyRange = 99;

            break;
        default:
            Console.WriteLine("INVALID !!");

            break;
    }

    results[0] = maxGames = levels;
    results[1] = numberRange = difficultyRange;

    return results; 

}

int[] DivisionGameNumberGenerator()
{
    Random divisionNumberGenerator = new Random();
    int firstNumber = numberGenerator.Next(1, numberRange);
    int secondNumber = numberGenerator.Next(1, numberRange);

    int[] result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = numberGenerator.Next(1, 99);
        secondNumber = numberGenerator.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}



