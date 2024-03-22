using MathGame;

var menu = new Menu();

Console.WriteLine("Welcome to Math game!");

List<string> gamesHistory = new List<string>();
string name = Helpers.GetName();

menu.ShowMenu(name);
