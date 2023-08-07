
Malibu obj1 = new Malibu("Chevrolet", 2015, "White", 5, 240);
Captiva obj2 = new Captiva("Chevrolet", 2015, "White", 7, 220);

Console.WriteLine("Malibu");
obj1.Show();
obj1.Drive();
Console.WriteLine("Captiva");
obj2.Show();
obj2.Drive();

public class Malibu : Car
{
    public Malibu(string name, int year, string color, int pass, int max)
        : base(name, year, color) 
    {
        passenger = pass;
        maxSpeed = max;
    }
    private readonly int passenger;
    protected readonly int maxSpeed;

    public override void Show()
    {
        Console.WriteLine($"{Brand} - {Year} - {Color} - {passenger} - {maxSpeed}");
    }

    public override void Drive()
    {
        Random rnd = new Random();
        int summa = 0;
        while (summa < 100)
        {
            summa += rnd.Next(4, 10);
            Console.Write(summa.ToString() + "  ");
        }
        Console.WriteLine("\n");
    }
}

public class Captiva: Car
{
    public Captiva(string name, int year, string color, int pass, int max)
        : base(name, year, color)
    {
        passenger = pass;
        maxSpeed = max;
    }
    private readonly int passenger;
    protected readonly int maxSpeed;

    public override void Show()
    {
        Console.WriteLine($"{Brand} - {Year} - {Color} - {passenger} - {maxSpeed}");
    }
    public override void Drive()
    {
        Random rnd = new Random();
        int summa = 0;
        while (summa < 100)
        {
            summa += rnd.Next(4,10);
            Console.Write(summa.ToString() + "  ");
        }
        Console.WriteLine("\n");
    }
}

public abstract class Car
{
    public Car(string name, int year, string color)
    {
        Brand = name;
        Year = year;
        Color = color;
    }
    public string Brand { get; init; }
    public int Year { get; init; }
    public string Color { get; set; }

    public virtual void Show() { }

    public abstract void Drive();
}