using N11Task1;

var summa = 100;
Console.WriteLine("Matnni kiriting: ");
var text = Console.ReadLine();

Doc obj = new Doc();
if (obj.CountText(text, 500))
{
    Console.WriteLine("Textdagi so'zlar soni 500 dan kam bo'lganligi uchun: -5 ball");
    summa -= 5;
}
if (obj.RepitedWord(text, 20))
{
    Console.WriteLine("Textdagi bir so'z textning 20% yoki undan yuqori qismini tashkil qilgani uchun: -5 ball");    
    summa -= 5;
}
if (obj.FirstWordCapital(text))
{
    Console.WriteLine("Gapdagi birinchi so'z kichik harf bilan boshlangani uchun: -5 ball");
    summa -= 5;
}
if (obj.OtherNotCapital(text))
{
    Console.WriteLine("Birinchi so'zdan boshqalar katta harfda bo'lgani uchun: -20 ball");
    summa -= 20;
}
if (obj.LengthWord(text, 20))
{
    Console.WriteLine("Gapdagi biror so'zning uzunligi 20 yoki undan yuqori bo'lgani uchun: -5 ball");
    summa -= 5;
}

Console.WriteLine($"To'plangan ball: {summa} ball");