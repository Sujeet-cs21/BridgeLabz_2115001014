using System;

class Book
{
    public string Title;
    public string Author;
    public double Price;
    public bool IsAvailable;

    // Parameterized constructor
    public Book(string title, string author, double price, bool isAvailable)
    {
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = isAvailable;
    }

    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine("The book '" + Title + "' has been borrowed.");
        }
        else
        {
            Console.WriteLine("Sorry, the book '" + Title + "' is currently unavailable.");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: $" + Price);
        Console.WriteLine("Available: " + (IsAvailable ? "Yes" : "No"));
        Console.WriteLine("-----------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Book1", "Author1", 9.99, true);
        book1.DisplayInfo();
        book1.BorrowBook();
        book1.DisplayInfo();
    }
}
