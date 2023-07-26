string[] arr = new string[]
{
    "B",
    "A",
    "Inception",
    "Dark Knight",
    "Top Gun 2",
    "Don't Look Up",
    "Top Gun"

};


for  (int i = 0; i < arr.Length - 1; i++)
{
    for (int j = i; j < arr.Length; j++)
    {
        if (arr[i].CompareTo(arr[j]) == 1)
        {
            string copyArr = arr[i];
            arr[i] = arr[j];
            arr[j] = copyArr;
        }
    }
}
foreach (string str in arr)
{
    Console.WriteLine(str);
}
for (int i = 0; i < arr.Length - 1; i++)
{
    for (int j = i; j < arr.Length; j++)
    {
        if (arr[i].CompareTo(arr[j]) == -1)
        {
            string copyArr = arr[i];
            arr[i] = arr[j];
            arr[j] = copyArr;
        }
    }
}
Console.WriteLine("\n");
foreach (string str in arr)
{
    Console.WriteLine(str);
}