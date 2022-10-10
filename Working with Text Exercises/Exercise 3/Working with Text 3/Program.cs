/*  Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
 *  A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok";
 *  otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
 */
Console.WriteLine("Write a time value in 24 hour format");
var input = Console.ReadLine().Split(':');

var time = new List<int>();

for (int i = 0; i < input.Length; i++)
{
    time.Add(Convert.ToInt32(input[i]));
}

if (time[0] > 23 || time[1] > 59)
{
    Console.WriteLine("Invalid Time");
}
else
{
    Console.WriteLine("Ok");
}