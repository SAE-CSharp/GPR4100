using System;

namespace boolean
{
    class Program
    {
        enum materials { gold = 500, silver = 200, bronze = 100, copper = 50 }

        static void Main(string[] args)
        {
            string choice, userInput = "";
            int quantity;
            bool inStock = false;

            while (inStock == false)
            {
                Console.WriteLine("Welcome to my shop. \nWhich material would you like to buy? ");
                choice = Console.ReadLine();
                choice = choice.ToLower();


                if (choice == "gold")
                {
                    inStock = true;
                    int goldValue = (int)materials.gold;
                    Console.WriteLine("Gold is £" + goldValue + " per unit. \nHow much would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("That will be £" + (int)materials.gold * quantity);
                }
                else if (choice == "silver")
                {
                    inStock = true;
                    int silverValue = (int)materials.silver;
                    Console.WriteLine("Gold is £" + silverValue + " per unit. \nHow much would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("That will be £" + (int)materials.silver * quantity);
                }
                else if (choice == "bronze")
                {
                    inStock = true;
                    int bronzeValue = (int)materials.bronze;
                    Console.WriteLine("Gold is £" + bronzeValue + " per unit. \nHow much would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("That will be £" + (int)materials.bronze * quantity);
                }
                else if (choice == "copper")
                {
                    inStock = true;
                    int copperValue = (int)materials.copper;
                    Console.WriteLine("Gold is £" + copperValue + " per unit. \nHow much would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("That will be £" + (int)materials.copper * quantity);
                }
                else
                {
                    inStock = false;
                    Console.WriteLine("I do not have that in stock. \nCould I interest you in something else?");
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();


                    if (userInput == "n" || userInput == "no")
                    {
                        inStock = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n");
                    }
                }
            }
            
        }
    }
}
