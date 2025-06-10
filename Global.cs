using System.Diagnostics;
using STUDY.mathgame.MODELS;
//finished
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
    internal static List<Game> GameRecords = new List<Game>();
    public static Random NumberGenerator = new Random();
    public static Stopwatch Stopwatch = new Stopwatch();
    public static int correctAnswers;
}
