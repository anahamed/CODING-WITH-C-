using System;

internal class Program
{
    static string[] fastFoodItems = { "Shawarma", "Pizza", "Burger" };
    static string[] candyItems = { "Cake", "Cookies", "Cheesecake" };
    static string[] coldDrinks = { "Orange juice", "Banana juice", "Apple juice", "Lemonade" };
    static string[] hotDrinks = { "Coffee", "Tea" };

    static int[] fastFoodOrders = new int[3];
    static int[] candyOrders = new int[3];
    static int[] coldDrinkOrders = new int[4];
    static int[] hotDrinkOrders = new int[2];

    static int total = 0;

    private static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Welcome to Ahmed Fast Food & Café.");
            Console.WriteLine("Enter number (1-4) to show the menu or (0) to exit.");
            Console.WriteLine("1. Fast Food\n2. Candies\n3. Cold Drinks\n4. Hot Drinks");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    HandleMenu(fastFoodItems, fastFoodOrders, 5, "meal");
                    break;
                case 2:
                    HandleMenu(candyItems, candyOrders, 5, "candy");
                    break;
                case 3:
                    HandleMenu(coldDrinks, coldDrinkOrders, 3, "drink");
                    break;
                case 4:
                    HandleMenu(hotDrinks, hotDrinkOrders, new int[] { 2, 1 }, "hot drink");
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }

        } while (choice != 0);

        DisplayInvoice();
    }

    static void HandleMenu(string[] items, int[] orders, int price, string type)
    {
        for (; ; )
        {
            Console.WriteLine($"Select a {type} (1-{items.Length}) or any other number to exit.");
            for (int i = 0; i < items.Length; i++)
                Console.WriteLine($"{i + 1}. {items[i]} ........{price}$");

            int input = int.Parse(Console.ReadLine());
            if (input < 1 || input > items.Length)
                break;

            Console.WriteLine($"Enter quantity of {items[input - 1]}:");
            int qty = int.Parse(Console.ReadLine());
            orders[input - 1] += qty;
            total += qty * price;
        }
    }

    static void HandleMenu(string[] items, int[] orders, int[] prices, string type)
    {
        for (; ; )
        {
            Console.WriteLine($"Select a {type} (1-{items.Length}) or any other number to exit.");
            for (int i = 0; i < items.Length; i++)
                Console.WriteLine($"{i + 1}. {items[i]} ........{prices[i]}$");

            int input = int.Parse(Console.ReadLine());
            if (input < 1 || input > items.Length)
                break;

            Console.WriteLine($"Enter quantity of {items[input - 1]}:");
            int qty = int.Parse(Console.ReadLine());
            orders[input - 1] += qty;
            total += qty * prices[input - 1];
        }
    }

    static void DisplayInvoice()
    {
        Console.WriteLine("\n--- Invoice ---");

        PrintOrderDetails(fastFoodItems, fastFoodOrders, 5);
        PrintOrderDetails(candyItems, candyOrders, 5);
        PrintOrderDetails(coldDrinks, coldDrinkOrders, 3);
        PrintOrderDetails(hotDrinks, hotDrinkOrders, new int[] { 2, 1 });

        Console.WriteLine($"\nTotal before discount: {total}$");

        if (total >= 100)
        {
            double discounted = total * 0.85;
            Console.WriteLine("Congratulations! You received a 15% discount.");
            Console.WriteLine($"Total after discount: {discounted}$");
        }
    }

    static void PrintOrderDetails(string[] items, int[] orders, int price)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (orders[i] > 0)
            {
                Console.WriteLine($"You selected {orders[i]} x {items[i]} = {orders[i] * price}$");
            }
        }
    }

    static void PrintOrderDetails(string[] items, int[] orders, int[] prices)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (orders[i] > 0)
            {
                Console.WriteLine($"You selected {orders[i]} x {items[i]} = {orders[i] * prices[i]}$");
            }
        }
    }
}
