Console.WriteLine("Ism sharifingizni kiriting: ");
var name = Console.ReadLine();
Random random = new Random();
string[] nameArr = name.ToLower().Split();
var email = string.Empty;
for (int i = 0; i < nameArr.Length; i++)
{
    email += nameArr[i];
}
string[] addEmail = new string[] { "teshaboy", "boltaboy", "ketmonvoy", "boy" };
string[] oldEmail = new string[] { "teshaboyeshmatov", "najimatullahotamov", "holibekumarov","muqimbekteshaboy",
                                    "muqimbekboltaboy", "muqimbekketmonvoy", "muqimbekboy"};

email += addEmail[random.Next(oldEmail.Length - 1)];

for (int i = 0; i < oldEmail.Length; i++)
{
    if (email == oldEmail[i])
        email += random.Next(0, 9);
}

Console.WriteLine($"New email: {email}");