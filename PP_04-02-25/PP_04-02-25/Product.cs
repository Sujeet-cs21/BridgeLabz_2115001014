using System;

namespace PP_04_02_25
{
    class Product
    {
        // Static variable shared by all products
        public static double Discount = 10.0;

        // Readonly variable for Product ID
        public readonly int ProductID;

        // Product details
        public string ProductName;
        public double Price;
        public int Quantity;

        // Constructor
        public Product(int ProductID, string ProductName, double Price, int Quantity)
        {
            // Using 'this' to initialize fields
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        // Static method to update discount
        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
            Console.WriteLine("Discount Updated");
            Console.WriteLine("********************");
        }

        // Method to display product details
        public void DisplayProductDetails()
        {
            // Using 'is' operator to check instance type
            if (this is Product)
            {
                Console.WriteLine("Product ID: " + ProductID);
                Console.WriteLine("Product Name: " + ProductName);
                Console.WriteLine("Price: $" + Price);
                Console.WriteLine("Quantity: " + Quantity);
                Console.WriteLine("Discount: " + Discount + "%");
                Console.WriteLine("********************");
            }
            else
            {
                Console.WriteLine("Invalid product object.");
            }
        }
        public static void RunProductClass()
        {
            // Creating product instances
            Product prod1 = new Product(101, "Laptop", 1200.00, 5);
            Product prod2 = new Product(102, "Smartphone", 800.50, 10);

            // Display product details
            prod1.DisplayProductDetails();
            prod2.DisplayProductDetails();

            // Update discount
            Product.UpdateDiscount(15.0);

            // Display updated product details
            prod1.DisplayProductDetails();
            prod2.DisplayProductDetails();
        }
    }
}
