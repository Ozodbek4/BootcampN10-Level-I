Random random = new Random();
try
{
    int RandNumber = random.Next(1, 11);
    Console.WriteLine("Son kiriting: (1, 10)");
    var input = Console.ReadLine();

    if (int.TryParse(input, out var IntInput))
    {
        if (IntInput == RandNumber)
        {
            throw new FormatException("Congrats! You guessed it");
        }
        else throw new FormatException("You couldn't guess it");
    }
    else
    {
        throw new FormatException("Not a number");
    }
}
catch(FormatException ex)
{
    Console.WriteLine(ex.Message);
}