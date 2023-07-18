//using N6issue2;
//List<Events> events = new List<Events>()
//{
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//    new Events(){EventName = "", EventTime = DateTime(2000, 01, 01)},
//};

using System;
using System.Runtime.InteropServices;

string[] EventName = new string[]
{
    "Yangi yil", "Arafa", "Navro'z", "Hayit", "Tug'ilgan kun", "Mustaqillik"
};
DateTime[] EventTime = new DateTime[]
{
    new DateTime(2023,01,01),
    new DateTime(2023,06,27),
    new DateTime(2023, 03, 21),
    new DateTime(2023,06,28),
    new DateTime(2023, 12, 26),
    new DateTime(2023,09,01)
};

Console.WriteLine("1. Eventni saralash\n2. Eventni nomi bo'yicha topish\n3. Eventni vaqti bo'yicha topish\n" +
    "4. Kelayotgan eventlarni ko'rsatish ( yaqinligi bo'yicha )\n5. O'tib ketgan eventlarni ko'rsatish" +
    " ( yaqinligi bo'yicha )\n6. Dasturni yopish\n");
string tableNumber = Console.ReadLine();
switch (tableNumber)
{
    case "1":
        Console.Clear();
        Console.WriteLine("1. Nomi bo'yicha\n2. Vaqti bo'yicha\n");
        string tableNumberItemA = Console.ReadLine();
        switch (tableNumberItemA)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("1. O'sish\n2. Kamayish\n");
                string tableNumberItemB=Console.ReadLine();
                switch (tableNumberItemB)
                {
                    case "1":
                        Console.Clear();
                        string[] sortA = new string[6];
                        EventName.CopyTo(sortA, 0);
                        Array.Sort(sortA);
                        foreach(string item in sortA) Console.WriteLine(item);
                        break;
                    case "2":
                        Console.Clear();
                        string[] sortB = new string[6];
                        EventName.CopyTo(sortB, 0);
                        Array.Sort(sortB);
                        for (int i = sortB.Length - 1; i > -1; i--)
                        {
                            Console.WriteLine($"{sortB[i]}");
                        }
                        break;
                    default:
                        Console.WriteLine("Bunday kommanda mavjud emas");
                        break;
                }
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("1. O'sish\n2. Kamayish\n");
                string tableNumberItemC = Console.ReadLine();
                switch (tableNumberItemC)
                {
                    case "1":
                        Console.Clear();
                        DateTime[] sortC = new DateTime[6];
                        EventTime.CopyTo(sortC, 0);
                        Array.Sort(sortC);
                        foreach(DateTime item in sortC) Console.WriteLine(item.ToString("d"));
                        break;
                    case "2":
                        Console.Clear();
                        DateTime[] sortD = new DateTime[6];
                        EventTime.CopyTo(sortD, 0);
                        Array.Sort(sortD);
                        for (int i = sortD.Length - 1; i > -1; i--) Console.WriteLine(sortD[i].ToString("d"));
                        break;
                    default:
                        Console.WriteLine("Bunday kommanda mavjud emas");
                        break;
                }
                break;
            default:
                Console.WriteLine("Bunday kommanda mavjud emas");
                break;
        }
        break;
    case "2":
        Console.Clear();
        Console.WriteLine("Kerakli eventni kiriting: ");
        string searchEvent = Console.ReadLine();
        foreach (string item in EventName)
        {
            if (item.Contains(searchEvent, StringComparison.OrdinalIgnoreCase)) Console.WriteLine(item);
        }
        break;
    case "3":
        Console.Clear();
        Console.WriteLine("Kerakli vaqtni kiriting: ");
        DateTime searchEventTime = DateTime.Parse(Console.ReadLine());
        for (int i = 0; i < EventTime.Length; i++)
        {
            if (EventTime[i] == searchEventTime) Console.WriteLine($"{EventName[i]}: {EventTime[i].ToString("d")}");
        }
        break;
    case "4":
        Console.Clear();
        Console.WriteLine("Kelayotgan eventlar: ");
        DateTime[] NearEventTime = new DateTime[6];
        string[] NearEventName = new string[6];
        EventTime.CopyTo(NearEventTime, 0);
        EventName.CopyTo(NearEventName, 0);
        for (int i = 0; i < NearEventTime.Length - 1; i++)
        {
            for (int j = i + 1; j < NearEventTime.Length; j++)
            {
                if (NearEventTime[i] > NearEventTime[j])
                {
                    string NewNearEventName;
                    DateTime NewNearEventTime;
                    NewNearEventTime = NearEventTime[i];
                    NearEventTime[i] = NearEventTime[j];
                    NearEventTime[j] = NewNearEventTime;
                    NewNearEventName = NearEventName[i];
                    NearEventName[i] = NearEventName[j];
                    NearEventName[j] = NewNearEventName;
                }
            }
        }
        for (int i = 0; i < NearEventTime.Length; i++)
        {
            if (NearEventTime[i] > DateTime.Now)
            {
                Console.WriteLine($"{NearEventName[i]}: {NearEventTime[i]}");
            }
        }

        break;
    case "5":
        Console.Clear();
        Console.WriteLine("Kelayotgan eventlar: ");
        DateTime[] NearEventTimeB = new DateTime[6];
        string[] NearEventNameB = new string[6];
        EventTime.CopyTo(NearEventTimeB, 0);
        EventName.CopyTo(NearEventNameB, 0);
        for (int i = 0; i < NearEventTimeB.Length - 1; i++)
        {
            for (int j = i + 1; j < NearEventTimeB.Length; j++)
            {
                if (NearEventTimeB[i] < NearEventTimeB[j])
                {
                    string NewNearEventNameB;
                    DateTime NewNearEventTimeB;
                    NewNearEventTimeB = NearEventTimeB[i];
                    NearEventTimeB[i] = NearEventTimeB[j];
                    NearEventTimeB[j] = NewNearEventTimeB;
                    NewNearEventNameB = NearEventNameB[i];
                    NearEventNameB[i] = NearEventNameB[j];
                    NearEventNameB[j] = NewNearEventNameB;
                }
            }
        }
        for (int i = 0; i < NearEventTimeB.Length; i++)
        {
            if (NearEventTimeB[i] < DateTime.Now)
            {
                Console.WriteLine($"{NearEventNameB[i]}: {NearEventTimeB[i]}");
            }
        }
        break;

    case "6":
        break;
    default:
        Console.WriteLine("Bunday kommanda mavjud emas");
        break;
}