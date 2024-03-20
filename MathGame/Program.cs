Console.WriteLine("Welcome to Math game!");
string name = GetName();



Menu(name);

string GetName()
{
    Console.WriteLine("Enter your name: ");
    var name = Console.ReadLine();
    return name;
}
void Menu(string? name)
{
    Console.WriteLine($"Hello, {name}! It's {DateTime.UtcNow}. This is your math's game.");
    Console.WriteLine("-----------------------------------------------------------------");


    Console.WriteLine("What game do you want to play today? Choose one option of the following:");
    Console.WriteLine("1. (+) Addition.");
    Console.WriteLine("2. (-) Subtraction.");
    Console.WriteLine("3. (*) Multiplication.");
    Console.WriteLine("4. (/) Division.");
    Console.WriteLine("5. History of privious games.\n ");
    Console.WriteLine("Write \"exit\" to close the game. ");


    var menuSelection = Console.ReadLine();

    switch (menuSelection)
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
            Console.WriteLine("This Feature not added yet. Try again later\n");
            break;
        default:
            Console.WriteLine("You entered a wrong value. Please try again.\n");
            break;
    }
}
void AdditionGame(string message)
{
    Console.WriteLine(message);
}
void SubtractionGame(string message)
{
    Console.WriteLine(message);
}
void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}
void DivisionGame(string message)
{
    Console.WriteLine(message);
}

