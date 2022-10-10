/* Write a program and ask the user to enter 5 numbers. If a number has been previously entered,
*  display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers,
*  sort them and display the result on the console.
*/

var numbers = new List<int>();

while (numbers.Count < 5)
{
    Console.WriteLine("Enter a number to as to the list");
    var input = Convert.ToInt32(Console.ReadLine());

    if (numbers.Contains(input))
    {
        Console.WriteLine("You've already entered " + input);
        continue;
    }
    
    numbers.Add(input);
}

numbers.Sort();
Console.WriteLine();

for (int i = 0; i < numbers.Count; i++)
    Console.WriteLine(numbers[i]);