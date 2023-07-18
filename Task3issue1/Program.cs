Console.WriteLine("Matn kiriting: ");
var consoleText = Console.ReadLine();
string[] countWords = consoleText.Split(' ');
int pointText = 100;
if (countWords.Length < 500)
{
    pointText -= 5;
    Console.WriteLine("So'zlar soni 500 dan kamilgi uchun: -5");
}
string[] countGaps = consoleText.Split('.', '?', '!');
foreach (string s in countWords)
{
    if (s.Length > 20)
    {
        Console.WriteLine("So'z uzunligi 20 dan oshib ketgan: -20");
        pointText -= 20;
        break;
    }
}

Console.WriteLine($"To'plagan balingiz: {pointText}");