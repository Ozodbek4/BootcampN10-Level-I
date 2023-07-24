﻿using N6_issue1;

List<Student> student = new List<Student>()
{
    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  BirthDay = new DateTime(2004, 1, 17),  EduType = "Python", Payment = 1600000, PaymentAmount = 500000 },
    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  BirthDay = new DateTime(2003, 12, 12),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 3000000 },
    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  BirthDay = new DateTime(2003, 11, 1),  EduType = "SMM", Payment = 1450000, PaymentAmount = 2500000 },
    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  BirthDay = new DateTime(2006, 7, 18),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 0 },
    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "SMM", Payment = 1450000, PaymentAmount = 900000 },
    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  BirthDay = new DateTime(2007, 4, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  BirthDay = new DateTime(2005, 8, 1),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2500000 },
    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  BirthDay = new DateTime(2002, 1, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1500000 },
    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  BirthDay = new DateTime(2001, 3, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 1900000 },
    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  BirthDay = new DateTime(2003, 5, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1700000 },
    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  BirthDay = new DateTime(2006, 2, 7),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  BirthDay = new DateTime(2003, 5, 6),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2700000 },
    new Student(){ Id = 15, FullName = "To'rayev Dinur Alisher O'g'li",  BirthDay = new DateTime(2002, 8, 22),  EduType = "Python", Payment = 1600000, PaymentAmount = 2000000 },
    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  BirthDay = new DateTime(2000, 11, 20),  EduType = "SMM", Payment = 1450000, PaymentAmount = 1400000 },
    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  BirthDay = new DateTime(2005, 2, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  BirthDay = new DateTime(2006, 5, 9),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2400000 },
};
int[,] balls = new int[,]
{
    { 90, 100, 75, 60 },
    { 100, 100, 70, 0 },
    { 90, 50, 60, 100 },
    { 60, 50, 100, 90 },
    { 100, 10, 75, 45 },
    { 55, 85, 70, 60 },
    { 95, 90, 40, 100 },
    { 80, 100, 100, 40 },
    { 65, 80, 100, 50 },
    { 80, 90, 100, 60 },
    { 90, 85, 65, 55 },
    { 100, 55, 90, 100 },
    { 80, 75, 90, 60 },
    { 90, 90, 100, 55 },
    { 100, 60, 90, 75 },
    { 90, 80, 50, 100 },
    { 100, 100, 60, 60 },
    { 90, 50, 80, 90 },
};

