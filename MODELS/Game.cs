
namespace STUDY.mathgame.MODELS;
//finished
internal class Game 
{
    public DateTime Date {  get; set; }

    public int Score { get; set; }

    public GameType Type { get; set; }    

    public double Time { get; set; }
}

internal enum GameType
{
    Multiplication,
    Division,
    Addition,
    Subtraction,
    Random
}

