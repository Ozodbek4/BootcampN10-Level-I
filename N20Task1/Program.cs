Console.WriteLine("Sonlar massivni kiriting: ");
var arr = Array.ConvertAll(Console.ReadLine().Split(),s=>int.Parse(s));
Console.WriteLine("Saralashdan keyingi holat: ");
BubleSort(arr);
foreach(var item in arr)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");

FindMinMax(arr);

Console.WriteLine("a ni kiriting: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("b ni kiriting: ");
int b = int.Parse(Console.ReadLine());
int P;
int S;
GetArea(a,b, out P, out S);
Console.WriteLine($"Perimetr: {P}\nYuza: {S}");

string name;
byte age;
string isMarriedstring;
bool isMarried;
Console.WriteLine("Ismingizni kiriting: ");
name = Console.ReadLine();
Console.WriteLine("Yoshingizni kiriting: ");
age = byte.Parse(Console.ReadLine());
Console.WriteLine("Oilalimisiz: Y/N");

isMarriedstring = Console.ReadLine();

if (isMarriedstring == "Y" || isMarriedstring == "y")
{
    isMarried = true;
}
else
    isMarried = false;
DisplayInfo(name, age, isMarried);

static void BubleSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j =i + 1;  j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                var a = arr[i];
                arr[i] = arr[j];
                arr[j] = a;
            }
        }
    }
}

static void GetArea(int a, int b, out int P, out int S)
{
    P = 2 * (a + b);
    S = a* b;
}

static void FindMinMax(int[] arr)
{
    BubleSort(arr);
    Console.WriteLine($"Eng kichik qiymat: {arr[0]}\nEng katta qiymat: {arr[1]}\n");
}

static void DisplayInfo(string name, byte age, bool isMarried)
{
    Console.WriteLine($"Ism: {name}\nYosh: {age}\nOilali: {(isMarried? "Ha":"Yo'q")}");
}