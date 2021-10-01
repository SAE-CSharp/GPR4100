using System;

namespace Colours
{
    class Program
    {
        enum metal { zinc = 15, iron = 18, copper = 20, gold = 40 }
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your Favourite Colour: \n1. Red\n2. Blue\n3. Green\n4.Orange\n5.Yellow");

            //int colours = Int32.Parse(Console.ReadLine());
            //if (colours == 1 || colours == 2)
            //{
            //    Console.WriteLine("Wow. This is my favourite Colour!");

            //}

            //else
            //{
            //    Console.WriteLine(" I like Purple, your favourite colour doesnt matter to me.");
            //}

            Console.WriteLine("Values of each metal are:");

            int zinc = (int)metal.zinc;
            int iron = (int)metal.iron;
            int copper = (int)metal.copper;
            int gold = (int)metal.gold;
            Console.WriteLine("********************************************************************************************************************");

            Console.WriteLine("1 Zinc = $" + zinc);
            Console.WriteLine("1 Iron = $" + iron);
            Console.WriteLine("1 Copper = $" + copper);
            Console.WriteLine("1 Gold = $" + gold);

            bool materialChecked = false;
            float balance = 1500f;

          
            Console.WriteLine("********************************************************************************************************************");
            if (materialChecked == false)
            {
                Console.WriteLine("Welcome to the Console Marketplace.\nPlease select the material you want (zinc, iron, copper, gold):");
            Console.WriteLine("Your current balance is $" + balance);
            string material = Console.ReadLine();
            Console.WriteLine("How many would you like to get?");
            int quantity = Int32.Parse(Console.ReadLine());


                if (material == "zinc")
                {
                    int offer = (int)metal.zinc * quantity;
                    Console.WriteLine("my offer is $" + offer);
                    Console.WriteLine("Would you like you purchase? (yes, no)");
                    string purchase = Console.ReadLine();
                    if (purchase == "yes" && balance >= offer)
                    {
                        Console.WriteLine("Here you go, thank you for buying from us!");
                        Console.WriteLine("Your new balance is; $" + (balance - offer));

                    }

                    else if (purchase == "no" && balance >= offer)
                    {
                        Console.WriteLine("Sorry, Come again");
                        Console.WriteLine("Your balance is; $" + (balance));
                    }

                    else
                    {
                        Console.WriteLine("Sorry either you failed to input correct statements or not enough balance.");
                    }
                }

                else if (material == "iron")
                {
                    int offer = (int)metal.iron * quantity;
                    Console.WriteLine("my offer is $" + offer);
                    Console.WriteLine("Would you like you purchase? (yes, no)");
                    string purchase = Console.ReadLine();
                    if (purchase == "yes" && balance >= offer)
                    {
                        Console.WriteLine("Here you go, thank you for buying from us!");
                        Console.WriteLine("Your new balance is; $" + (balance - offer));

                    }

                    else if (purchase == "no" && balance >= offer)
                    {
                        Console.WriteLine("Sorry, Come again");
                        Console.WriteLine("Your balance is; $" + (balance));
                    }

                    else
                    {
                        Console.WriteLine("Sorry either you failed to input correct statements or not enough balance.");
                    }
                }

                else if (material == "copper")
                {
                    int offer = (int)metal.zinc * quantity;
                    Console.WriteLine("my offer is $" + offer);
                    Console.WriteLine("Would you like you purchase? (yes, no)");
                    string purchase = Console.ReadLine();
                    if (purchase == "yes" && balance >= offer)
                    {
                        Console.WriteLine("Here you go, thank you for buying from us!");
                        Console.WriteLine("Your new balance is; $" + (balance - offer));

                    }

                    else if (purchase == "no" && balance >= offer)
                    {
                        Console.WriteLine("Sorry, Come again");
                        Console.WriteLine("Your balance is; $" + (balance));
                    }

                    else
                    {
                        Console.WriteLine("Sorry either you failed to input correct statements or not enough balance.");
                    }
                }

                else if (material == "gold")
                {
                    int offer = (int)metal.gold * quantity;
                    Console.WriteLine("my offer is $" + offer);
                    Console.WriteLine("Would you like you purchase? (yes, no)");
                    string purchase = Console.ReadLine();
                    if (purchase == "yes" && balance >= offer)
                    {
                        Console.WriteLine("Here you go, thank you for buying from us!");
                        Console.WriteLine("Your new balance is; $" + (balance - offer));

                    }

                    else if (purchase == "no" && balance >= offer)
                    {
                        Console.WriteLine("Sorry, Come again");
                        Console.WriteLine("Your balance is; $" + (balance));
                    }

                    else
                    {
                        Console.WriteLine("Sorry either you failed to input correct statements or not enough balance.");
                    }
                }

                else
                {
                    Console.WriteLine("Sorry we don't sell that material at this time. Coma back soon!");
                }

            }

            else
            {
                Console.WriteLine("Shop Closed, No Materials Available");

            }
        }
    }
}
