var a = 10;
var b = 10;

var arr = new int[a, b];

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        if (i < j)
        {
        }
        else if ((i == j || i < j) && (i / 2 < j))
        {
            arr[i, j] = i + j;

            Console.Write($"{arr[i, j].ToString().PadRight(3)}");

        }
    }
    Console.WriteLine();
}