using N23Home2;

var users = new List<User>
{
    new User("John", "Doe", "johndoe@example.com"),
    new User("Jane", "Doe", "janedoe@example.com"),
    new User("Bob", "Smith", "bobsmith@example.com"),
    new User("Alice", "Johnson", "alicejohnson@example.com"),
    new User("Mike", "Brown", "mikebrown@example.com"),
    new User("Emily", "Davis", "emilydavis@example.com"),
    new User("David", "Wilson", "davidwilson@example.com"),
    new User("Sarah", "Taylor", "sarahtaylor@example.com"),
    new User("Tom", "Anderson", "tomanderson@example.com"),
    new User("Lisa", "Thomas", "lisathomas@example.com")
};


Console.WriteLine("Kerakli user uchun kalit so'zni kiriting: ");
var needed = Console.ReadLine();

//var re = users.Select(user =>
//{
//    if (user.FistName.Contains(needed, StringComparison.OrdinalIgnoreCase) || user.LastName.Contains(needed, StringComparison.OrdinalIgnoreCase) || user.EmailAddress.Contains(needed, StringComparison.OrdinalIgnoreCase){
//        return user;
//    }
//});

var result = users.Where(user => user.FistName.Contains(needed, StringComparison.OrdinalIgnoreCase) || user.LastName.Contains(needed, StringComparison.OrdinalIgnoreCase) || user.EmailAddress.Contains(needed, StringComparison.OrdinalIgnoreCase));

result.ToList().ForEach(user => Console.WriteLine($"{user.FistName.PadRight(15)}{user.LastName.PadRight(15)}{user.EmailAddress}"));