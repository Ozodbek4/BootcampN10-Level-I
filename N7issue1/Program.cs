using N7issue1;

List<Meeting> meeting = new List<Meeting>()
{
    new Meeting(){StartTime = new TimeOnly(09, 00, 00), EndTime = new TimeOnly(10, 30, 00)},
    new Meeting(){StartTime = new TimeOnly(19, 40, 00), EndTime = new TimeOnly(20, 20, 00)},
    new Meeting(){StartTime = new TimeOnly(15, 50, 00), EndTime = new TimeOnly(16, 10, 00)},
    new Meeting(){StartTime = new TimeOnly(15, 50, 00), EndTime = new TimeOnly(16, 10, 00)},
    new Meeting(){StartTime = new TimeOnly(19, 50, 00), EndTime = new TimeOnly(20, 10, 00)},
    new Meeting(){StartTime = new TimeOnly(13, 10, 00), EndTime = new TimeOnly(13, 40, 00)},
    new Meeting(){StartTime = new TimeOnly(14, 25, 00), EndTime = new TimeOnly(15, 59, 00)},
    new Meeting(){StartTime = new TimeOnly(12, 00, 00), EndTime = new TimeOnly(12, 50, 00)},
    new Meeting(){StartTime = new TimeOnly(08, 40, 00), EndTime = new TimeOnly(10, 50, 00)},
    new Meeting(){StartTime = new TimeOnly(05, 50, 00), EndTime = new TimeOnly(06, 10, 00)}
};
TimeOnly WorkStartTime = new TimeOnly(08, 00);
TimeOnly WorkEndTime = new TimeOnly(16, 00);
var TotalCounter = 0D;
var MaxTime = 0D;
var MinTime = 1440D;
for  (int i = 0; i < meeting.Count; i++)
{
    if (meeting[i].StartTime >= WorkStartTime && meeting[i].StartTime <= WorkEndTime && meeting[i].EndTime >= WorkStartTime)
    {
        Console.WriteLine($"Bad meeting: {meeting[i].StartTime.ToString()} - {meeting[i].EndTime.ToString()}");
    }
    else Console.WriteLine($"Good meeting: {meeting[i].StartTime.ToString()} - {meeting[i].EndTime.ToString()}");
}
for  (int i = 0; i < meeting.Count; i++)
{
    var a = (meeting[i].EndTime - meeting[i].StartTime).TotalMinutes;
    if (a > MaxTime) MaxTime = a;
    if (a < MinTime) MinTime = a;
    TotalCounter += a;
    if ((meeting[i].EndTime - meeting[i].StartTime).TotalMinutes > 30)
    {
        TotalCounter += (meeting[i].EndTime - meeting[i].StartTime).TotalMinutes;
        Console.WriteLine($"30 daqiqadan oshadigan uchrashuvlar: {meeting[i].StartTime.ToString()} - {meeting[i].EndTime.ToString()}");
    }
}
Console.WriteLine($"Umumiy uchrashuvlar vaqti: {TotalCounter}\n" +
    $"Eng ko'p vaqtli uvhrashuv {MaxTime}\n" +
    $"Eng kam vaqtli uchrashuv: {MinTime}");