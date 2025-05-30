using System;
using System.Collections.Generic;
//Global Variables
int maxGames = 5;
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
        Console.WriteLine("R. RECORDS");
        Console.WriteLine("Q. QUIT");

        readResult = Console.ReadLine();

        if (readResult != null)
        {
            menuSelect = readResult.ToLower().Trim();
        }

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
            case "r":
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



void MultiplicationGame(string message)
{
    int correctAnswers = 0;

    Console.WriteLine($"{message}");

    for (int i = 0; i < maxGames; i++)
    {
        int firstNumber = numberGenerator.Next(1, 9);
        int secondNumber = numberGenerator.Next(1, 9);


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

int[] DivisionGameNumberGenerator()
{
    Random divisionNumberGenerator = new Random();
    int firstNumber = numberGenerator.Next(1, 99);
    int secondNumber = numberGenerator.Next(1, 99);

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

void AdditionGame(string message)
{

    int correctAnswers = 0;

    Console.WriteLine($"{message}");

    for (int i = 0; i < maxGames; i++)
    {
        int firstNumber = numberGenerator.Next(1, 9);
        int secondNumber = numberGenerator.Next(1, 9);


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

    int correctAnswers = 0;

    Console.WriteLine($"{message}");

    for (int i = 0; i < maxGames; i++)
    {
        int firstNumber = numberGenerator.Next(1, 9);
        int secondNumber = numberGenerator.Next(1, 9);


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




