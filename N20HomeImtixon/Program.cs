using ImtixonOy1C_;
using ImtixonOy1C_.Services;

RegistrationService obj = new RegistrationService();


Console.WriteLine("Ismingizni kiriting: ");
var UserFirstName = Console.ReadLine();
Console.WriteLine("Familiyangizni kiriting: ");
var UserLastName = Console.ReadLine();
Console.WriteLine("Email addressingizni kiriting: ");
var UserEmail = Console.ReadLine();
Console.WriteLine("Usernameni kiriting (ixtiyoriy): ");
var UserName = Console.ReadLine();
obj.Register(UserFirstName, UserLastName, UserEmail, UserName);
Console.WriteLine("\n");

Console.WriteLine("Ismingizni kiriting: ");
var UserFirstName1 = Console.ReadLine();
Console.WriteLine("Familiyangizni kiriting: ");
var UserLastName1 = Console.ReadLine();
Console.WriteLine("Email addressingizni kiriting: ");
var UserEmail1 = Console.ReadLine();
Console.WriteLine("Usernameni kiriting (ixtiyoriy): ");
var UserName1 = Console.ReadLine();
obj.Register(UserFirstName1, UserLastName1, UserEmail1, UserName1);
Console.WriteLine("\n");


Console.WriteLine("Foydalanuvchilar: ");
obj.Display();