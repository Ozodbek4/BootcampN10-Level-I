Hero obj = new Hero("Tor");
new Hero("Alex");
new Hero("John");

Console.WriteLine(obj.ToString());

OptimizedGameEngine obj1 = new OptimizedGameEngine();
obj1.Display();


public class Hero
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public Hero(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }

    public override string ToString()
    {
        return $"{Id}: {Name}";
    }
}

public class GameEngine
{
    public List<Hero> list = new List<Hero>();
    public GameEngine()
    {
        list.Add(new Hero("Yurnero"));
        list.Add(new Hero("Sven"));
        list.Add(new Hero("Tiny"));
    }

    public void Display()
    {
        foreach (var hero in list)
        {
            Console.WriteLine(hero.Name);
        }
    }
}

public class OptimizedGameEngine : GameEngine
{
    public OptimizedGameEngine()
    {
        list.Add(new Hero("Invoker"));
        list.Add(new Hero("Lina"));
        list.Add(new Hero("Medusa"));
    }
}
