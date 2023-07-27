BankAccount obj = new BankAccount("Ali", "Shuhratov");
BankAccount obj1 = new BankAccount("G'ayrat", "G'aniyev", 20);

obj.Display();
obj1.Display();

public class BankAccount
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Depozit { get; set; }
    public BankAccount(string firstName, string lastName, int depozit = 0) { 
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Depozit = depozit;
    }

    public void Display() {
        Console.WriteLine($"Ism: {FirstName}\nFamiliya: {LastName}\nDepozit: {Depozit}");
    }
}