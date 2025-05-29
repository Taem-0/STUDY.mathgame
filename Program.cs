
int maxGames = 5;
string? readResult;
string menuSelect = "";
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
        Console.WriteLine("Q. QUIT");

        readResult = Console.ReadLine();

        if (readResult != null)
        {
            menuSelect = readResult.ToLower().Trim();
        }

        switch (menuSelect)
        {
            case "m":
                MultiplicationGame();
                break;
            case "d":
                DivisionGame();
                break;
            case "a":
                AdditionGame("ADDITION !! GAME,,,,, START !!");
                break;
            case "s":
                SubtractionGame();
                break;
            default:

                Console.WriteLine("INVALID !!");
                break;
        }
    }
    while (menuSelect != "q");
}


void MultiplicationGame()
{
    
}


void DivisionGame()
{
    
}


void SubtractionGame()
{
    
}


void AdditionGame(string message)
{
    Console.WriteLine($"{message}");

    for (int i = 0; i < maxGames; i++)
    {
        int firstNumber = numberGenerator.Next(1, 99);
        int secondNumber = numberGenerator.Next(1, 99);
        int correctAnswer = firstNumber + secondNumber;

        Console.WriteLine($@"ANSWER THIS: {firstNumber} + {secondNumber} = ");

        var response = Console.ReadLine();

        if (int.Parse(response) == correctAnswer)
        {
            Console.WriteLine($"CORRECT !! {response} IS CORRECT");
        }
        else if (int.Parse(response) != correctAnswer)
        {
            Console.WriteLine($"WRONG !! {response} IS NOT CORRECT");
        }
    }
        

}