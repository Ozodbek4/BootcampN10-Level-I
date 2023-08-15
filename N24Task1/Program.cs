using N24Task1;
using System.IO;
using System.Net.Http.Json;
using System.Text.Json;

var result = new List<Person>()
{
    new Person {Id = 1, Name = "Begzod", Age = 18},
    new Person {Id = 1, Name = "Begzod", Age = 18},

};

string path = @"F:\najottalim\BootcampN10-Level-I\N24Task1\Person.txt";
result.AddRange(Reader());
string jsonPerson = JsonSerializer.Serialize(result);
// StreamReader
// StreamWriter

using (StreamWriter writer = new StreamWriter(path, true))
{
    writer.Write(jsonPerson);
    foreach (Person person in result)
    {
        Console.WriteLine(person.Name);
    }
}

static List<Person> Reader()
{
    var file = new StreamReader(@"F:\najottalim\BootcampN10-Level-I\N24Task1\Person.txt");
    if (file.ReadToEnd().Length!=0)
    {
        var ex = JsonSerializer.Deserialize<List<Person>>(file.ReadToEnd());

        file.Close();
        return ex;
    }
    file.Close();
    return new List<Person>();
     
}