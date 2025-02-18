using System;
using System.Collections.Generic;

namespace PP_18_02_25
{

    // Abstract class for Warehouse Items
    public abstract class WarehouseItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        protected WarehouseItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void DisplayInfo();
    }

    // Derived Classes
    public class Electronics : WarehouseItem
    {
        public string Brand { get; set; }

        public Electronics(string name, double price, string brand) : base(name, price)
        {
            Brand = brand;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Electronics: " + Name + ", Brand: " + Brand + ", Price: $" + Price);
        }
    }

    public class Groceries : WarehouseItem
    {
        public int Amount { get; set; }

        public Groceries(string name, double price, int amount) : base(name, price)
        {
            Amount = amount;
        }

        public override void DisplayInfo() 
        {
            Console.WriteLine("Grocery: " + Name + ", Amount: " + Amount + " units, Price: $" + Price);
        }
    }

    public class Furniture : WarehouseItem
    {
        public string Material { get; set; }

        public Furniture(string name, double price, string material) : base(name, price)
        {
            Material = material;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Furniture: " + Name + ", Material: " + Material + ", Price: $" + Price);
        }
    }

    // Generic Storage Class
    public class Storage<T> where T : WarehouseItem
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void DisplayItems()
        {
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }
    }

    class Class1
    {
        public static void Main1()
        {
            Storage<Electronics> electronicsStorage = new Storage<Electronics>();
            electronicsStorage.AddItem(new Electronics("Laptop", 1200, "Dell"));
            electronicsStorage.AddItem(new Electronics("Smartphone", 800, "Samsung"));

            Storage<Groceries> groceriesStorage = new Storage<Groceries>();
            groceriesStorage.AddItem(new Groceries("Milk", 3.5, 2));
            groceriesStorage.AddItem(new Groceries("Bread", 2.0, 1));

            Storage<Furniture> furnitureStorage = new Storage<Furniture>();
            furnitureStorage.AddItem(new Furniture("Chair", 75, "Wood"));
            furnitureStorage.AddItem(new Furniture("Table", 150, "Metal"));

            Console.WriteLine("Electronics Storage:");
            electronicsStorage.DisplayItems();

            Console.WriteLine("\nGroceries Storage:");
            groceriesStorage.DisplayItems();

            Console.WriteLine("\nFurniture Storage:");
            furnitureStorage.DisplayItems();
        }
    }

}
