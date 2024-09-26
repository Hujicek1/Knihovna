public class Book
{
    public string ISBN { get; set; }
    public string Name { get; set; }
    public string Subject { get; set; }
    public string Publisher { get; set; }
    public DateTime PublicationDate { get; set; }
    public string Lang { get; set; }
    public List<Author> Authors { get; set; } = new List<Author>();

    public Book(string isbn, string name, string subject, string publisher, DateTime publicationDate, string lang)
    {
        ISBN = isbn;
        Name = name;
        Subject = subject;
        Publisher = publisher;
        PublicationDate = publicationDate;
        Lang = lang;
    }
}