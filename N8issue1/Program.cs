/*
 list:

 */
List<string> Relax = new List<string>() { "John", "Bob", "Ga'yrat", "Teshmat"};
Dictionary<DateTime, int> AirPlane = new Dictionary<DateTime, int>();
AirPlane.Add(new DateTime(2023, 08, 02, 15, 15, 00), 20);
AirPlane.Add(new DateTime(2023, 07, 29, 20, 25, 00), 15);
AirPlane.Add(new DateTime(2023, 07, 25, 14, 30, 00), 10);
AirPlane.Add(new DateTime(2023, 07, 21, 08, 00, 00), 5);
AirPlane.Add(new DateTime(2023, 07, 30, 16, 50, 00), 12);
string[] arr = new string[] { " The Travel Guru" };

string UnderAge = "Uzr, hurmatli {0} siz loyidan foydalanish uchun kichkinasiz";
string GoldenAger = "Uzr, hurmatli {0} loyiha yoshlar uchun mo'ljallangan";
string CompanyName = "The Travel Guru";
string HelloEmail = "Hello {0}. Welcome to onboard. {1} Team.";
string InformEmail = "Your data is being processed and we will inform updates for you as soon as possible. {0} Team.";
string CongEmail = "Congratulations! Your flight ticket is booked for {0}. {1} Team.";
string UserName;

while (true)
{
    bool CheckName = true;
    Console.WriteLine("Ismingizni kiriting: ");
    UserName = Console.ReadLine();
    var ForChecking = "0987654321";
    for (int i = 0; i < UserName.Length; i++)
    {
        if (ForChecking.Contains(UserName[i]))
        {
            CheckName = false;
        }
    }
    if (CheckName) break;
    else Console.WriteLine("Invalid name");
}
Console.Clear();
Console.WriteLine("Yoshingizni kiriting: ");
var UserAge = Convert.ToInt32(Console.ReadLine());
if (UserAge < 18)
{
    Console.WriteLine(string.Format(UnderAge, UserName));
    return;
}
else if (UserAge > 90)
{
    Console.WriteLine(string.Format(GoldenAger, UserName));
    return;
}
Console.Clear();
Console.WriteLine(string.Format(HelloEmail, UserName, arr[0]));
bool FitTime = false;
int DictUserI;
int DictUserJ = 0;
string TickDate = "";
Console.WriteLine( "Nechta bilet kerak");
Console.WriteLine(string.Format(InformEmail, arr[0]));
var UserNumber = Convert.ToInt32(Console.ReadLine());
foreach(KeyValuePair<DateTime, int> item in AirPlane)
{
    if (item.Value >= UserNumber)
    {
        DictUserJ++;
        Console.WriteLine("Vaqt: {0}", item.Key);
        Console.WriteLine("Shu vaqt to'gri keladimi? Y/N");
        var a = Console.ReadLine();
        if (a == "Y")
        {
           // item.Value = item.Value - UserNumber;
            FitTime = true;
            DictUserI = DictUserJ;
            TickDate = item.Key.ToString();
            Console.WriteLine(string.Format(HelloEmail, UserName, arr[0]));
            break;
        };
    }
}
if (FitTime)
{
    Console.WriteLine($"Congratulations! Your flight ticket is booked for {TickDate}. {arr[0]} Team");
}