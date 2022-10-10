/* Write a program and ask the user to continuously enter a number or type "Quit" to exit.
 * The list of numbers may include duplicates. Display the unique numbers that the user has entered.
*/

var numbers = new List<int>();

while (true)
{
    Console.WriteLine("Enter a number or 'Quit' to exit");
    var input = Console.ReadLine();

    if (input.ToLower() == "quit")
    {
        break;
    }

    //var number = Convert.ToInt32(input);
    //numbers.Add(number);
    numbers.Add(Convert.ToInt32(input));
}

numbers.Sort();
Console.WriteLine();

Console.WriteLine("Here are all the unique numbers you entered: ");
Console.WriteLine(numbers[0]);

for (int i = 1; i < numbers.Count; i++)
    if (numbers[i] != numbers[i - 1])
    {
        Console.WriteLine(numbers[i]);
    }