
public class B
{
    public int id { get; set; }
    public string name { get; set; }
    public int age { get; set; }
}
public class A
{
    public List<B> b  = new List<B>()
    {
        new B() { id = 1, age = 1, name = "a" }
    };
    public void Add()
    {
        b.Add(new B() { id = 1, age = 15, name = ""});;
    }
}