internal class Program
{
    private static void Main(string[] args)
    {
        
            int Shawrma = 0, Pizza = 0, Burger = 0, Cake = 0, Cookies = 0, Cheesecake = 0,
    Lemonade = 0, Applejuice = 0, Bananajuice = 0, Orangejuice = 0, Coffee = 0, Tea = 0, num1, num2 = 1, total = 0;
            for (int i = 1; i != 0; i = num1)
            {
                Console.WriteLine("Welcome to Ahmed Fast Food & Café .");
                Console.WriteLine("Enter number (1-4) to show the menu or (0) to esc .");
                Console.WriteLine("1. fast food.");
                Console.WriteLine("2. candies.");
                Console.WriteLine("3. cold drinks.");
                Console.WriteLine("4. hot drinks.");
                num1 = int.Parse(Console.ReadLine());
                switch (num1)
                {

                    case 1:
                        Console.WriteLine("1.Shawarma ........5$");
                        Console.WriteLine("2.Pizza    ........5$");
                        Console.WriteLine("3.Burger   ........5$");
                        for (i = 1; i < 4 && i > 0; i = num2)
                        {
                            Console.WriteLine("Enter number (1-3) to select your meal or any number to esc.");
                            num2 = int.Parse(Console.ReadLine());
                            switch (num2)
                            {
                                case 1:
                                    Console.WriteLine("Enter the number of Shawrma");
                                    Shawrma = int.Parse(Console.ReadLine());
                                    total = total + (Shawrma * 5);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the number of Pizza");
                                    Pizza = int.Parse(Console.ReadLine());
                                    total = total + (Pizza * 5);
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the number of Burger");
                                    Burger = int.Parse(Console.ReadLine());
                                    total = total + (Burger * 5);
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("1.Cake       ....... 5$");
                        Console.WriteLine("2.Cookies    ....... 5$");
                        Console.WriteLine("3.Cheesecake ....... 5$");
                        for (i = 1; i < 4 && i > 0; i = num2)
                        {
                            Console.WriteLine("Enter number (1-3) to select your Candies or any number to esc.");
                            num2 = int.Parse(Console.ReadLine());
                            switch (num2)
                            {
                                case 1:
                                    Console.WriteLine("Enter the number Cake");
                                    Cake = int.Parse(Console.ReadLine());
                                    total = total + (Cake * 5);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the number of Cookies");
                                    Cookies = int.Parse(Console.ReadLine());
                                    total = total + (Cookies * 5);
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the number of Cheesecake");
                                    Cheesecake = int.Parse(Console.ReadLine());
                                    total = total + (Cheesecake * 5);
                                    break;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("1.Orange juice .......3$");
                        Console.WriteLine("2.Banana juice .......3$");
                        Console.WriteLine("3.Apple juice  .......3$");
                        Console.WriteLine("4.Lemonade     .......3$");
                        for (i = 1; i < 5 && i > 0; i = num2)
                        {
                            Console.WriteLine("Enter number (1-4) to select your drink or any number to esc.");
                            num2 = int.Parse(Console.ReadLine());
                            switch (num2)
                            {
                                case 1:
                                    Console.WriteLine("Enter the number Orange juice");
                                    Orangejuice = int.Parse(Console.ReadLine());
                                    total = total + (Orangejuice * 3);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the number of Banana juice");
                                    Bananajuice = int.Parse(Console.ReadLine());
                                    total = total + (Bananajuice * 3);
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the number of Apple juice");
                                    Applejuice = int.Parse(Console.ReadLine());
                                    total = total + (Applejuice * 3);
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the number of Lemonade");
                                    Lemonade = int.Parse(Console.ReadLine());
                                    total = total + (Lemonade * 3);
                                    break;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("1.Coffee  .......2$");
                        Console.WriteLine("2.Tea     .......1$");
                        for (i = 1; i < 3 && i > 0; i = num2)
                        {
                            Console.WriteLine("Enter number (1-2) to select your drink or any number to esc.");
                            num2 = int.Parse(Console.ReadLine());
                            switch (num2)
                            {
                                case 1:
                                    Console.WriteLine("Enter the number Coffee");
                                    Coffee = int.Parse(Console.ReadLine());
                                    total = total + (Coffee * 2);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the number of Tea");
                                    Tea = int.Parse(Console.ReadLine());
                                    total = total + (Tea * 1);
                                    break;
                            }
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Wrong input pleas try (1-4) to show menu or (0) to esc");
                        break;
                }
            }
            if (Shawrma > 0)
                Console.WriteLine($"You have selected ({Shawrma}) Banana juice equal ({Shawrma * 5}$). ");
            if (Pizza > 0)
                Console.WriteLine($"You have selected ({Pizza}) Apple juice equal ({Pizza * 5}$). ");
            if (Burger > 0)
                Console.WriteLine($"You have selected ({Burger}) Apple juice equal ({Burger * 5}$). ");
            if (Cake > 0)
                Console.WriteLine($"You have selected ({Cake}) Apple juice equal ({Cake * 5}$).");
            if (Cookies > 0)
                Console.WriteLine($"You have selected ({Cookies}) Lemonade equal ( {Cookies * 3}$). ");
            if (Cheesecake > 0)
                Console.WriteLine($"You have selected ({Cheesecake}) Lemonade equal ({Cheesecake * 3}$). ");
            if (Orangejuice > 0)
                Console.WriteLine($"You have selected ({Orangejuice}) Orange juice equal ({Orangejuice * 3}$). ");
            if (Bananajuice > 0)
                Console.WriteLine($"You have selected ({Bananajuice}) Banana juice equal ({Bananajuice * 3}$). ");
            if (Applejuice > 0)
                Console.WriteLine($"You have selected ({Applejuice}) Apple juice equal ({Applejuice * 3}$). ");
            if (Lemonade > 0)
                Console.WriteLine($"You have selected ({Lemonade}) Lemonade equal ( {Lemonade * 3}$). ");
            if (Coffee > 0)
                Console.WriteLine($"You have selected {Coffee} Coffee equal ({Coffee * 2} $).");
            if (Tea > 0)
                Console.WriteLine($"You have selected ({Tea}) Tea equal ({Tea}$). ");

            double discount = total;
            if (total >= 100)
            {
                Console.WriteLine("Congratulations! You have received a 15 % discount because your total account balance has exceeded $100.");
                discount = discount - ((total * 15) / 100);
                Console.WriteLine($"The total of your order is : [{total}$] and after discount is [{discount}$]");
            }
            else
            {
                Console.WriteLine($"The total of your order is :   [{total}$] .");
            }
        
   
    }
}