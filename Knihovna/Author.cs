public class Author
{
    public string Name { get; set; }
    public string Biography { get; set; }
    public DateTime BirthDate { get; set; }

    public Author(string name, string biography, DateTime birthDate)
    {
        Name = name;
        Biography = biography;
        BirthDate = birthDate;
    }
}