// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is the speed limit in km/hr?");
string input1 = Console.ReadLine();
int speedLimit = Int32.Parse(input1);

Console.WriteLine("How fast is the car going?");
string input2 = Console.ReadLine();
int carSpeed = Int32.Parse(input2);

int demeritCalc = ((carSpeed - speedLimit) / 5);

if (demeritCalc > 12)
    Console.WriteLine("License Suspended");
else if (demeritCalc > 0)
    Console.WriteLine("Number of demerit points: " + demeritCalc.ToString() );
else
    Console.WriteLine("Ok");

/*/if (carSpeed > speedLimit)
    Console.WriteLine("kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkm,k")
else
    Console.WriteLine("Ok.");
*/
