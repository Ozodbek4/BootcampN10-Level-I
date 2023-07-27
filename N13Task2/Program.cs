EventManager obj = new EventManager();

obj.Add("Yangi yil", new DateOnly(2023, 01, 01));
obj.Add("Tug'ilgan kun", new DateOnly(2023, 09, 21));
obj.Add("Qurbon Hayiti", new DateOnly(2023, 07, 28));
obj.Add("Uchrashuv", new DateOnly(2023, 12, 23));
obj.Add("Gap", new DateOnly(2023, 06, 04));

obj.Add("Dam", new TimeOnly(06, 00));
obj.Add("Yuqurish", new TimeOnly(07, 00));
obj.Add("Ovqatlanish", new TimeOnly(08, 00));
obj.Add("Ish", new TimeOnly(10, 00));
obj.Add("O'yin", new TimeOnly(20, 00));
obj.Add("Uyqu", new TimeOnly(22, 00));


obj.Display();

public class EventManager
{
    Dictionary<string, DateOnly> events = new Dictionary<string, DateOnly>();
    Dictionary<string, TimeOnly> dayEvent = new Dictionary<string, TimeOnly>();

    public void Add(string name, DateOnly date)
    {
        events.Add(name, date);
    }

    public void Add(string name, TimeOnly time)
    { 
        dayEvent.Add(name, time);
    }

    public void Display() 
    {
        var nowTime = DateTime.Now;
        var now = new DateOnly(nowTime.Year, nowTime.Month, nowTime.Day);

        foreach (var entry in dayEvent)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        //var sortedDict = from entry in events orderby entry.Value ascending select entry;
        foreach (var entry in events)
        {
            if (entry.Value == now.AddDays(1) || entry.Value == now.AddDays(2) || entry.Value == now.AddDays(3))
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}