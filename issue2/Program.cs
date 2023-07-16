var number = new double();
Console.Write("Enter a number: ");
number = double.Parse(Console.ReadLine());

while (true)
{
    Console.Write("Enter command: ");
    string command = Console.ReadLine();
    if (command == "e") break;

    if (command == "+")
    {
        Console.Write("Enter a number: ");
        var numberA = double.Parse(Console.ReadLine());
        number += numberA;
    }
    else if (command == "-")
    {
        Console.Write("Enter a number: ");
        var numberA = Convert.ToInt32(Console.ReadLine());
        number -= numberA;
    }
    else if(command == "*")
    {
        Console.Write("Enter a number: ");
        var numberA = Convert.ToInt32(Console.ReadLine());
        number *= numberA;
    }
    else if (command == "/")
    {
        Console.Write("Enter a number: ");
        var numberA = Convert.ToInt32(Console.ReadLine());
        number /= numberA;
    }
}
Console.WriteLine($"Result {number}");