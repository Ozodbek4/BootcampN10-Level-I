using N21Task1;
using N21Task1.Servises;

Student<Guid, string> student = new Student<Guid, string>(Guid.NewGuid(), "Middle", "Akram");
Course course = new Course(".Net");
University<Student<Guid, string>, Guid, string> university = new University<Student<Guid, string>, Guid, string>();
university.EnrollStudent(student, course);
Console.WriteLine(university.Students[0]);

List<int> newl = new List<int>();

var a = DateTime.Now.AddHours(1) -DateTime.Now;