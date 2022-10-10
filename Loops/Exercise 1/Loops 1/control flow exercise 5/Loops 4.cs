// See https://aka.ms/new-console-template for more information
var random = new Random();
int numberToGuess = random.Next(1, 10);
Console.WriteLine(numberToGuess); //check what the number generated is to test code easily
for (var i = 0; i < 4; i++)
{
    Console.WriteLine("Guess a a number between 1-10 inclusive");
    int guess = Int32.Parse(Console.ReadLine());
    if (guess == numberToGuess)
    {
        Console.WriteLine("You won!");
        break;
    }
    else if (i == 3)
        Console.WriteLine("You lost!");
    else
        Console.WriteLine("Try again!");
}