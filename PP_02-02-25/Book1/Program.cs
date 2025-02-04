using System;

class Book
{
    // Public variable
    public string ISBN;

    // Protected variable
    protected string title;

    // Private variable
    private string author;

    // Constructor
    public Book(string ISBN, string title, string author)
    {
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }

    // Public method to get the author name
    public string GetAuthor()
    {
        return author;
    }

    // Public method to set the author name
    public void SetAuthor(string authorName)
    {
        author = authorName;
        Console.WriteLine("Author updated " );
        Console.WriteLine("-----------------");
    }
}

class EBook : Book
{
    // Constructor to initialize the EBook class
    public EBook(string ISBN, string title, string author)
        : base(ISBN, title, author) { }

    // Method to display EBook details
    public void DisplayEBookDetails()
    {
        Console.WriteLine("ISBN: " + ISBN);        // Accessible (public)
        Console.WriteLine("Title: " + title);      // Accessible (protected)
        Console.WriteLine("Author: " + GetAuthor());  // Accessible via public GetAuthor method
        Console.WriteLine("-----------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Book
        Book book1 = new Book("978-3-164", "Book1", "Author1");

        // Access and modify the author name using public methods
        Console.WriteLine("Author: " + book1.GetAuthor());
        book1.SetAuthor("Author2");
        Console.WriteLine("Author: " + book1.GetAuthor());

        // Create an instance of EBook
        EBook ebook1 = new EBook("978-1-23", "ebook1", "Author3");
        ebook1.DisplayEBookDetails();  // Display EBook details
    }
}
