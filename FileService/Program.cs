Solution obj = new Solution();
Console.WriteLine(obj.ReorganizeString("gfhkgjl"));

public class Solution
{
    public string ReorganizeString(string s)
    {
        var dict = new Dictionary<string, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i].ToString()))
            {
                dict[s[i].ToString()]++;
            }
            else
            {
                dict.Add(s[i].ToString(), 1);
            }
        }
        if (dict.Values.Max() > dict.Values.Sum() - dict.Values.Max())
        {
            return "";
        }
        var str = "";
        var list = dict.Keys.ToList();
        list = list.OrderBy(x => dict.Values.Max()).ToList();
        for (var i = 0; i < list.Count - 1; i++)
        {
            str += list[i];
            for (var j = i + 1;  j < list.Count; j++)
            {
                var newstr = str;
                if (newstr[newstr.Length - 1] == str[j])
                {
                    break;
                }
                else
                {

                }
            }
        }
        return s;
    }
}