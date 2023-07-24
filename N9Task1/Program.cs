using System.Diagnostics;
List<int> list = new List<int>();
Console.WriteLine("Mahsulot narxlarini kiriting: ");
string[] str = Console.ReadLine().Split(' ');
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
int[] CountPrice = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{
    CountPrice[i] = int.Parse(str[i]);
    list.Add(CountPrice[i]);
}
Dictionary<int, int> copy = new Dictionary<int, int>();
for (int i = 0; i < CountPrice.Length; i++)
{
    int a = list.FindAll(x => x == CountPrice[i]).Count();
    copy.TryAdd(CountPrice[i], a);
}
int sum = 0;
foreach (KeyValuePair<int, int> pair in copy)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
    if (pair.Value / 3 >= 1)
    {
        sum += pair.Key * pair.Value - pair.Key * (pair.Value / 3);
    }
    else sum += pair.Key * pair.Value;
}
Console.WriteLine("Sum: {0}", sum);
stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;
Console.WriteLine(ts);