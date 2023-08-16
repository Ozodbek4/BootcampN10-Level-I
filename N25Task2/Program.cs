var makeName = Console.ReadLine().Split(' ');
var countLoop = 0;
foreach (var item in makeName)
{
    var newName = "";
    for (int i = 0; i < item.Length; i++)
        if (i == 0)
            newName += item[0].ToString().ToUpper();
        else
            newName += item[i].ToString();
    Console.Write(newName);
    if (++countLoop < makeName.Length)
        Console.Write(" ");
}

// linq versiyasi
// muamo bo'adi stringlaar bir biriga to'g'ri kelmay 
// Console.WriteLine("ali vali ".Equals("ali vali"));
// " " - probel o'ringa "@" dan foydalansak ikki xil natija beradi shunga ko'ra stringlar bir biridan farq qiladi
// Console.WriteLine("ali@vali@".Equals("ali@vali"));
Console.WriteLine();

Console.ReadLine().Split().Select(s => s[0].ToString()
    .ToUpper() + s.Substring(1).ToLower()).ToList()
    .ForEach(item => Console.Write(item + " "));