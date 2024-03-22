namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.Write($"{firstNumber} + {secondNumber} = ");
                var result = Console.ReadLine();
                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Correct answer. Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong answer. Type any key for the next question");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Game Over. Your score is {score}.Press Any key to go back to menu.");
            Console.ReadLine();
            Helpers.AddToHistory(score, "Addition");
        }
        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.Write($"{firstNumber} - {secondNumber} = ");
                var result = Console.ReadLine();
                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Correct answer. Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong answer. Type any key for the next question");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Game Over. Your score is {score}.Press Any kkey to go back to menu.");
            Console.ReadLine();
            Helpers.AddToHistory(score, "subtraction");
        }
        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.Write($"{firstNumber} * {secondNumber} = ");
                var result = Console.ReadLine();
                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Correct answer. Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong answer. Type any key for the next question");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Game Over. Your score is {score}.Press Any kkey to go back to menu.");
            Console.ReadLine();
            Helpers.AddToHistory(score, "Multiplication");
        }
        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var score = 0;
            for (int i = 0; i < 5; i++)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.Write($"{firstNumber} / {secondNumber} = ");
                var result = Console.ReadLine();
                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Correct answer. Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong answer. Type any key for the next question");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Game Over. Your score is {score}.Press Any kkey to go back to menu.");
            Console.ReadLine();
            Helpers.AddToHistory(score, "Division");
        }
    }
}
