//  Write a program to take a name input, reverse it, and display it on the console

Console.WriteLine("Please enter your name:");
var input = Console.ReadLine();
var nameArray = input.ToCharArray();

//for (int i = 0; i < nameArray.Length; i++)
//{
//    Console.WriteLine(nameArray[i]);
//}

Array.Reverse(nameArray);
Console.WriteLine("The reversed name is:");
foreach (var n in nameArray)
    Console.WriteLine(n);