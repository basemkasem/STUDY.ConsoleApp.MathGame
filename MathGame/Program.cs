using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Welcome to Math game!");

List<string> gamesHistory = new List<string>();
string name = GetName();

Menu(name);

string GetName()
{
    Console.Write("Enter your name: ");
    var name = Console.ReadLine();
    return name;
}
void Menu(string? name)
{
    Console.WriteLine($"Hello, {name}! It's {DateTime.UtcNow}. This is your math's game.");
    Console.WriteLine("-----------------------------------------------------------------");

    bool isGameOn = true;
    do
    {
        Console.Clear() ;
        Console.WriteLine("What game do you want to play today? Choose one option of the following:");
        Console.WriteLine("1. (+) Addition.");
        Console.WriteLine("2. (-) Subtraction.");
        Console.WriteLine("3. (*) Multiplication.");
        Console.WriteLine("4. (/) Division.");
        Console.WriteLine("5. History of privious games.\n ");
        Console.WriteLine("Write \"exit\" to close the game. ");


        var menuSelection = Console.ReadLine();

        switch (menuSelection.Trim().ToLower())
        {
            case "1":
                AdditionGame("Addition game selected");
                break; //Addition
            case "2":
                SubtractionGame("Subtraction game selected");
                break; //Subtraction
            case "3":
                MultiplicationGame("Multiplication game selected");
                break; //Multiplication
            case "4":
                DivisionGame("division game selected");
                break; //Division       
            case "5":
                GetGames();
                break;
            case "exit":
                isGameOn = false;
                break;
            default:
                Console.WriteLine("You entered a wrong value. Please try again.\n");
                break;
        }
    }while (isGameOn);
}

void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games History: ");
    foreach(var game in gamesHistory)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("Press any key to go to the menu.");
    Console.ReadLine();
}

void AdditionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    var random = new Random();
    var score = 0;

    int firstNumber ;
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
    AddToHistory(score, "Addition");
}

void AddToHistory(int gameScore, string gameType)
{
    gamesHistory.Add($"{DateTime.Now} - {gameType}: {gameScore} pts.");
}

void SubtractionGame(string message)
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
    AddToHistory(score, "subtraction");
}
void MultiplicationGame(string message)
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
    AddToHistory(score, "Multiplication");
}
void DivisionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    var score = 0;
    for (int i = 0;i < 5;i++)
    {
        var divisionNumbers = GetDivisionNumbers();
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
    AddToHistory(score, "Division");
}

int[] GetDivisionNumbers()
{
    var random = new Random();

    int firstNumber;
    int secondNumber;

    var result = new int[2];

    do
    {
        firstNumber = random.Next(1,99);
        secondNumber = random.Next(1,99);
    } while (firstNumber % secondNumber != 0);

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}