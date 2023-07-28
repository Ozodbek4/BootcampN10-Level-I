NotificationMassages obj = new NotificationMassages();
Console.WriteLine("Massage nomini kiriting: ");
string nameMassage = Console.ReadLine();
Console.WriteLine(obj.SearchMassage(nameMassage));

public class NotificationMassages
{
    private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

    public NotificationMassages()
    {
        _dictionary.Add("Ali", "C#");
        _dictionary.Add("Diyor", "word");
        _dictionary.Add("Farhod", "Alarm");
        _dictionary.Add("SuccRegistration", "You successfully registered");
        _dictionary.Add("AskPassword", "Enter your password");
        _dictionary.Add("Blocked","Your account has been blocked");
    }

    protected Dictionary<string, string> FindMassage(string lookFor)
    {
        Dictionary<string, string> returning = new Dictionary<string, string>();
        foreach (var keyValue in _dictionary)
        {
            if (keyValue.Key ==  lookFor)
            {
                returning.Add(keyValue.Key, keyValue.Value);
                return returning;
            }
        }
        return returning;
        
    }

    public string SearchMassage(string lookFor)
    {
        foreach (var keyValue in FindMassage(lookFor))
        {
            return $"{keyValue.Key} - {keyValue.Value}";
        }
        return "Bunday massage mavjud emas";
    }
}