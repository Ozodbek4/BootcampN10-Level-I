using System.Text.RegularExpressions;

Validator obj = new Validator();
Console.WriteLine("Ism familiyangizni kiriting: ");
var FullCheck = Console.ReadLine();
Console.WriteLine("Emailni kiriting: ");
var EmailCheck = Console.ReadLine();
Console.WriteLine("Telefon nomeringizni kiritining kiriting: ");
var PhoneCheck = Console.ReadLine();

Console.WriteLine(obj.FullName(FullCheck));
Console.WriteLine(obj.Email(EmailCheck));
Console.WriteLine(obj.PhoneNumber(PhoneCheck));

public class Validator
{
    private Regex _fullName = new Regex("/^[a-zA-Z'-]+$/");
    private Regex _email = new Regex("/^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$/");
    private Regex _phoneNumber = new Regex(@"/^\+?\d{1,3}?[-.\s]?\(?\d{1,4}\)?[-.\s]?\d{1,4}[-.\s]?\d{1,9}$/");

    public string FullName(string name)
    {
        Match FullMatch = _fullName.Match(name);
        if (FullMatch.Success)
            return $"is correct";
        else
            return "is incorrect";
    }
    public string Email(string email)
    {
        Match EmailMatch = _email.Match(email);
        if (EmailMatch.Success)
            return "is correct";
        else
            return "is incorrect";
    }
    public string PhoneNumber(string phoneNumber)
    {
        Match Phone = _phoneNumber.Match(phoneNumber);
        if (Phone.Success)
            return "is correct";
        else
            return "is incorrect";
    }
}