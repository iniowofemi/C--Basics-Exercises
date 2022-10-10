/*Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
 * If the list is empty or includes less than 5 numbers,
 * display "Invalid List" and ask the user to re-try;
 * otherwise, display the 3 smallest numbers in the list.
 */

using System.Xml.Linq;

while (true)
{
    Console.WriteLine("Please enter a list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
    var input = Console.ReadLine();
    var numberList = input.Split(',');

    var numbers = new List<int>();
    foreach (var number in numberList)
        numbers.Add(Convert.ToInt32(number));

    if (numbers.Count() < 5)
    {
        Console.WriteLine("Invalid list, please try again.");
        continue;
    }
    else
    {
        numbers.Sort();
        //Console.WriteLine(numbers);
        for (int i = 0; i < 3; i++)
            Console.WriteLine(numbers[i]);
        break;
    }
}