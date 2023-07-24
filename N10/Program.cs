using System.Linq.Expressions;

Console.WriteLine("Yoshingizni kiriting: ");
var Age = int.Parse(Console.ReadLine());

try
{
    var AgeCon = Age switch
    {
        > 90 => throw new ArgumentOutOfRangeException("Sorry, you're too old"),
        < 18 => throw new ArgumentOutOfRangeException("Sorry, you're too young"),
        _ => "Valid age"
    };
    Console.WriteLine(AgeCon);
}
catch (ArgumentOutOfRangeException ex) { 
    Console.WriteLine(ex.ParamName);
}