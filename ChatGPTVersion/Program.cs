using ChatGPTVersion;
using System.IO;
using System.Net.Http.Json;
using System.Text.Json;

var result = new List<Person>()
{
    new Person {Id = 1, Name = "Begzod", Age = 18},
    new Person {Id = 1, Name = "Begzod", Age = 18},

};

string path = @"F:\najottalim\BootcampN10-Level-I\N24Task1\Person.txt";

string jsonPerson = JsonSerializer.Serialize(result);
// StreamReader
// StreamWriter

using (StreamWriter writer = new StreamWriter(path, true))
{
    writer.Write(jsonPerson);
}

using (StreamReader reader = new StreamReader(path, true))
{
    var jsonContent = reader.ReadToEnd();
    var resultPerson = JsonSerializer.Deserialize<List<Person>>(jsonContent);
    foreach (var res in resultPerson)
    {
        Console.WriteLine($"{res.Id} {res.Name} {res.Age}");
    }
}