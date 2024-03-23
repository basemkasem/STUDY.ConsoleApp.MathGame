﻿using MathGame.Modles;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
        //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        //new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
        //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        //new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
        //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
        //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
        //new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };
        internal static string GetName()
        {
            Console.Write("Enter your name: ");

            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty. Try again");
                name = Console.ReadLine();
            }
            return name;
        }
        internal static void PrintGames()
        {
            var gamesToPrint = games.Where(x => x.Date > new DateTime(2024, 03, 30)).OrderByDescending(x => x.Score);

            Console.Clear();
            Console.WriteLine("Games History: ");
            foreach (var game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts ");
            }
            Console.WriteLine("Press any key to go to the menu.");
            Console.ReadLine();
        }
        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Score = gameScore,
                Date = DateTime.Now,
                Type = gameType

            });
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

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("The answer needs to be an interger. Try again");
                result = Console.ReadLine();
            }
            return result;
        }
    }
}
