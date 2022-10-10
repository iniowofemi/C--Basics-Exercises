// See https://aka.ms/new-console-template for more information

var names = new List<string>();

while (true)
{
    Console.WriteLine("Please add the name of a friend or press ENTER to quit.");
    var name = Console.ReadLine();
    if (String.IsNullOrEmpty(name))
    {
        break;
    }
    else
        names.Add(name);
}

if (names.Count == 0)
    Console.WriteLine();
else if (names.Count == 1)
    Console.WriteLine(names[0] + " liked your post");
else if (names.Count == 2)
    Console.WriteLine(names[0] + " and " + names[1] + " liked your post");
else
    Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Count - 2) + " others liked your post");

//Console.WriteLine(names);
