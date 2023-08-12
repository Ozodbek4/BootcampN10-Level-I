using N23Task2;
RegistrationService obj = new RegistrationService("anvarjonovozodbek417@gmail.com", "123456789");
obj.Add("anvarjonovozodbek417@gmail.com", "1234567489");
obj.Add("anvarjonovozodbek418@gmail.com", "1234567829");

Console.WriteLine("Email adresingizni kiriting: ");
var eamil = Console.ReadLine();
Console.WriteLine("Passwordni kiriting: ");
var pass =  Console.ReadLine();

obj.Add(eamil, pass);