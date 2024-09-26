public enum Language
{
    English,
    French,
    German,
    Spanish
}
public enum Format
{
    Paperback,
    Hardcover,
    Audiobook,
    AudioCD,
    MP3CD
}

public class BookItem
{
    public string Barcode { get; set; }
    public string ISBN { get; set; }
    public string Title { get; set; }
    public Language Lang { get; set; }
    public int NumberOfPages { get; set; }
    public Format Format { get; set; }
    public DateTime? Borrowed { get; set; }

    public BookItem(string barcode, string isbn, string title, Language lang, int numberOfPages, Format format)
    {
        Barcode = barcode;
        ISBN = isbn;
        Title = title;
        Lang = lang;
        NumberOfPages = numberOfPages;
        Format = format;
        Borrowed = null;  
    }
}