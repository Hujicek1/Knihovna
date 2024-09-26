namespace Knihovna;


class Program
{
    static void Main(string[] args)
    {
// Create Author
        Author author1 = new Author("David Brada", "mistr Brada", new DateTime(1930, 5, 23));

        Book book1 = new Book("1234567890", "C# Programming", "Programming", "Tech Publishers", new DateTime(2022, 1, 15), "English");
        book1.Authors.Add(author1);  
        Book book2 = new Book("21241212", "ASD", "DSA", "polytechnasro", new DateTime(1230,12,10), "French");
        book2.Authors.Add(author1);
        // Create Book Item
        BookItem bookItem1 = new BookItem("BK001", "1234567890", "C# Programming", Language.English, 350, Format.Paperback);
        BookItem bookItem2 = new BookItem("BK002", "212421212","ASD",Language.French,420,Format.MP3CD);
        // Create Account
        Account account1 = new Account(1, DateTime.Now);
        Account account2 = new Account(2, DateTime.Now);
        // Output Details
        Console.WriteLine($"Book: {book1.Name}, ISBN: {book1.ISBN}, Author: {book1.Authors[0].Name}");
        Console.WriteLine($"Book Item: {bookItem1.Title}, Format: {bookItem1.Format}, Pages: {bookItem1.NumberOfPages}");
        Console.WriteLine($"Account: {account1.Number}, Opened: {account1.Opened}"); 

        Console.WriteLine($"Book: {book2.Name}, ISBN: {book2.ISBN}, Author: {book2.Authors[0].Name}");
        Console.WriteLine($"Book Item: {bookItem2.Title}, Format: {bookItem2.Format}, Pages: {bookItem2.NumberOfPages}");
        Console.WriteLine($"Account: {account2.Number}, Opened: {account2.Opened}");   
        
        
        }
}
