using System.Collections.Generic;

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
        _dictionary.Add("Blocked", "Your account has been blocked");
    }

    protected KeyValuePair<string, string>? FindMassage(string lookFor)
    {
        foreach (var keyValue in _dictionary)
            if (keyValue.Key.Contains(lookFor))
                return keyValue;

        return null;
    }

    public string SearchMassage(string lookFor)
    {
        var result = FindMassage(lookFor);
        return result != null ? result.Value.Value : null;
    }
}