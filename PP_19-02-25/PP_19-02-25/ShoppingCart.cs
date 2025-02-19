using System;
using System.Collections.Generic;
using System.Linq;

namespace PP_19_02_25
{
    class ShoppingCart
    {
        private Dictionary<string, double> productPrices = new Dictionary<string, double>();
        private LinkedList<string> productOrder = new LinkedList<string>();
        private SortedDictionary<string, double> sortedProducts = new SortedDictionary<string, double>();

        public void AddProduct(string product, double price)
        {
            if (!productPrices.ContainsKey(product))
            {
                productPrices[product] = price;
                sortedProducts[product] = price;
                productOrder.AddLast(product);
            }
        }

        public void DisplayCart()
        {
            Console.WriteLine("Shopping Cart (Order of Addition):");
            foreach (var product in productOrder)
            {
                Console.WriteLine($"{product}: ${productPrices[product]:F2}");
            }
        }

        public void DisplaySortedCart()
        {
            Console.WriteLine("Shopping Cart (Sorted by Price):");
            foreach (var product in sortedProducts.OrderBy(p => p.Value))
            {
                Console.WriteLine($"{product.Key}: ${product.Value:F2}");
            }
        }

        public static void Main3()
        {
            ShoppingCart cart = new ShoppingCart();

            cart.AddProduct("Laptop", 999.99);
            cart.AddProduct("Phone", 699.99);
            cart.AddProduct("Tablet", 499.99);
            cart.AddProduct("Headphones", 199.99);

            cart.DisplayCart();
            Console.WriteLine();
            cart.DisplaySortedCart();
        }
    }

}
