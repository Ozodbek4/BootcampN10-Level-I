using System.Collections.ObjectModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

Collections obj = new Collections();

List<int> ls = new List<int>()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31
};

obj.Display(ls);
public class Collections
{
    private List<int> ls = new List<int>();

    private void Prime(List<int> list)
    {
        foreach (var number in list)
        {
            bool isPrime =
                Enumerable.Range(2, (int)Math.Sqrt(number) - 1)
                    .All(divisor => number % divisor != 0);
            if (isPrime && number != 1)
            {
                ls.Add(number);
            }

        }
    }

    public void Display(List<int> list)
    {
        Prime(list);

        foreach(int number in ls)
        {
            Console.Write(number + "  ");
        }
    }
}