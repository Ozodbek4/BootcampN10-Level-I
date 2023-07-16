Random random = new Random();
string[] question = new string[] { "What is alternative for else -if ?", "How do you insert COMMENTS in C# code ?",
        "Which property can be used to find the lenth of a string ?", "Array index start with: ",
        "How do you write an if statement ic C# ?"};
string[] questionTrueAnswer = new string[] {"Switch case", "// This is a comment", "Length", "0", "if (x > y)"};
string[] questionFalseAnswer = new string[] { "Switch Expression case", "# This is a comment", "getLength", "1", "if x > y:"};
string[] answerUserKey = new string[question.Length];
string[] answerTrueKey = new string[question.Length];
bool[] answerTrueFalseKey = new bool[] {true, true, true, true, true};
var answerPoint = 100;
int[] randNumber = new int[question.Length];
for (int i = 0; i < question.Length; i++)
{
    randNumber[i] = random.Next(0, 2);
}

for (int i = 0; i < question.Length; i++)
{
    Console.WriteLine($"{question[i]}");
    if (randNumber[i] == 0)
    {
        Console.WriteLine($"A) {questionTrueAnswer[i]}");
        answerTrueKey[i] = "A";
    }
    else
    {
        Console.WriteLine($"A) {questionFalseAnswer[i]}");
    }
    if (randNumber[i] == 0)
    {
        Console.WriteLine($"B) {questionFalseAnswer[i]}");
        answerTrueFalseKey[i] = false;
    }
    else
    {
        Console.WriteLine($"B) {questionTrueAnswer[i]}");
        answerTrueKey[i] = "B";
        answerTrueFalseKey[i] = false;
    }
    answerUserKey[i] = Console.ReadLine();
}

Console.WriteLine($"\n      **** Xato javoblar **** ");
for  (int i = 0; i < question.Length; i++)
{
    if (answerUserKey[i] != answerTrueKey[i])
    {
        Console.WriteLine("\n");
        answerPoint -= 20;
        Console.WriteLine($"Kiritgan javobingiz: {answerUserKey[i]}\nTo'g'ri javob {answerTrueKey[i]}");
        Console.WriteLine($"{question[i]}");
        if (randNumber[i] == 0 && answerTrueFalseKey[i] == false)
        {
            Console.WriteLine($"A) {questionTrueAnswer[i]}");
        }
        else if (randNumber[i] == 0 && answerTrueFalseKey[i] == false)
        {
            Console.WriteLine($"A) {questionFalseAnswer[i]}");
        }
        if (randNumber[i] == 0 && answerTrueFalseKey[i] == false)
        {
            Console.WriteLine($"B) { questionFalseAnswer[i]}");
        }
        else if (randNumber[i] == 0 && answerTrueFalseKey[i] == false)
        {
            Console.WriteLine($"B) {questionTrueAnswer[i]}");
        }
        //
        if (randNumber[i] == 1 && answerTrueFalseKey[i] == false)
        {
            Console.WriteLine($"A) {questionFalseAnswer[i]}");
        }
        else if (randNumber[i] == 1 && answerTrueFalseKey[i] == false)
        {
            Console.WriteLine($"A) {questionTrueAnswer[i]}");
        }
        if (randNumber[i] == 1 && answerTrueFalseKey[i] == false)
        {
            Console.WriteLine($"B) {questionTrueAnswer[i]}");
        }
        else if (randNumber[i] == 1 && answerTrueFalseKey[i] == false)
        {
            Console.WriteLine($"B) {questionFalseAnswer[i]}");
        }

    }
}
Console.WriteLine($"\nTo'plagan balingiz: {answerPoint}");