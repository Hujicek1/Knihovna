public class Account
{
    public int Number { get; set; }
    public DateTime Opened { get; set; }

    public Account(int number, DateTime opened)
    {
        Number = number;
        Opened = opened;
    }
}