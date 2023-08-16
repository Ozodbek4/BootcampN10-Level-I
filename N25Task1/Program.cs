using N25Task1;
using System.Numerics;
using System.Text.Json;

//string savePath = @"F:\najottalim\BootcampN10-Level-I\N25Task1\AllCountries.txt";

//var jsonFile = File.ReadAllText(savePath);
//var result = JsonSerializer.Deserialize<List<Country>>(jsonFile);

//foreach (var item in result)
//{
//    Console.WriteLine(item.Idd);
//}
var str = Console.ReadLine();
if ((str[str.Length - 2] == 's' && str[str.Length - 1] == 's') || (str[str.Length - 2] == 's' && str[str.Length - 1] == 'h') || (str[str.Length - 2] == 'c' && str[str.Length - 1] == 'h') || str[str.Length - 1] == 'x' || str[str.Length - 1] == 'o')
{
    Console.WriteLine(str + "es");
}
else if (str == "play" || str == "say")
{
    Console.WriteLine(str + "s");
}
else if (str[str.Length - 1] == 'y')
{
    string newstr = "";
    for (int i = 0; i < str.Length - 1; i++)
    {
        if (i != str.Length - 1)
        {
            newstr += str[i];
        }
        else
        {
            newstr += 'i';
        }
    }
    newstr += "es";
    Console.WriteLine(newstr);
}
else
{
    Console.WriteLine(str + "s");
}