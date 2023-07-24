using N10issue1;

List<Book> ListBooks = new List<Book>()
{
    new Book(){Id = 1, Title = "Mo'min meroji", Author = "Hilol nashr"},
    new Book(){Id = 2, Title = "Hayirlisi", Author = "Misbah"},
    new Book(){Id = 3, Title = "Muhabbat anatomiyasi", Author = "Fan Ziyosi"}
};

LibararyManagament libarary =  new LibararyManagament();
libarary.Books.Add("Tarix 6", 100);
libarary.Books.Add("Matematika 6", 100);
libarary.Books.Add("Fizika", 50);