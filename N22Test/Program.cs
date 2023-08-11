int number = 719;

bool isPrime =
    Enumerable.Range(2, (int)Math.Sqrt(number) - 1)
    .All(divisor => number % divisor != 0);
Console.WriteLine("Number {0} is {1}prime.", number, isPrime ? "" : "not ");