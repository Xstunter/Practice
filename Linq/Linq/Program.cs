using Linq;

List<Book> books = new List<Book>() 
{ 
    new Book { Title = "Predator", Author = "Rollin", Genre = "Horror", Year = new DateTime(2000, 6, 1, 7, 47, 0) },
    new Book { Title = "Star Wars", Author = "Lucas", Genre = "Cosmic", Year = new DateTime(1990, 6, 1, 7, 47, 0) },
    new Book { Title = "Harry Potter", Author = "Rollin", Genre = "Fantastic", Year = new DateTime(2008, 6, 1, 7, 47, 0) }
};

/*foreach (var book in books)
{
    Console.WriteLine($"Title: {book.Title} Author: {book.Author} Genre: {book.Genre} Year: {book.Year.Year}\n");
}*/

var bookWithGenre = books.Where(book => book.Genre == "Fantastic"); //Books with genries

foreach (var book in bookWithGenre)
{
    Console.WriteLine($"Title: {book.Title} Author: {book.Author} Genre: {book.Genre} Year: {book.Year.Year}\n");
}

var yearBook = books.Where(book => book.Year.Year == 2000);

foreach (var book in yearBook)
{
    Console.WriteLine($"Title: {book.Title} Author: {book.Author} Genre: {book.Genre} Year: {book.Year.Year}\n");
}


var countAuthorBooks = books.GroupBy(book => book.Author).
    Select(group => new { Author = group.Key, BookCount = group.Count() });

foreach (var book in countAuthorBooks)
{
    Console.WriteLine($"Author: {book.Author} Count: {book.BookCount}\n");
}


var eldersBooks = books.Select(book => book.Year.Year.);

foreach (var book in countAuthorBooks)
{
    Console.WriteLine($"Author: {book.Author} Count: {book.BookCount}\n");
}