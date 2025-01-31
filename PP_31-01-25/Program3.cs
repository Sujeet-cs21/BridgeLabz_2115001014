using System;

//Book Class
public class Book
{
    //Attributes
    public string title;
    public string author;
    public double price;

    //Constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    //Method to display details
    public void DisplayDetails()
    {
        Console.WriteLine("title: " + title);
        Console.WriteLine("author: " + author);
        Console.WriteLine("price: ₹" + price.ToString("F2"));
        Console.WriteLine("*****************************");
    }
}

//Main Class
public class Program
{
    //Main Method
    public static void Main(string[] args)
    {
        //Create instances of the Book class
        Book book1 = new Book("Godan", "Munshi Premchand", 200);
        Book book2 = new Book("Wings of Fire", "APJ Abdul Kalam", 300);
        Book book3 = new Book("Dark Horse", "Nilotpal Mrinal", 250);

        //Display the details of the books
        book1.DisplayDetails();
        book2.DisplayDetails();
        book3.DisplayDetails();
    }
}