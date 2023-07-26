int[] arr = new int[]
{
    12,15,25,12,56,13,81,55,25,12
};
Array.Sort(arr);
Dictionary<int, int> pairs = new Dictionary<int, int>();
for (int i = 0; i < arr.Length; i++)
{
    pairs.TryAdd(arr[i], 0);    
}
Console.WriteLine(pairs[1]);
//for  (int i = 0; i < pairs.Count; i++)
//{
//    if (pairs.(arr[i]) == arr[i])
//}