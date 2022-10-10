// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number");
string input1 = Console.ReadLine();
int number1 = Int32.Parse(input1);

Console.WriteLine("Enter a second number");
string input2 = Console.ReadLine();
int number2 = Int32.Parse(input2);

if (number1 > number2)
    Console.WriteLine(number1);
else if (number1 < number2)
    Console.WriteLine(number2);
else
    Console.WriteLine("They are the same");