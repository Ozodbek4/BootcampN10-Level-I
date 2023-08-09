Console.WriteLine("Login: ");
var login = Console.ReadLine();
Console.WriteLine("Password");
var password = Console.ReadLine();

if (login != "admin" && password != "admin")
    return;

Console.WriteLine("1. Project yaratish\n2.Task yaratish\n3. User yaratish4. Notification yaratish");
var chooseAdminWork = byte.Parse(Console.ReadLine());

if (chooseAdminWork == 1)
{

}
else if (chooseAdminWork == 2)
{

}
else if (chooseAdminWork == 3)
{

}
else if (chooseAdminWork == 4)
{

}
else
    return;