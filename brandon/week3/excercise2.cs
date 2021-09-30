using System;

namespace week3_excercise_2
{
    class Program
    {
        enum Materials {GOLD = 500, SILVER = 200, BRONZE = 100, COPPER = 50};
        static void Main(string[] args)
        {
            // Booleans
            bool MaterialChosen = false;
            bool MaterialChecked = false;
                Console.WriteLine("What're you buying");
                string MaterialChoice = Console.ReadLine();
                Console.WriteLine("enter the quantity");
                int Quantity = Int32.Parse(Console.ReadLine());

                if (!MaterialChecked)
                {
                    if (MaterialChoice == "gold")
                    {
                        int Evalue = (int)Materials.GOLD;
                        Console.WriteLine("that is worth " + Evalue + " individually");
                        int Value = (int)Materials.GOLD * Quantity;
                        Console.WriteLine(Quantity + " pieces of " + MaterialChoice + " will be " + Value);
                        MaterialChosen = true;

                    }
                    else if (MaterialChoice == "silver")
                    {
                        int Evalue = (int)Materials.SILVER;
                        Console.WriteLine("that is worth " + Evalue + " individually");
                        int Value = (int)Materials.SILVER * Quantity;
                        Console.WriteLine(Quantity + " pieces of " + MaterialChoice + " will be " + Value);
                        MaterialChosen = true;
                    }
                    else if (MaterialChoice == "bronze")
                    {
                        int Evalue = (int)Materials.BRONZE;
                        Console.WriteLine("that is worth " + Evalue + " individually");
                        int Value = (int)Materials.BRONZE * Quantity;
                        Console.WriteLine(Quantity + " pieces of " + MaterialChoice + " will be " + Value);
                        MaterialChosen = true;
                    }
                    else if (MaterialChoice == "copper")
                    {
                        int Evalue = (int)Materials.COPPER;
                        Console.WriteLine("that is worth " + Evalue + " individually");
                        int Value = (int)Materials.COPPER * Quantity;
                        Console.WriteLine(Quantity + " pieces of " + MaterialChoice + " will be " + Value);
                        MaterialChosen = true;
                    }

                    else
                    {
                        Console.WriteLine("you have to select a material");
                    }
                }
        }
    }
}
