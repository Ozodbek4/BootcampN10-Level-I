string[] studentName = new string[10]
{
    "Hasanboy", "Alisher", "Nuriddin", "Faziddin", "Nodir",
    "Husan", "Hasan", "Vali", "Shaxriyor", "Javlon"
};
int[] studentPoint = new int[10]
{
    90, 88, 77, 65, 98, 100, 81, 69, 79, 92
};

var avarageBall = 0;
for  (int i = 0; i < studentName.Length - 1; i++)
{
    avarageBall += studentPoint[i];
    for (int j = i + 1; j < studentPoint.Length; j++)
    {
        if (studentPoint[i] < studentPoint[j])
        {
            int a = studentPoint[i];
            studentPoint[i] = studentPoint[j];
            studentPoint[j] = a;
            var b = studentName[i];
            studentName[i] = studentName[j];
            studentName[j] = b;
        }
    }
}
avarageBall /= studentPoint.Length;
Console.WriteLine($"Eng yuqori ball: {studentPoint[0]}\n" +
    $"Eng past ball: {studentPoint[studentPoint.Length - 1]}\n" +
    $"O'rtacha ball: {avarageBall}");
for (int i = 0; i < studentName.Length; i++)
{
    if (studentPoint[i] > 90) 
        Console.WriteLine(studentName[i] + " - Top " + studentPoint[i]);
    else if (studentPoint[i] > 80)
        Console.WriteLine(studentName[i] + " - Good " + studentPoint[i]);
    else if (studentPoint[i] >= 70)
        Console.WriteLine(studentName[i] + " " + studentPoint[i]);
    else Console.WriteLine(studentName[i] + " - Fail " + studentPoint[i]);
}