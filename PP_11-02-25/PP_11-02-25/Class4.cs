using System;

namespace PP_11_02_25
{
    class Item
    {
        public int ItemID;
        public string ItemName;
        public int Quantity;
        public double Price;
        public Item Next;

        public Item(int itemID, string itemName, int quantity, double price)
        {
            ItemID = itemID;
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
        }
    }

    class Class4
    {
        private Item head;

        public void AddItemAtBeginning(int itemID, string itemName, int quantity, double price)
        {
            Item newItem = new Item(itemID, itemName, quantity, price);

            if (head == null)
            {
                head = newItem;
                return;
            }

            newItem.Next = head;
            head = newItem;
        }

        public void AddItemAtEnd(int itemID, string itemName, int quantity, double price)
        {
            Item newItem = new Item(itemID, itemName, quantity, price);
            if (head == null)
            {
                head = newItem;
                return;
            }
            Item temp = head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = newItem;
        }

        public void RemoveItem(int itemID)
        {
            if (head == null)
            {
                Console.WriteLine("no item found");
                return;
            }
            Item temp = head;

            while (temp.Next != null)
            {
                if (temp.Next.ItemID == itemID)
                {
                    temp.Next = temp.Next.Next;
                    Console.WriteLine("item deleted ");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found");
        }

        public void UpdateQuantity(int itemID, int quantity)
        {
            Item temp = head;
            while (temp != null)
            {
                if (temp.ItemID == itemID)
                {
                    temp.Quantity = quantity;
                    return;
                }
                temp = temp.Next;
            }
        }

        public void SearchItem(int itemID)
        {
            Item temp = head;
            while (temp != null)
            {
                if (temp.ItemID == itemID)
                {
                    Console.WriteLine($"Item Found: {temp.ItemName}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found");
        }

        public double CalculateTotalValue()
        {
            double totalValue = 0;
            Item temp = head;
            while (temp != null)
            {
                totalValue += temp.Quantity * temp.Price;
                temp = temp.Next;
            }
            return totalValue;
        }

        public void DisplayInventory()
        {
            Item temp = head;
            while (temp != null)
            {
                Console.Write($"{temp.ItemName}->");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public static void Main4()
        {
            Class4 inventory = new Class4();
            inventory.AddItemAtBeginning(1, "Laptop", 10, 1000);
            inventory.AddItemAtEnd(2, "Mouse", 50, 20);
            inventory.AddItemAtEnd(3, "Keyboard", 30, 50);

            Console.WriteLine("Inventory:");
            inventory.DisplayInventory();

            Console.WriteLine("\nTotal Inventory Value: " + inventory.CalculateTotalValue());

            Console.WriteLine("\nSearching for Item ID 2:");
            inventory.SearchItem(2);

            Console.WriteLine("\nUpdating Quantity of Item ID 1 to 5:");
            inventory.UpdateQuantity(1, 5);
            inventory.DisplayInventory();

            Console.WriteLine("\nRemoving Item ID 3:");
            inventory.RemoveItem(3);
            inventory.DisplayInventory();
        }
    }
}
