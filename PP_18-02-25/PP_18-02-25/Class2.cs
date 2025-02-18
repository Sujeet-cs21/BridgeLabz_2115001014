using System;

namespace PP_18_02_25
{
    // Define Product Categories
    public abstract class ProductCategory
    {
        public string CategoryName { get; set; }
    }

    public class BookCategory : ProductCategory
    {
        public BookCategory() { CategoryName = "Books"; }
    }

    public class ClothingCategory : ProductCategory
    {
        public ClothingCategory() { CategoryName = "Clothing"; }
    }

    // Generic Product Class
    public class Product<T> where T : ProductCategory
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public T Category { get; set; }

        public Product(string name, double price, T category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public void DisplayProduct()
        {
            Console.WriteLine("Product: " + Name + ", Price: $" + Price + ", Category: " + Category.CategoryName);
        }
    }

    // Generic Utility Class
    public static class MarketplaceUtils
    {
        // Generic Method to Apply Discount
        public static void ApplyDiscount<T, C>(Product<C> product, double percentage) where C : ProductCategory
        {
            product.Price -= product.Price * (percentage / 100);
            Console.WriteLine("Discount applied! New Price of " + product.Name + ": $" + product.Price);
        }
    }

    // Main Program
    class Class2
    {
        public static void Main2()
        {
            // Create categories
            BookCategory bookCategory = new BookCategory();
            ClothingCategory clothingCategory = new ClothingCategory();

            // Create products
            Product<BookCategory> book = new Product<BookCategory>("C# Programming", 50.0, bookCategory);
            Product<ClothingCategory> tshirt = new Product<ClothingCategory>("Cool T-Shirt", 20.0, clothingCategory);

            // Display products
            book.DisplayProduct();
            tshirt.DisplayProduct();

            // Apply discounts
            MarketplaceUtils.ApplyDiscount<Product<BookCategory>, BookCategory>(book, 10);
            MarketplaceUtils.ApplyDiscount<Product<ClothingCategory>, ClothingCategory>(tshirt, 15);
        }
    }

}
