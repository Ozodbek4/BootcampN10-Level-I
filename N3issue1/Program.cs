using System.Linq;

Console.WriteLine("Passwordda sonlar qatnashsinmi? Ha bo'lsa 0dan farqli istalgan belgini, aks holda 0 ni bosing.");
var passNumber = Console.ReadLine();
Console.WriteLine("Passwordda harflar qatnashsinmi? Ha bo'lsa 0dan farqli istalgan belgini, aks holda esa 0 ni bosing.");
var passString = Console.ReadLine();
Console.WriteLine("Passwordda boshqa simvollar qatnashsinmi? Ha bo'lsa 0dan farqli istalgan belgini, aks holda esa 0 ni bosing.");
var otherSim = Console.ReadLine();
Console.WriteLine("Password uzunligini kiriting: ");
var passLength = Convert.ToInt32(Console.ReadLine());

var isPassNumber = false;
var isPassString = false;
var isOtherSim = false;

if (passNumber != "0")
    isPassNumber = true;
if (passString != "0")
    isPassString = true;
if (otherSim != "0")
    isOtherSim = true;

var random = new Random();
var createPass = string.Empty;
const string Letters = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
const string Digits = "0123456789";
const string SpecialCharacters = "!@#$%^&*()-_=+<,>.";

while (true)
{
    if (passLength == 0)
        break;
    if (isPassNumber)
        createPass = createPass + Digits[random.Next(Digits.Length)];
    if (createPass.Length == passLength)
        break;
    if (isPassString)
        createPass += Letters[random.Next(Letters.Length)];
    if (createPass.Length == passLength)
        break;
    if (isOtherSim)
        createPass += SpecialCharacters[random.Next(SpecialCharacters.Length)];
    if (createPass.Length == passLength)
        break;
}
Console.WriteLine(createPass);