/*  Write a program and ask the user to enter a few words separated by a space.
 *  Use the words to create a variable name with PascalCase. For example,
 *  if the user types: "number of students", display "NumberOfStudents".Make sure that the program is not dependent on the input.
 *  So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
 */

Console.WriteLine("Please enter some words with spaces inbetween them. No integer");
var words = Console.ReadLine().Split(' ');

var pascalCasePhrase = "";
foreach (var poop in words)
{
    var pascalCaseWord = char.ToUpper(poop[0]) + poop.ToLower().Substring(1);
    pascalCasePhrase += pascalCaseWord;
}

Console.WriteLine(pascalCasePhrase);