// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number between 1 and 10 exclusive:");
string input = Console.ReadLine();
int number = Int32.Parse(input);
if (number > 0 && number < 11)
    Console.WriteLine("Valid");
else
    Console.WriteLine("Invalid");