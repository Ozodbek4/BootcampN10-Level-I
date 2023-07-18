using N6_issue1;

List<Student> student = new List<Student>()
{
    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  Age = 18,  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  Age = 20,  EduType = "Python", Payment = 2400000 },
    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  Age = 21,  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  Age = 16,  EduType = "SMM", Payment = 2400000 },
    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  Age = 17,  EduType = "Dizayn", Payment = 2400000 },
    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  Age = 23,  EduType = "SMM", Payment = 2400000 },
    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  Age = 22,  EduType = "Dizayn", Payment = 2400000 },
    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  Age = 21,  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  Age = 19,  EduType = "Python", Payment = 2400000 },
    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  Age = 20,  EduType = "Dizayn", Payment = 2400000 },
    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  Age = 19,  EduType = "Python", Payment = 2400000 },
    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  Age = 16,  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  Age = 24,  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 15, FullName = "To'rayev Dinur Alisher O'g'li",  Age = 21,  EduType = "Python", Payment = 2400000 },
    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  Age = 25,  EduType = "SMM", Payment = 2400000 },
    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  Age = 16,  EduType = "Dizayn", Payment = 2400000 },
    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  Age = 23,  EduType = "DotNET", Payment = 2400000 },
};

Console.WriteLine("1 - Talabalar ro'yxati");
Console.WriteLine("2 - To'lovlar");
Console.WriteLine("Kerakli raqamni tallang");
var choiceTable = Console.ReadLine();
switch (choiceTable) {
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
                Console.WriteLine("dotnet talabalari: ");
                foreach (var name in student)
                {
                    if (name.EduType == "DotNET") Console.WriteLine($"{name.FullName}");
                }
                break;
            case "2":
                Console.WriteLine("smm talabalari: ");
                foreach (var name in student)
                {
                    if (name.EduType == "SMM") Console.WriteLine($"{name.FullName}");
                }
                break;
            case "3":
                Console.WriteLine("python talabalari: ");
                foreach (var name in student)
                {
                    if (name.EduType == "Python") Console.WriteLine($"{name.FullName}");
                }
                break;
            case "4":
                Console.WriteLine("dizayn talabalari: ");
                foreach (var name in student)
                {
                    if (name.EduType == "Dizayn") Console.WriteLine($"{name.FullName}");
                }
                break;
        }
        break;
    case "2":
        Console.WriteLine("Hozircha bizda bunga aloqdor ma'lumotlar mavjud emas");
        break;
}