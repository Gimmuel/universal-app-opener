using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> shirtTypes = new List<string> { "T-Shirt", "Polo Shirt", "Button-down Shirt" };
        List<string> sizes = new List<string> { "Small", "Medium", "Large", "XL" };

        Console.WriteLine("Welcome to the Uniform Shop!");

        bool continueShopping = true;

        while (continueShopping)
        {
            Console.WriteLine("\nAvailable Shirt Types:");
            for (int i = 0; i < shirtTypes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {shirtTypes[i]}");
            }
            Console.WriteLine("Available Sizes:");
            for (int i = 0; i < sizes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sizes[i]}");
            }

            Console.Write("\nEnter the number corresponding to the shirt type: ");
            int shirtTypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("Enter the number corresponding to the size: ");
            int sizeIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if (shirtTypeIndex < 0 || shirtTypeIndex >= shirtTypes.Count || sizeIndex < 0 || sizeIndex >= sizes.Count)
            {
                Console.WriteLine("Invalid selection. Please try again.");
                continue;
            }

            string selectedShirtType = shirtTypes[shirtTypeIndex];
            string selectedSize = sizes[sizeIndex];
            double price = 20.00;

            Console.WriteLine("\nOrder Summary:");
            Console.WriteLine("---------------");
            Console.WriteLine($"Shirt Type: {selectedShirtType}");
            Console.WriteLine($"Size: {selectedSize}");
            Console.WriteLine($"Price: ${price}");

            Console.WriteLine("\nPayment Options:");
            Console.WriteLine("Cash");

            Console.Write("Enter the amount in cash: ");
            double cashAmount = Convert.ToDouble(Console.ReadLine());

            if (cashAmount < price)
            {
                Console.WriteLine("Insufficient cash amount. Please try again.");
                continue;
            }

            double change = cashAmount - price;

            Console.WriteLine($"Payment successful! Change: ${change:F2}. Your order has been placed.");

            Console.WriteLine("\nDo you want to place another order? (yes/no)");
            string answer = Console.ReadLine().ToLower();

            if (answer != "yes")
                continueShopping = false;
        }

        Console.WriteLine("\nThank you for shopping with us!");
    }
}