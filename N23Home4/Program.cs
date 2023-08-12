using N23Home4;

List<Book> books = new List<Book>()
{
    new Book("Saodat Asri", 8, "Ahmad Lutfiy Qozonchi"),
    new Book("Oltin Silsila", 10, "Shayx Muhammad Sodiq Muhammad Yusuf"),
    new Book("O'tgan kunlar", 9, "Abdulla Qodiriy"),
    new Book("Mehrobdan Chayon", 8, "Abdulla Qodiriy"),
    new Book("Jinlar Bazimi", 4, "Abdulla Qodiriy"),
    new Book("Tavsiri Hilol", 10, "Shayx Muhammad Sodiq Muhammad Yusuf")
};

//var newBook = books.OrderByDescending(book => book.Rating).ToList();

//newBook.ForEach(book => Console.WriteLine($"{book.Name.PadRight(15)}" +
//    $"Rayting: {book.Rating.ToString().PadRight(5)}{book.Author}"));
//Console.WriteLine("\n");

//var bookA = newBook.First(book => book.Author == "Abdulla Qodiriy");
//var bookB = newBook.Last(book => book.Author == "Abdulla Qodiriy");
//Console.WriteLine($"{bookA.Name} {bookA.Rating} {bookA.Author}");
//Console.WriteLine($"{bookB.Name} {bookB.Rating} {bookB.Author}");

var bookA = books.OrderByDescending(book => book.Rating).FirstOrDefault(book => book.Author == "Abdulla Qodiriy");
var bookB = books.OrderByDescending(book => book.Rating).LastOrDefault(book => book.Author == "Abdulla Qodiriy");
Console.WriteLine($"{bookA.Name} {bookA.Rating} {bookA.Author}");
Console.WriteLine($"{bookB.Name} {bookB.Rating} {bookB.Author}");