//using System.Numerics;

//var arr = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));

//if (arr[0] > arr[1])
//{
//    Console.WriteLine(">");
//}
//else if (arr[0] < arr[1])
//{
//    Console.WriteLine("<");
//}
//else
//{
//    Console.WriteLine("=");
//}

//var square = Array.ConvertAll(Console.ReadLine().Split(), s => BigInteger.Parse(s));

//Console.WriteLine(square[0] * square[1]);

//var sance = Console.ReadLine();
//Console.WriteLine($"{sance}");

//var destence = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));

//var count = 0;
//for (int i = destence[0]; i <= destence[1]; i++)
//{
//    count++;
//}
//Console.WriteLine(count);

//var a = Console.ReadLine();
//var b = Convert.ToInt32(a[a.Length - 1]);
//Console.WriteLine(b % 2);

//var asilbek = int.Parse(Console.ReadLine());
//Console.WriteLine((270 + 22 - 3) * 7 - 2022 - 1 - asilbek);

//var input = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
//var dict = new Dictionary<int, int>();
//foreach (var item in input)
//{
//    dict.TryAdd(item, item);
//}
//Console.WriteLine(dict.Count);

//using System.Numerics;

//var a = BigInteger.Parse(Console.ReadLine());
//var b = a - 4;
//BigInteger count = b;
//for (int i = 0; i < a - 4; i++)
//{
//    count *= b;
//}
//Console.WriteLine(count + 1);







using System.Numerics;
var inp = int.Parse(Console.ReadLine());
for (int j = 0; j < inp; j++)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(), s => BigInteger.Parse(s));

    BigInteger daraja = 0;
    BigInteger result = 1;
    BigInteger fact = 1;

    if (input[0] < input[1])
        daraja = input[0];
    else
        daraja = input[1];
    for (int i = 1; i <= daraja; i++)
        fact *= i;
    for (int i = 0; i < fact; i++)
        result *= input[2];

    Console.WriteLine((result) % 1000000007);
}
