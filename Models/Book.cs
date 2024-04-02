namespace ConsoleApp3.Models;

public class Book
{
    string _title;
    string _author;
    string _publisher;
    int _availableCopies;

    public string Title
    {
        get => _title;
        set => _title = value;
    }
    public string Author
    {
        get => _author;
        set => _author = value;
    }
    public string Publisher
    {
        get => _publisher;
        set => _publisher = value;
    }
    public int AvailableCopies
    {
        get => _availableCopies;
        set => _availableCopies = value;
    }

    public Book(string title, string author, string publisher, int availableCopies)
    {
        Title=title;
        Author=author;
        Publisher=publisher;
        AvailableCopies=availableCopies;
    }

    public void Increase(int count)
    {
        if(count<=0) Console.WriteLine("0 dan yuksek say daxil edin.");
        else AvailableCopies += count;
        Console.WriteLine($"Available copies count is {AvailableCopies}");
    }
    public void Decrease(int count)
    {
        if (count<=0) Console.WriteLine("0 dan yuksek say daxil edin.");
        else AvailableCopies -= count;
        Console.WriteLine($"Available copies count is {AvailableCopies}");
    }
}
