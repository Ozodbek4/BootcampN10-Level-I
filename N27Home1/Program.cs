using N27Home1.Model;
using System;

//public Guid Id { get; set; }
//public string Title { get; set; }
//public string Description { get; set; }
//public int Like { get; set; }
//public int Dislike { get; set; }
//public Topics Topics { get; set; }

//Fun,
//IT,
//Gaming,
//Business

List<VideoPost> list = new List<VideoPost>()
{
    new VideoPost("IPhone 15 serias", "There are 4 models in this generation", 1_000_000, 10, Topics.Fun),
    new VideoPost("Relationship", "Today is mothers day", 10_000, 200, Topics.Fun),
    new VideoPost("C#", "You can write great sites", 10_000_000, 1_000, Topics.IT),
    new VideoPost("Js", "Greater than C#", 400_000, 1_000_000, Topics.IT),
    new VideoPost("Motivation", "If I am 20, I would change my daily plan", 1_000, 100, Topics.Business),
    new VideoPost("Pubg", "Uzbek player is top 3 in the world", 100_000, 200_000, Topics.Gaming),
    new VideoPost("Avaz Oxun", "Kulgi terapiyasi nomli konsert dasturi", 125_000, 1, Topics.Fun),
    new VideoPost("Electro Car", "Obzor about Chery Tiggo 7 Pro", 100, 2, Topics.Fun),
    new VideoPost("America road", "From the dangures way to America", 9_000, 10, Topics.Fun),
    new VideoPost("Kia K8", "It is one of the best model of Kia", 803, 10, Topics.Fun)
};

Console.WriteLine("Eng ko'p like olgan");
var likeMax = list.MaxBy(like => like.Like);
Console.WriteLine($"Video: {likeMax.Title}, Layklar soni: {likeMax.Like}\n");

Console.WriteLine("Eng kam dislike olgani");
var dislikeMin = list.MinBy(dislike => dislike.Dislike);
Console.WriteLine($"Video: {dislikeMin.Title}, Layklar soni: {dislikeMin.Dislike}\n");

Console.WriteLine($"O'rtacha liklar soni: {list.Average(like => like.Like)}\n");

Console.WriteLine($"Barcha dislikelar soni: {list.Sum(dislike => dislike.Dislike)}\n");

Console.WriteLine("Videolarni faqat title va description bo'yicha projetion qilib\n -----------");
list.Select(item => new
{
    Title = item.Title,
    Description = item.Description
}).ToList().ForEach(x => Console.WriteLine($"{x.Title} - {x.Description}"));