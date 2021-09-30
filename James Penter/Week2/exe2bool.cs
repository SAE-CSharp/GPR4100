using System;

namespace Boolean
{
    class Program
    {
        enum Materials { Gold = 500, Silver = 200, Bronze = 100, Copper = 50 };
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my market");
            Console.WriteLine("Choose your material!");
            string materialSelect = Console.ReadLine();
            Console.WriteLine("Choose the quantity/Kg");
            int quantity = Int32.Parse(Console.ReadLine());
            bool materialChecked = false;
            if (materialSelect == "Gold")
                if (!materialChecked) //!=NOT
                {
                    Console.WriteLine("Your offer is... £" + (int)Materials.Gold * quantity + "\nGold is £500 per Kg, are you sure you you still want to make your offer?");
                    
                    Console.WriteLine("Thank you for your purchase");

                }
            if (materialSelect == "Silver")
            {
                Console.WriteLine("Your offer is... £" + (int)Materials.Silver * quantity + "\nSilver is £200 per Kg, are you sure you you still want to make your offer?");
                 
                Console.WriteLine("Thank you for your purchase");
            }
            if (materialSelect == "Bronze")
            {
                Console.WriteLine("Your offer is... £" + (int)Materials.Bronze * quantity + "\nBronze is £100 per Kg, are you sure you you still want to make your offer?");
                 
                Console.WriteLine("Thank you for your purchase");
            }
            if (materialSelect == "Copper")
                
            {
                Console.WriteLine("Your offer is... £" + (int)Materials.Copper * quantity + "\nCopper is £50 per Kg, are you sure you you still want to make your offer?");
                 
                Console.WriteLine("Thank you for your purchase");

            }
        } 
    }
}
