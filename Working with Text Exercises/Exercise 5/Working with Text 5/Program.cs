/*  Write a program and ask the user to enter an English word.
 *  Count the number of vowels (a, e, o, u, i) in the word.
 *  So, if the user enters "inadequate", the program should display 6 on the console.
 */

Console.WriteLine("Please enter one english word");
var word = Console.ReadLine();
var charList = new List<char>();

foreach (char c in word)
{
    charList.Add(c);
}

int numOfVowels = 0;
foreach (var letter in word)
    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
    {
        numOfVowels = numOfVowels + 1;
    }

Console.WriteLine("That word has " + numOfVowels + " vowels");