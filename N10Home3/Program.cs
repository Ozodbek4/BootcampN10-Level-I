using N10Home3;

User user = new User();
Console.WriteLine("Ismingizni kiriting: ");
user.FirstName = Console.ReadLine();
Console.WriteLine("Familiyangizni kiriting: ");
user.LastName = Console.ReadLine();
Console.WriteLine("Yoshingizni kiriting: ");
user.Age = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Ism: {user.FirstName}\nFamiliya:{user.LastName}\nYosh: {user.Age}");