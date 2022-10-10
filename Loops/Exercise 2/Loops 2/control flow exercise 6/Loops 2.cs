// See https://aka.ms/new-console-template for more information
var total = 0;
while (true)
{
    Console.WriteLine("Enter a number or 'ok' to add them all together");
    var input = Console.ReadLine();
    if (input == "ok")
        break;
    total += Int32.Parse(input);
    Console.WriteLine("Current total is: " + total);
}