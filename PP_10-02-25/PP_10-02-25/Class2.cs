using System;
using System.Collections.Generic;

namespace PP_10_02_25
{
    //Abstract class Product
    abstract class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        protected double Price { get; set; }

        public Product(int id, string name, double price)
        {
            ProductId = id;
            Name = name;
            Price = price;
        }

        public abstract double CalculateDiscount();
        public abstract double CalculateTax();

        public void DisplayDetails()
        {
            double finalPrice = Price + CalculateTax() - CalculateDiscount();
            Console.WriteLine("ID: " + ProductId + ", Name: " + Name + ", Final Price: " + finalPrice);
        }
    }

    // Interface ITaxable
    interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }

    // Electronics class
    class Electronics : Product, ITaxable
    {
        public Electronics(int id, string name, double price) : base(id, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.1; // 10% discount
        }

        public override double CalculateTax()
        {
            return Price * 0.15; 
        }

        public string GetTaxDetails()
        {
            return "Tax: 15%";
        }
    }

    // Clothing class
    class Clothing : Product, ITaxable
    {
        public Clothing(int id, string name, double price) : base(id, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.2; // 20% discount
        }

        public override double CalculateTax()
        {
            return Price * 0.08; // 8% tax
        }

        public string GetTaxDetails()
        {
            return "Tax: 8%";
        }
    }

    // Groceries class
    class Groceries : Product
    {
        public Groceries(int id, string name, double price) : base(id, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.05; // 5% discount
        }

        public override double CalculateTax()
        {
            return Price * 0.01;
        }
    }

    class Class2
    {
        public static void Main2()
        {
            List<Product> products = new List<Product>
            {
                new Electronics(1, "Laptop", 1000),
                new Clothing(2, "T-Shirt", 50),
                new Groceries(3, "Apple", 2)
            };

            foreach (var product in products)
            {
                product.DisplayDetails();
            }
        }
    }

}
