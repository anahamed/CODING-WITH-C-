internal class Program
{
    private static void Main(string[] args)
    {
        string[] main_list = { "1. Fast food.", "2. Candies.", "3. Cold drinks.", "4. Hot drinks." };
        int Choice, total = 0, index = 0;
        string[] selector = { "Shawarma", "Pizza", "Burger", "Cake", "Cookies", "Cheesecake", "Lemonade", "Apple juice", "Banana juice", "Orange juice", "Coffee", "Tea" };
        int[] selector_counter = new int[selector.Length];
        int[] price = { 3, 5, 4, 5, 3, 4, 4, 4, 4, 4, 3, 2 };

        string[] select_meals = new string[3];
        int[] selector_counter_meals = new int[3];
        int[] price_meals = new int[3];
        cutter(selector, selector_counter, price, select_meals, selector_counter_meals, price_meals, index);

        string[] select_cakes = new string[3];
        int[] selector_counter_cakes = new int[3];
        int[] price_cakes = new int[3];
        cutter(selector, selector_counter, price, select_cakes, selector_counter_cakes, price_cakes, index + 3);

        string[] select_coldDrinks = new string[4];
        int[] selector_counter_coldDrinks = new int[4];
        int[] price_coldDrinks = new int[4];
        cutter(selector, selector_counter, price, select_coldDrinks, selector_counter_coldDrinks, price_coldDrinks, index + 6);

        string[] select_hotDrinks = new string[2];
        int[] selector_counter_hotDrinks = new int[2];
        int[] price_hotDrinks = new int[2];
        cutter(selector, selector_counter, price, select_hotDrinks, selector_counter_hotDrinks, price_hotDrinks, index + 10);

        for (int i = 1; i != 0; i = Choice)
        {
            Console.WriteLine("Welcome to Ahmed Fast Food & Café.");
            Console.WriteLine("Enter a number (1-4) to show the menu or (0) to exit.");
            for (int j = 0; j < main_list.Length; j++)
                Console.WriteLine(main_list[j]);

            Choice = int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    selected(select_meals, selector_counter_meals, price_meals, main_list[0]);
                    break;
                case 2:
                    selected(select_cakes, selector_counter_cakes, price_cakes, main_list[1]);
                    break;
                case 3:
                    selected(select_coldDrinks, selector_counter_coldDrinks, price_coldDrinks, main_list[2]);
                    break;
                case 4:
                    selected(select_hotDrinks, selector_counter_hotDrinks, price_hotDrinks, main_list[3]);
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
        merger(selector_counter, selector_counter_meals, selector_counter_cakes, selector_counter_coldDrinks, selector_counter_hotDrinks);
        testing(selector, selector_counter, price, ref total);

        double discount = total;
        if (total >= 100)
        {
            Console.WriteLine("Congratulations! You have received a 15% discount because your total exceeds $100.");
            discount = discount - ((total * 15) / 100);
            Console.WriteLine($"The total of your order is: [{total}$], and after the discount: [{discount}$]");
        }
        else
        {
            Console.WriteLine($"The total of your order is: [{total}$]");
        }
    }

    public static void cutter(string[] selector, int[] selector_counter, int[] price, string[] selector1, int[] selector_counter1, int[] price1, int index)
    {
        for (int x = 0; x < selector1.Length; x++)
        {
            selector1[x] = selector[x + index];
            selector_counter1[x] = selector_counter[x + index];
            price1[x] = price[x + index];
        }
    }

    public static void merger(int[] selector_counter, int[] selector_counter1, int[] selector_counter2, int[] selector_counter3, int[] selector_counter4)
    {
        for (int x = 0; x < selector_counter.Length; x++)
        {
            if (x < 3)
                selector_counter[x] = selector_counter1[x];
            if (x >= 3 && x < 6)
                selector_counter[x] = selector_counter2[x - 3];
            if (x >= 6 && x < 10)
                selector_counter[x] = selector_counter3[x - 6];
            if (x >= 10 && x < 12)
                selector_counter[x] = selector_counter4[x - 10];
        }
    }

    public static void selected(string[] selector1, int[] selector_counter1, int[] price1, string name)
    {
        Console.WriteLine($"Now, you are in the \n{name} list.");
        int choice = 1;
        do
        {
            Console.WriteLine($"Enter your choice (1-{selector1.Length}) or (0) to go back:");
            for (int x = 0; x < selector1.Length; x++)
            {
                Console.WriteLine($"{x + 1}. {selector1[x]}  \t  ({price1[x]}$)");
            }

            choice = int.Parse(Console.ReadLine());
            if (choice == 0)
                return;
            else
            {
                if (choice > selector1.Length || choice < 0)
                    Console.WriteLine($"{choice}: Invalid input. Please try again.");
                else
                {
                    Console.WriteLine($"Enter the quantity of {selector1[choice - 1]}:");
                    selector_counter1[choice - 1] = int.Parse(Console.ReadLine());
                    Console.WriteLine("It was added to your order.\n");
                }
            }
        } while (choice != 0);
    }

    public static void testing(string[] selector1, int[] selector_counter, int[] price1, ref int total1)
    {
        for (int i = 0; i < selector_counter.Length; i++)
        {
            if (selector_counter[i] > 0)
            {
                Console.WriteLine($"You have selected ({selector_counter[i]}) {selector1[i]} ({price1[i] * selector_counter[i]}$).");
                total1 += price1[i] * selector_counter[i];
            }
        }
    }
}
