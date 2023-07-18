Console.WriteLine("Email kiriting: ");
var email = Console.ReadLine();
var newemail = string.Empty;
email = email.ToLower();
var checking = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm0123456789@.";
bool truef = true;
for (int i = 0; i < email.Length; i++)
{
    string a = $"{email[i]}";
    if (checking.Contains(a) == false)
    {
        Console.WriteLine($"Shu yerda xatolik: {a}");
        truef = false;
    }
    else newemail += a;
}
string s1 = ".";
string s2 = "@";
if (truef == false)
{
    if (checking.Contains(s1) == false && checking.Contains(s2) == false) Console.WriteLine("Email yaroqsiz");
    else Console.WriteLine($"Emailda taqiqlangan simvollar qatnashish mumkin emas.\nExample: {newemail}");
}
else
{
    Console.WriteLine("Good");
}
