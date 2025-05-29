namespace STUDY.mathgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? readResult;
            string menuSelect = "";

            do
            {
                Console.WriteLine("MATH MINI GAME !!");
                Console.WriteLine("CHOOOOOOSEEEE AN OPERATON:");
                Console.WriteLine("1. MULTIPLICATION");
                Console.WriteLine("2. DIVISION");
                Console.WriteLine("3. ADDITION");
                Console.WriteLine("4. SUBTRACTION");

                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    menuSelect = readResult.ToLower();
                }

                switch(menuSelect)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    default:

                        break;
                }
            }
            while (menuSelect != "exit");
        }
    }
}
