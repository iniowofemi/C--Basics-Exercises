// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number to calculate its factorial");
int number = int.Parse(Console.ReadLine());
int i,factorial=1;
for (i = 1; i <= number; i++)
    factorial = factorial * i;
Console.WriteLine("The factorial of " + number + " is " + factorial);