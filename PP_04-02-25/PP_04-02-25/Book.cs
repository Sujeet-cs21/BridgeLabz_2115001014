using System;

namespace PP_04_02_25
{
    class Book
    {
        // Static variable shared across all books
        public static string LibraryName = "Central Library";

        // Readonly variable for ISBN
        public readonly string ISBN;

        // Book details
        public string Title;
        public string Author;

        // Constructor
        public Book(string Title, string Author, string ISBN)
        {
            // Using 'this' to initialize fields
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }

        // Static method to display library name
        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library Name: " + LibraryName);
            Console.WriteLine("********************");
        }

        // Method to display book details
        public void DisplayBookDetails()
        {
            // Using 'is' operator to check instance type
            if (this is Book)
            {
                Console.WriteLine("Library Name: " + LibraryName);
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Author: " + Author);
                Console.WriteLine("ISBN: " + ISBN);
                Console.WriteLine("********************");
            }
            else
            {
                Console.WriteLine("Invalid book object.");
            }
        }

        public static void RunBookClass()
        {
            // Creating book instances
            Book book1 = new Book("Book1", "Author1", "987654321");
            Book book2 = new Book("Book2", "Author2", "123456789");

            // Display library name
            Book.DisplayLibraryName();

            // Display book details
            book1.DisplayBookDetails();
            book2.DisplayBookDetails();
        }
    }
}
