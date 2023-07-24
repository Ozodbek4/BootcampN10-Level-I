using System.Text.RegularExpressions;

//Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
Console.WriteLine("Emailingizni kiriting: ");
var email = Console.ReadLine();
Match EmailMatch = regex.Match(email);
if (EmailMatch.Success)
    email += " is correct";
else
    email += " is incorrect";
Console.WriteLine(email);