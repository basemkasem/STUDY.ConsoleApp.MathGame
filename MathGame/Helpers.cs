namespace MathGame
{
    internal class Helpers
    {
        static List<string> games = new();
        internal static string GetName()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            return name;
        }
        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History: ");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("Press any key to go to the menu.");
            Console.ReadLine();
        }
        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: {gameScore} pts.");
        }
        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();

            int firstNumber;
            int secondNumber;

            var result = new int[2];

            do
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            } while (firstNumber % secondNumber != 0);

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
    }
}
