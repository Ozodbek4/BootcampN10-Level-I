using N26Task2;

List<Meeting> meeting = new List<Meeting>()
{
    new Meeting("Qizim bilan uchrashuv", TimeSpan.FromHours(4)),
    new Meeting("Meeting with Sulton", TimeSpan.FromHours(5)),
    new Meeting("Meeting with IELTS Instructor", TimeSpan.FromHours(2))
};
TimeSpan timeSpan = new TimeSpan();
foreach (var item  in meeting)
{
    timeSpan = item + timeSpan;
}

Console.WriteLine(timeSpan.ToString());