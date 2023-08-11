List<int> builtList = new List<int>();
CustomList<int> customList = new CustomList<int>();

public class CustomList<TList>
{

    public TList Add(TList itemA, TList itemB)
    {
        return itemA + itemB;
    }
}