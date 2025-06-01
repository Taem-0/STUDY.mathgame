using System.Diagnostics;

public static class Globals
{
    public static int MaxGames = 0;
    public static int NumberRange = 0;
    public static string? ReadResult;
    public static double TimeTaken = 0;
    public static bool ValidEntry = false;
    public static int PlayerAnswer = 0;
    public static string Response = "";
    public static bool GameStart = true;
    public static List<string> GameRecords = new List<string>();
    public static Random NumberGenerator = new Random();
    public static Stopwatch Stopwatch = new Stopwatch();
}
