using System.Text.RegularExpressions;
Console.WriteLine("Qabul qilayotgan email adressni kiriting: ");
var toEmail = Console.ReadLine();
Console.WriteLine("Jo'natilayotgan email adressni kiriting: ");
var fromEmail = Console.ReadLine();
Console.WriteLine("Ushbu emaildan maqsadni kiriting: ");
var aimSubject = Console.ReadLine();
Console.WriteLine("Email mazmunini kiriting: ");
var aimContent = Console.ReadLine();

Email email = new Email();
email._to = toEmail;
email._from = fromEmail;
email._subject = aimSubject;
email._content = aimContent;
Console.WriteLine(email.To, email.From, email );

public class Email
{
    public string _to;
    public string _from;
    public string _subject;
    public string _content;
    public string To
    {
        get { return _to; }
        set
        {
            if (Regex.IsMatch(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", value))
                _to = value;
            else
            {
                throw new Exception("Invalid email");
            }
        }
    }
    public string From
    {
        get { return _from; }
        set
        {
            if (Regex.IsMatch(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", value))
                _to = value;
            else
            {
                throw new Exception("Invalid email");
            }
        }
    }
    public string Subject
    {
        get { return _subject; }
        set
        {

        }
    }
    public string Content
    {
        get { return _content; }
        set
        {

        }
    }
}