/*Write a program and ask the user to enter a few numbers separated by a hyphen.
 * Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
 * display a message: "Consecutive"; otherwise, display "Not Consecutive".
 */
Console.WriteLine("Please enter a series of numbers separated by a hyphen (e.g. 2-4-6-7");
var input = Console.ReadLine();
var numbers = input.Split('-');

var intList = new List<int>();
foreach (var number in numbers)
{
    intList.Add(Convert.ToInt32(number));
}

var isConsecutive = true;
for (var i = 1; i < intList.Count; i++)
{
    if ((intList[i] - intList[i - 1] != 1) || (intList[i] - intList[i - 1] != -1))
    {
        isConsecutive = false;
        break;
    }
}

var message = isConsecutive ? "Consecutive" : "Not Consecutive";
Console.WriteLine(message);