Console.WriteLine("1 - Talabalar ro'yxati");
Console.WriteLine("2 - To'lovlar");
Console.WriteLine("3 - Baholar");
Console.WriteLine("4 - Talaba qo'shish");
Console.WriteLine("Kerakli raqamni tallang");
var choiceTable = Console.ReadLine();
switch (choiceTable)
{
    case "1":
        Console.WriteLine("1 - dotnet");
        Console.WriteLine("2 - smm");
        Console.WriteLine("3 - python");
        Console.WriteLine("4 - dizayn");
        Console.WriteLine("Kerakli raqamni tallang: ");
        var choiceCases = Console.ReadLine();
        switch (choiceCases)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("dotnet talabalari: ");
                foreach (var name in student)
                {
                    if (name.EduType == "DotNET") Console.WriteLine($"{name.FullName}");
                }
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("smm talabalari: ");
                foreach (var name in student)
                {
                    if (name.EduType == "SMM") Console.WriteLine($"{name.FullName}");
                }
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("python talabalari: ");
                foreach (var name in student)
                {
                    if (name.EduType == "Python") Console.WriteLine($"{name.FullName}");
                }
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("dizayn talabalari: ");
                foreach (var name in student)
                {
                    if (name.EduType == "Dizayn") Console.WriteLine($"{name.FullName}");
                }
                break;
        }
        break;
    case "2":
        Console.Clear();
        Console.WriteLine("1 - dotnet");
        Console.WriteLine("2 - smm");
        Console.WriteLine("3 - python");
        Console.WriteLine("4 - dizayn");
        Console.WriteLine("Kerakli raqamni tallang: ");
        var choiceCasesA = Console.ReadLine();
        switch (choiceCasesA)
        {
            case "1":
                Console.Clear();
                Console.WriteLine($"{"FIO".PadRight(45, ' ')}{"Kontrakt".PadRight(20, ' ')}{"To'langan".PadRight(20, ' ')}{"Qoldiq"}");
                foreach (var name in student)
                {
                    if (name.EduType == "DotNET")
                    {
                        Console.WriteLine($"{name.FullName.PadRight(45, ' ')}{name.Payment.ToString().PadRight(20, ' ')}{name.PaymentAmount.ToString().PadRight(20, ' ')}{name.GetPayment().ToString().PadRight(20, ' ')}");
                    }
                }
                break;
            case "2":
                Console.Clear();
                Console.WriteLine($"{"FIO".PadRight(45, ' ')}{"Kontrakt".PadRight(20, ' ')}{"To'langan".PadRight(20, ' ')}{"Qoldiq"}");
                foreach (var name in student)
                {
                    if (name.EduType == "SMM")
                    {
                        Console.WriteLine($"{name.FullName.PadRight(45, ' ')}{name.Payment.ToString().PadRight(20, ' ')}{name.PaymentAmount.ToString().PadRight(20, ' ')}{name.GetPayment().ToString().PadRight(20, ' ')}");
                    }
                }
                break;
            case "3":
                Console.Clear();
                Console.WriteLine($"{"FIO".PadRight(45, ' ')}{"Kontrakt".PadRight(20, ' ')}{"To'langan".PadRight(20, ' ')}{"Qoldiq"}");
                foreach (var name in student)
                {
                    if (name.EduType == "Python")
                    {
                        Console.WriteLine($"{name.FullName.PadRight(45, ' ')}{name.Payment.ToString().PadRight(20, ' ')}{name.PaymentAmount.ToString().PadRight(20, ' ')}{name.GetPayment().ToString().PadRight(20, ' ')}");
                    }
                }
                break;
            case "4":
                Console.Clear();
                Console.WriteLine($"{"FIO".PadRight(45, ' ')}{"Kontrakt".PadRight(20, ' ')}{"To'langan".PadRight(20, ' ')}{"Qoldiq"}");
                foreach (var name in student)
                {
                    if (name.EduType == "Dizayn")
                    {
                        Console.WriteLine($"{name.FullName.PadRight(45, ' ')}{name.Payment.ToString().PadRight(20, ' ')}{name.PaymentAmount.ToString().PadRight(20, ' ')}{name.GetPayment().ToString().PadRight(20, ' ')}");
                    }
                }
                break;
        }
        break;
    case "3":
        Console.Clear();
        Console.WriteLine(string.Format($"{"Ballar".ToString().PadRight(45, ' ')}{"12.07".ToString().PadRight(20, ' ')}{"12.07".ToString().PadRight(20, ' ')}{"13.07"}"));
        for (int i = 0; i < student.Count; i++)
        {
            Console.WriteLine(string.Format($"{student[i].FullName.ToString().PadRight(45,' ')}{balls[i, 0].ToString().PadRight(20, ' ')}{balls[i, 2].ToString().PadRight(20, ' ')}{balls[i, 3]}"));
        }
        break;
    case "4":
        Console.WriteLine("FIO: ");
        var NewStudentName = Console.ReadLine();
        Console.WriteLine("Yo'nalish: ");
        var NewStudentEduType = Console.ReadLine();
        student.Add(new Student{
            Id = student.Count + 1,
            FullName = NewStudentName,
            BirthDay = DateTime.Now,
            EduType = NewStudentEduType
        });
        Console.WriteLine("Ro'yxatni ko'rish uchun Y ni bosing: ");
        var ForSeeing = Console.ReadLine();
        if ( ForSeeing == "Y" ||  ForSeeing == "y")
        {
            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine(string.Format($"{student[i].FullName.ToString().PadRight(45, ' ')}"));
            }
        }
        break;
}