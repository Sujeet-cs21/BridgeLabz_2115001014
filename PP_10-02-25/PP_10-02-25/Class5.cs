using System;
using System.Collections.Generic;

namespace PP_10_02_25
{
    // Abstract class LibraryItem
    abstract class LibraryItem
    {
        public string ItemId { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }

        public LibraryItem(string itemId, string title, string author)
        {
            ItemId = itemId;
            Title = title;
            Author = author;
        }

        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine("Item ID: " + ItemId + ", Title: " + Title + ", Author: " + Author + ", Loan Duration: " + GetLoanDuration() + " days");
        }
    }

    // Interface IReservable
    interface IReservable
    {
        void ReserveItem();
        bool CheckAvailability();
    }

    // Book class
    class Book : LibraryItem, IReservable
    {
        private bool IsAvailable;

        public Book(string itemId, string title, string author) : base(itemId, title, author)
        {
            IsAvailable = true;
        }

        public override int GetLoanDuration()
        {
            return 14; // 2 weeks
        }

        public void ReserveItem()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine("Book reserved successfully.");
            }
            else
            {
                Console.WriteLine("Book is already reserved.");
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable;
        }
    }

    // Magazine class
    class Magazine : LibraryItem, IReservable
    {
        private bool IsAvailable;

        public Magazine(string itemId, string title, string author) : base(itemId, title, author)
        {
            IsAvailable = true;
        }

        public override int GetLoanDuration()
        {
            return 7; // 1 week
        }

        public void ReserveItem()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine("Magazine reserved successfully.");
            }
            else
            {
                Console.WriteLine("Magazine is already reserved.");
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable;
        }
    }

    // DVD class
    class DVD : LibraryItem, IReservable
    {
        private bool IsAvailable;

        public DVD(string itemId, string title, string author) : base(itemId, title, author)
        {
            IsAvailable = true;
        }

        public override int GetLoanDuration()
        {
            return 5; // 5 days
        }

        public void ReserveItem()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine("DVD reserved successfully.");
            }
            else
            {
                Console.WriteLine("DVD is already reserved.");
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable;
        }
    }

    class Class5
    {
        public static void Main5()
        {
            List<LibraryItem> items = new List<LibraryItem>
            {
                new Book("B111", "Book1", "Author1"),
                new Magazine("M222", "Magazine", "Author2"),
                new DVD("D333", "DVD", "Author3")
            };

            foreach (var item in items)
            {
                item.GetItemDetails();
            }
        }
    }
}
