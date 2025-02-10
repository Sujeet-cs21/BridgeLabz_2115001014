using System;
using System.Collections.Generic;

namespace PP_10_02_25
{
    // Abstract class FoodItem
    abstract class FoodItem
    {
        public string ItemName { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public FoodItem(string itemName, double price, int quantity)
        {
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
        }

        public abstract double CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine("Item: " + ItemName + ", Price: " + Price + ", Quantity: " + Quantity + ", Total Price: " + CalculateTotalPrice());
        }
    }

    // Interface IDiscountable
    interface IDiscountable
    {
        void ApplyDiscount(double percentage);
        string GetDiscountDetails();
    }

    // VegItem class
    class VegItem : FoodItem, IDiscountable
    {
        private double Discount;

        public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity)
        {
            Discount = 0;
        }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) - ((Price * Quantity) * Discount / 100);
        }

        public void ApplyDiscount(double percentage)
        {
            Discount = percentage;
        }

        public string GetDiscountDetails()
        {
            return "Discount applied: " + Discount + "%";
        }
    }

    // NonVegItem class
    class NonVegItem : FoodItem, IDiscountable
    {
        private double Discount;
        private double ExtraCharge = 10; // Additional charge for non-veg items

        public NonVegItem(string itemName, double price, int quantity) : base(itemName, price, quantity)
        {
            Discount = 0;
        }

        public override double CalculateTotalPrice()
        {
            return ((Price * Quantity) + ExtraCharge) - (((Price * Quantity) + ExtraCharge) * Discount / 100);
        }

        public void ApplyDiscount(double percentage)
        {
            Discount = percentage;
        }

        public string GetDiscountDetails()
        {
            return "Discount applied: " + Discount + "%";
        }
    }

    class Class6
    {
        public static void Main6()
        {
            List<FoodItem> menu = new List<FoodItem>
            {
                new VegItem("Paneer Tikka", 150, 2),
                new NonVegItem("Chicken Peri Peri", 175, 3)
            };

            foreach (var item in menu)
            {
                item.GetItemDetails();
            }
        }
    }
}
