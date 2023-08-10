List<int> builtList = new List<int>();
CustomList<int> customList = new CustomList<int>();

public class CustomList<IList>
{

    public IList Add(IList itemA, IList itemB)
    {
        return (IList)itemA + (IList)itemB;
    }
}