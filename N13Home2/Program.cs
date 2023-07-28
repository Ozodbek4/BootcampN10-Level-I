PasswordGenerate pass = new PasswordGenerate(10, true,true);

Console.WriteLine(pass.Generate());


public class PasswordGenerate
{
    public string Password { get; set; }
    public PasswordGenerate(int length, bool hasLetter, bool hasDigit = false)
    {
        Random random = new Random();
        int count = 0;
        string lt = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        string dg = "1234567890";
        while(count < length) { 
            if (hasLetter)
            {
                Password += lt[random.Next(lt.Length)];
            }
            if (hasDigit)
            {
                Password += dg[random.Next(dg.Length)];
            }
        count++;
        }
    }

    public string Generate()
    {
        return Password;
    }
}

//public class SecurePasswordGenerator : PasswordGenerate
//{
//    public SecurePasswordGenerator(int length, bool hasLetter, bool hasDigit)
//    {

//    }
//}

//public class UniquePasswordGenerator
//{

//}