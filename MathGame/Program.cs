string? readResult;
string menuSelection = "";
int firstNumber = 0;
int secondNumber = 0;
int result = 0;

Console.WriteLine("Welcome to Math game!\n");

do
{
    Console.WriteLine("Choose one option of the following:");
    Console.WriteLine("1. (+) Addition.");
    Console.WriteLine("2. (-) Subtraction.");
    Console.WriteLine("3. (*) Multiplication.");
    Console.WriteLine("4. (/) Division.");
    Console.WriteLine("5. History of privious games.\n ");
    Console.WriteLine("Write \"exit\" to close the game. ");


    readResult = Console.ReadLine();
    if (readResult != null)
        menuSelection = readResult.Trim().ToLower();

    if (menuSelection == "1" || menuSelection == "2" || menuSelection == "3" || menuSelection == "4")
    {
        Console.Write("Enter the first number: ");
        firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        secondNumber = int.Parse(Console.ReadLine());

    }

    switch (menuSelection)
    {
        case "1":
            result = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}\n");
            break; 
        case "2":
            result = firstNumber - secondNumber;
            Console.WriteLine($"{firstNumber} - {secondNumber} = {result}\n");
            break; 
        case "3":
            result = firstNumber * secondNumber;
            Console.WriteLine($"{firstNumber} * {secondNumber} = {result} \n");
            break;
        case "4":
            if (firstNumber % secondNumber == 0)
            {
                result = firstNumber / secondNumber;
                Console.WriteLine($"{firstNumber} / {secondNumber} = {result} \n");
            }
            else
                Console.WriteLine("Please Check that the division Should return integer value\n");
            break;        
        case "5":
            Console.WriteLine("This Feature not added yet. Try again later\n");
            break;        
        default:
            Console.WriteLine("You entered a wrong value. Please try again.\n");
            break;
    }

}while (menuSelection != "exit");