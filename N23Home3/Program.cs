List<int> numbers = new List<int>()
{
    322,
    -1,
    11,
    3,
    6,
    10
};

Console.WriteLine($"Hammasi musbatmi: {numbers.All(number => number > 0)}");
Console.WriteLine($"Ichida toq sonlar bormi: {numbers.Any(number => number != 0)}");
Console.WriteLine($"ichida 3 && 9 sonlari bormi: {numbers.Contains(3) && numbers.Contains(9)}");