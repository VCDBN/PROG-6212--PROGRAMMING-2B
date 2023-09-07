using System;
using System.Collections.Generic;

public class ShoppingCart
{
    private Dictionary<string, double> itemPrices = new Dictionary<string, double>();

    // Indexer to get or set the price of items in the cart by item name
    public double this[string itemName]
    {
        get
        {
            if (itemPrices.TryGetValue(itemName, out double price))
                return price;
            return 0;
        }
        set { itemPrices[itemName] = value; }
    }

    // Method to calculate the total price based on the quantity and apply discounts if applicable
    public double CalculateTotalPrice(string itemName, int quantity)
    {
        if (!itemPrices.ContainsKey(itemName))
        {
            Console.WriteLine("Item not found in the cart.");
            return 0;
        }

        double itemPrice = itemPrices[itemName];
        double totalPrice = itemPrice * quantity;

        // Apply discount if quantity is greater than 10
        if (quantity > 10)
        {
            totalPrice *= 0.9; // 10% discount
        }

        return totalPrice;
    }

    // Method to update the price of an item
    public void UpdateItemPrice(string itemName)
    {
        if (!itemPrices.ContainsKey(itemName))
        {
            Console.WriteLine("Item not found in the cart. Cannot update price.");
            Environment.Exit(0);
          
            
        }

        Console.Write($"Enter the new price for {itemName}: ");
        double newPrice = double.Parse(Console.ReadLine());
        this[itemName] = newPrice;
    }
}

public class Program
{
    public static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        // Adding items and their prices to the cart using the indexer
        cart["apple"] = 2.5;
        cart["banana"] = 3.75;
        cart["orange"] = 2.0;

        // Retrieving the prices of items from the cart using the indexer
        Console.WriteLine("Price of apples: R" + cart["apple"]);
        Console.WriteLine("Price of bananas: R" + cart["banana"]);
        Console.WriteLine("Price of oranges: R" + cart["orange"]);

        Console.WriteLine("Available items: apple, banana, orange");
        Console.Write("Enter the item you want to purchase: ");
        string selectedItem = Console.ReadLine().ToLower();

        // Prompt the user to buy an item
        Console.Write("Enter the quantity you want to buy: ");
        int quantity = int.Parse(Console.ReadLine());

        double totalPrice = cart.CalculateTotalPrice(selectedItem, quantity);
        Console.WriteLine($"Total price: R{totalPrice}");

        // Prompt the user to update the price of an item
        Console.Write("Enter the item for which you want to update the price: ");
        string itemToUpdate = Console.ReadLine().ToLower();
        cart.UpdateItemPrice(itemToUpdate);

        // Display the updated price
        Console.WriteLine($"Updated price of {itemToUpdate}: R{cart[itemToUpdate]}");
    }
}
