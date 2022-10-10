/* Write a program and ask the user to enter a few numbers separated by a hyphen.
 * If the user simply presses Enter, without supplying an input, exit immediately;
 * otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
 */
Console.WriteLine("Please enter a series of numbers separated by a hyphen (e.g. 2-4-6-7");
var input = Console.ReadLine();

if (!String.IsNullOrEmpty(input))
{
    var numbers = input.Split('-');
    Array.Sort(numbers);

   
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] == numbers[i - 1])
        {
            Console.WriteLine("Duplicate exists");
            break;
        }
        else
        {
            continue;
        }
    }
}
else
{
    Console.WriteLine("Have a good day");
}