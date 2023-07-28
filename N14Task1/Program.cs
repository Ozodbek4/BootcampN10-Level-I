Animal wolf = new Wolf();
Animal ayiq = new Ayiq();
Animal ot = new Ot();

wolf.FunFact();
ayiq.FunFact();
ot.FunFact();


public class Animal
{
    public virtual void FunFact()
    {
        Console.WriteLine("Ikki karra ikki teng to'rt");
        Console.WriteLine("Toshkent - O'zbekiston poytaxi");
        Console.WriteLine("Tarakan boshsiz 9 kun yashay oladi, keyin esa ochlikdan vafor etadi");
    }
}

public class Wolf : Animal
{
    public override void FunFact()
    {
        Console.WriteLine("Ikki karra ikki teng to'rt");
    }
}

public class Ayiq : Animal
{
    public override void FunFact()
    {
        Console.WriteLine("Toshkent - O'zbekiston poytaxi");
    }
}

public class Ot : Animal
{
    public override void FunFact()
    {
        Console.WriteLine("Tarakan boshsiz 9 kun yashay oladi, keyin esa ochlikdan vafor etadi");
    }
}