using System;

class Book
{
    public string Title;
    public string Author;
    public double Price;

    // Default constructor
    public Book()
    {
        Title = "Book1";
        Author = "Author1";
        Price = 50.0;
    }

    // Parameterized constructor
    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: $" + Price);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book(); // Default constructor
        Book book2 = new Book("Book2","Author2",10.4); // Parameterized constructor

        book1.DisplayInfo();
        Console.WriteLine("-----------------");
        book2.DisplayInfo();
    }
}
