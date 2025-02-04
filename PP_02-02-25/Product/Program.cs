using System;

class Product
{
    //Instance variables
    public string productName ;
    public double price ;
    // Static variable
    public static int totalProducts = 0;

    // Constructor
    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }

    // Method to display product details
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: $" + price);
        Console.WriteLine("-----------------");
    }

    // Static method to display total products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products: " + totalProducts);
        Console.WriteLine("-----------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create two product objects
        Product product1 = new Product("Laptop", 999.99);
        Product product2 = new Product("Smartphone", 499.99);

        // Display product details
        product1.DisplayProductDetails();
        product2.DisplayProductDetails();
        // Display total products
        Product.DisplayTotalProducts();
    }
}
