using System;

namespace PP_11_02_25
{
    class Book
    {
        public string Title;
        public string Author;
        public string Genre;
        public int BookID;
        public bool IsAvailable;
        public Book Next, Prev;

        public Book(string title, string author, string genre, int bookID, bool isAvailable)
        {
            Title = title;
            Author = author;
            Genre = genre;
            BookID = bookID;
            IsAvailable = isAvailable;
        }
    }

    class Class5
    {
        private Book head;
        private Book tail;
        private int count = 0;

        public void AddAtBeginning(string title, string author, string genre, int bookID, bool isAvailable)
        {
            Book newBook = new Book(title, author, genre, bookID, isAvailable);
            if (head == null)
                head = tail = newBook;
            else
            {
                newBook.Next = head;
                head.Prev = newBook;
                head = newBook;
            }
            count++;
        }

        public void AddAtEnd(string title, string author, string genre, int bookID, bool isAvailable)
        {
            Book newBook = new Book(title, author, genre, bookID, isAvailable);
            if (head == null)
                head = tail = newBook;
            else
            {
                newBook.Prev = tail;
                tail.Next = newBook;
                tail = newBook;
            }
            count++;
        }

        public void AddAtPosition(string title, string author, string genre, int bookID, bool isAvailable, int position)
        {
            if (position < 1 || position > count + 1)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            if (position == 1)
            {
                AddAtBeginning(title, author, genre, bookID, isAvailable);
                return;
            }

            Book newBook = new Book(title, author, genre, bookID, isAvailable);
            Book temp = head;
            for (int i = 1; i < position - 1; i++)
                temp = temp.Next;

            newBook.Next = temp.Next;
            newBook.Prev = temp;
            if (temp.Next != null)
                temp.Next.Prev = newBook;
            temp.Next = newBook;

            if (newBook.Next == null)
                tail = newBook;

            count++;
        }

        public void RemoveBook(int bookID)
        {
            if (head == null)
            {
                Console.WriteLine("No books in the library.");
                return;
            }

            Book temp = head;
            while (temp.Next != null)
            {
                count++;
                if (temp.Next.BookID == bookID)
                {
                    temp.Next.Next.Prev = temp;
                    temp.Next = temp.Next.Next;

                    Console.WriteLine("Book removed ");
                    return ;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Book not found");
        }

        public void SearchBookByTitle(string title)
        {
            Book temp = head;
            while (temp != null)
            {
                if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found: {temp.Title} by {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Book not found.");
        }

        public void SearchBookByAuthor(string author)
        {
            Book temp = head;
            while (temp != null)
            {
                if (temp.Author==author)
                {
                    Console.WriteLine($"Found: {temp.Title} by {temp.Author}");
                }
                temp = temp.Next;
            }
        }

        public void UpdateAvailability(int bookID, bool newStatus)
        {
            Book temp = head;
            while (temp != null)
            {
                if (temp.BookID == bookID)
                {
                    temp.IsAvailable = newStatus;
                    Console.WriteLine("Availability updated.");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Book not found.");
        }

        public void DisplayForward()
        {
            Book temp = head;
            while (temp != null)
            {
                Console.WriteLine($"{temp.Title}->");
                temp = temp.Next;
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");
        }

        public void DisplayReverse()
        {
            Book temp = tail;
            while (temp != null)
            {
                Console.Write($"{temp.Title}<-");
                temp = temp.Prev;
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");
        }

        public void CountBooks()
        {
            Console.WriteLine($"Total number of books: {count}");
        }

        public static void Main5()
        {
            Class5 lib = new Class5();

            lib.AddAtBeginning("Book1", "Author1", "Fiction", 101, true);
            lib.AddAtEnd("Book2", "Author2", "Science", 102, false);
            lib.AddAtPosition("Book3", "Author3", "History", 103, true, 2);

            Console.WriteLine("Library (Forward):");
            lib.DisplayForward();

            Console.WriteLine("Library (Reverse):");
            lib.DisplayReverse();

            lib.RemoveBook(102);
            lib.DisplayForward();

            lib.SearchBookByTitle("Book1");
            lib.SearchBookByAuthor("Author3");

            lib.UpdateAvailability(103, false);
            lib.DisplayReverse();

            lib.CountBooks();
        }
    }

}
