﻿Sparrow sparrow = new Sparrow();
sparrow.MakeSound();
sparrow.Fly();

Tiger tiger = new Tiger();
tiger.MakeSound();
tiger.Run();

GreatWhiteShark great = new GreatWhiteShark();
great.MakeSound();
great.Swim();

public class Animal
{
    public void MakeSound()
    {
        Console.WriteLine("...");
    }
}

public class Bird : Animal {
    public void Fly()
    {
        Console.WriteLine("Fly");
    }
}

public class Mammal : Animal
{
    public void Run()
    {
        Console.WriteLine("Run");
    }
}
        
public class Fish : Animal
{
    public void Swim()
    {
        Console.WriteLine("Swim");
    }
}

public class Sparrow : Bird
{

} 
 public class Tiger : Mammal
{

}

public class GreatWhiteShark : Fish
{

}
