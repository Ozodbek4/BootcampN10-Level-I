using N27Task2.Services;

UserService obj = new UserService("nuriddinyusupov@gmail.com", "jaohirrr");

obj.Add("anvarjonovozodbek416@gmail.com", "A123b456");
obj.Add("nizom.voy@gmail.com", "A123b45665554");
obj.Add("bilmdon.hakim@gmail.com", "A123b45641");
obj.Add("vali.hon@gmail.com", "A127453b456");

foreach (var item in obj.GetUsers())
{
    Console.WriteLine($"{item.Id} - {item.EmailAddress} - {item.Password} - {item.IsAdmin}");
}