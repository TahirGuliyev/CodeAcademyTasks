using ConsoleApp2;

List<Book> books = new List<Book>()
{
    new Book() { Name = "Harry Potter", AuthorName = "J.K.Rowling", PageCount = 296 },
    new Book() { Name = "Game of Thrones", AuthorName = "G.R.R.Martin", PageCount = 1296 },
    new Book() { Name = "Harry Potter 2", AuthorName = "J.K.Rowling", PageCount = 296 },
    new Book() { Name = "Game of Thrones 2", AuthorName = "G.R.R.Martin", PageCount = 1296 },
    new Book() { Name = "Game of Thrones 3", AuthorName = "G.R.R.Martin", PageCount = 1296 },
};
Library lib = new Library(books);

foreach (var item in lib.books)
{
    Console.WriteLine($"Name: {item.Name} Code: {item.Code}");
}

List<Book> result = lib.SearchBooks("Har");
Console.WriteLine("SearchBooks ------ (Har)");
foreach (var item in result)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine("=====================================================");
List<Book> result1 = lib.FindAllBooksByName("Harry Potter");
Console.WriteLine("FindAllBooksByName('Harry Potter')");
foreach (var item in result1)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine("=====================================================");
lib.RemoveAllBooksByName("Game of Thrones 3");
Console.WriteLine("lib.RemoveAllBooksByName(\"Game of Thrones 3\");");
foreach (var item in lib.books)
{
    Console.WriteLine(item.Name);
}
List<Book> result3 = lib.FindAllBooksByPageCountRange(100,300);
Console.WriteLine("FindAllBooksByPageCountRange(100,300)");
foreach (var item in result3)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine("=====================================================");

lib.RemoveBookByCode("Ga1");
foreach (var item in lib.books)
{
    Console.WriteLine(item.Name);
}