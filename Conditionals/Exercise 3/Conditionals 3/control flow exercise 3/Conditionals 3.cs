// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the width of the image in metres");
string input1 = Console.ReadLine();
int width = Int32.Parse(input1);

Console.WriteLine("Enter the height of the image in metres");
string input2 = Console.ReadLine();
int height = Int32.Parse(input2);

if (width > height)
    Console.WriteLine("This image is landscape");
else if (width < height)
    Console.WriteLine("This image is portrait");
else
    Console.WriteLine("This image is a square");