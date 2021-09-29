namespace Boolean1
{
    class Program
    {
        enum Materials { Gold = 70, Iron = 50, Diamond = 100, Redstone = 30, LapisLazuli = 30, Coal = 15 }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Marketplace");
            Console.WriteLine("Gold = 70 Emeralds");
            Console.WriteLine("Iron = 50 Emeralds");
            Console.WriteLine("Diamond = 100 Emeralds");
            Console.WriteLine("Redstone = 30 Emeralds");
            Console.WriteLine("Lapis Lazuli = 30 Emeralds");
            Console.WriteLine("Coal = 15 Emeralds");
            Console.WriteLine("What would you like to purchase? (Remember all prices are Per KG)");
            string materialSelection = Console.ReadLine();
            Console.WriteLine("Please enter the ammount you wish to purchase");
            int quantity = Int32.Parse(Console.ReadLine());
            bool materialChecked = false;

            if (!materialChecked)
            {  //
                if (materialSelection == "Gold" || materialSelection == "gold")
                {
                    int GoldValue = (int)Materials.Gold;
                    Console.WriteLine("The price of 1 KG of Gold is " + GoldValue);
                    Console.WriteLine("   you want " + quantity + " KG's so");
                    Console.WriteLine("   That will be " + (int)Materials.Gold * quantity + " Emeralds please...");
                }
                else if (materialSelection == "Iron")
                {
                    int IronValue = (int)Materials.Iron;
                    Console.WriteLine("The price of 1 KG of Iron is " + IronValue);
                    Console.WriteLine("   you want " + quantity + " KG's so");
                    Console.WriteLine("   That will be " + (int)Materials.Iron * quantity + " Emeralds please...");
                }
                else if (materialSelection == "Diamond" || materialSelection == "diamond")
                {
                    int DiamondValue = (int)Materials.Diamond;
                    Console.WriteLine("The price of 1 KG of Diamond is " + DiamondValue);
                    Console.WriteLine("   you want " + quantity + " KG's so");
                    Console.WriteLine("   That will be " + (int)Materials.Diamond * quantity + " Emeralds please...");
                }
                else if (materialSelection == "Redstone" || materialSelection == "redstone")
                {
                    int RedstoneValue = (int)Materials.Redstone;
                    Console.WriteLine("The price of 1 KG of Redstone is " + RedstoneValue);
                    Console.WriteLine("   you want " + quantity + " KG's so");
                    Console.WriteLine("   That will be " + (int)Materials.Redstone * quantity + " Emeralds please...");
                }
                else if (materialSelection == "Lapis Lazuli" || materialSelection == "lapis lazuli")
                {
                    int LapisLazuliValue = (int)Materials.LapisLazuli;
                    Console.WriteLine("The price of 1 KG of Lapis Lazuli is " + LapisLazuliValue);
                    Console.WriteLine("   you want " + quantity + " KG's so");
                    Console.WriteLine("   That will be " + (int)Materials.LapisLazuli * quantity + " Emeralds please...");
                }
                else if (materialSelection == "Coal" || materialSelection == "coal")
                {
                    int CoalValue = (int)Materials.Coal;
                    Console.WriteLine("The price of 1 KG of Coal is " + CoalValue);
                    Console.WriteLine("   you want " + quantity + " KG's so");
                    Console.WriteLine("   That will be " + (int)Materials.Coal * quantity + " Emeralds please...");
                }
            }
            else
            {
                Console.WriteLine("Please enter a listed material");
            }
        }
    }
