using System.Collections;
using System.Net.Http.Headers;

WeatherReport obj = new WeatherReport();
Console.WriteLine("Keraki kunni kiriting: (Yil, oy, kun)");
var needDay = DateOnly.Parse(Console.ReadLine());
Console.WriteLine(obj.Get(needDay));
Console.WriteLine("\n");
obj.Display();

Console.WriteLine("\nQo'shiladigan kunni kiriting: ");
var addingDay1 = DateOnly.Parse(Console.ReadLine());
Console.WriteLine("Qo'shiladigan kun ob-havosini kiriting: ");
var addingDayStr1 = (Console.ReadLine());
Console.WriteLine("Qo'shiladigan kunni kiriting: ");
var addingDay2 = DateOnly.Parse(Console.ReadLine());
Console.WriteLine("Qo'shiladigan kun ob-havosini kiriting: ");
var addingDayStr2 = Console.ReadLine();

obj.Add(addingDay1, addingDayStr1);
obj.Add(addingDay2, addingDayStr2);
Console.WriteLine("\n");
obj.Display();

ValidatedWeahterReport obj2 = new ValidatedWeahterReport();
obj2.Add(new DateOnly(2023, 08, 07), "Bugun ob-havo quyoshli");
obj2.Add(new DateOnly(2023, 08, 08), "Bugun ob-havo bulutli");
obj2.Add(new DateOnly(2023, 08, 09), "Bugun ob-havo quyoshli");
obj2.Add(new DateOnly(2023, 08, 10), "Bugun ob-havo quyoshli");
obj2.Add(new DateOnly(2023, 08, 11), "Bugun ob-havo bulutli");
obj2.Add(new DateOnly(2023, 08, 12), "Bugun ob-havo bulutli");
Console.WriteLine("\nIKKINCHI CLASS UCHUN");
obj2.Display();
Console.WriteLine("\n");


UltimateWeatherReport obj3 = new UltimateWeatherReport();
obj3.Add(new DateOnly(2023, 07, 13), "Bugun ob-havo quyoshli");
obj3.Add(new DateOnly(2023, 07, 14), "Bugun ob-havo bulutli");
obj3.Add(new DateOnly(2023, 07, 15), "Bugun ob-havo quyoshli");
obj3.Add(new DateOnly(2023, 08, 16), "Bugun ob-havo bulutli");
obj3.Add(new DateOnly(2023, 08, 17), "Bugun ob-havo quyoshli");
obj3.Add(new DateOnly(2023, 08, 18), "Bugun ob-havo quyoshli");
obj3.Add(new DateOnly(2023, 08, 19), "Bugun ob-havo quyoshli");
obj3.Add(new DateOnly(2023, 08, 20), "Bugun ob-havo bulutli");
obj3.Add(new DateOnly(2023, 08, 21), "Bugun ob-havo bulutli");
Console.WriteLine("Kerakli oraliq kiriting: ");
int dicstanse = int.Parse(Console.ReadLine());
Console.WriteLine("Kerali vaqtni kiriting: ixtiyoriy");
var needTime = Console.ReadLine();
if (needTime != "")
{
    DateOnly a = DateOnly.FromDateTime(Convert.ToDateTime(needTime));
    foreach (var item in obj3.Get(a, dicstanse))
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }
}
else
{
    foreach (var item in obj3.Get(dicstanse))
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }
}

public class WeatherReport
{

    protected Dictionary<DateOnly, string> _collection = new Dictionary<DateOnly, string>()
    {
        { new DateOnly(2023, 08, 01), "Osmon bulutli, yomg'ir yog'ishi kutilmoqda"},
        { new DateOnly(2023, 08, 02), "Quyoshli kun 40 gradus issiq"},
        { new DateOnly(2023, 08, 03), "Osmon bulutli, yomg'ir yog'ishi kutilmaydi"},
        { new DateOnly(2023, 08, 04), "Quyoshli kun 50 gradus issiq"},
        { new DateOnly(2023, 08, 05), "Osmon bulutli, havo dim"},
        { new DateOnly(2023, 08, 06), "Osmon bulutsiz kun 40 - 50 gradus issiq bo'lishi kutilmoqda"}
    };
    private string Find(DateOnly finding)
    {
        foreach (var item in _collection)
        {
            if (item.Key == finding)
                return item.Value;
        }
        return null;
    }

    public string Get(DateOnly date)
    {
        string reFind = Find(date);
        if (reFind == null)
            return $"{date.ToString()} kunga ob-havo topilmadi, boshqa kunlar uchun qidiirb ko'ring";
        return reFind;
    }

    public virtual void Add(DateOnly addingWeatherTime, string addingWeatherStr)
    {
        _collection.TryAdd(addingWeatherTime, addingWeatherStr);
    }
    public void Display()
    {
        foreach(var item in _collection)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}

public class ValidatedWeahterReport : WeatherReport
{
    public override void Add(DateOnly addingWeatherTime, string addingWeatherStr)
    {
        if (_collection.ContainsKey(addingWeatherTime))
            _collection[addingWeatherTime] = addingWeatherStr;
        else
            _collection.Add(addingWeatherTime, addingWeatherStr);
    }
}

public class UltimateWeatherReport : ValidatedWeahterReport
{
    public Dictionary<DateOnly, string> Get(DateOnly theDay, int howLongDay)
    {
        int dayLength = 0;
        Dictionary<DateOnly, string> result = new Dictionary<DateOnly, string>();
        foreach(var item in Sort())
        {
            if (theDay >= item.Key)
            {
                result.Add(item.Key, item.Value);
                dayLength++;
            }
            if (dayLength >= howLongDay)
                return result;
        }
        return null;
    }

    public Dictionary<DateOnly, string> Get(int howLongDay)
    {
        int dayLength = 0;
        Dictionary<DateOnly, string> result = new Dictionary<DateOnly, string>();
        foreach (var item in Sort())
        {
            if (DateOnly.FromDateTime(DateTime.Now) <= item.Key)
            {
                result.Add(item.Key, item.Value);
                dayLength++;
            }
            if (dayLength >= howLongDay)
                return result;
        }
        return null;
    }

    private SortedDictionary<DateOnly, string> Sort()
    {
        SortedDictionary<DateOnly, string> sortedDict = new SortedDictionary<DateOnly, string>(_collection);
        return sortedDict;
    }
}