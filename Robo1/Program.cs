using System.Net.NetworkInformation;

TurnToLatin obj = new TurnToLatin();

Console.WriteLine(obj.Answer(4532));


public class TurnToLatin
{
    private Dictionary<int, string> dict = new Dictionary<int, string>()
    {
        { 1, "bir" },
        { 2, "ikki" },
        { 3, "uch" },
        { 4, "to’rt" },
        { 5, "besh" },
        { 6, "olti" },
        { 7, "yetti" },
        { 8, "sakkiz" },
        { 9, "to’qqiz" },
        { 10, "o’n" },
        { 20, "yigirma" },
        { 30, "o’ttiz" },
        { 40, "qirq" },
        { 50, "ellik" },
        { 60, "oltmish" },
        { 70, "yetmish" },
        { 80, "sakson" },
        { 90, "to’qson" },
        { 100, "yuz" },
        { 1000, "ming" }
    };
    private List<int> list = new List<int>();

    private string Prossess(int number)
    {
        for (int i = 0; ; i ++)
        {
            if (number == 0)
            {
                break;
            }
            list.Add(number % 10 * ((int)Math.Pow(10, i)));
            number = number / 10;
        }
        list = list.OrderDescending().ToList();
        bool check = true;
        foreach (int i in list)
        {
            if (i / 1000 != 0)
            {
                Console.WriteLine(dict[i / 1000]);
            }
            else if(check)
            {
                check = false;
                Console.WriteLine(dict[1000]);
                continue;
            };
            Console.WriteLine("ruaifd");
            //if (i / 100 != 0)
            //{
            //    Console.WriteLine(dict[i / 100]);
            //}
            //else if (i >= 100)
            //{
            //    Console.WriteLine(dict[100]);
            //}
        }

        
        return null;
    }

    public string Answer(int number)
    {
        return Prossess(number);
    }
}

