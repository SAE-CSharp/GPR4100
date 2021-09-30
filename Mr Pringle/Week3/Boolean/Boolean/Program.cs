using System;

namespace Boolean
{
    class Program
    {
        enum Materials { Gold=500, Silver=200, Copper=100, Bronze=50};
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Marketplace, what material are you looking for?\nGold\nSilver\nCopper\nBronze\n");
            string materialSelection = Console.ReadLine();
            Console.WriteLine("How much " + materialSelection+" would you like?");
            int materialAmount = Convert.ToInt32(Console.ReadLine());
            bool materialChecked = false;

            if (!materialChecked)
            {
                //materialChecked is now True with the NOT statment in the if statment

                if (materialSelection == "Gold")
                {
                    int eveMaterial = (int)Materials.Gold;
                    Console.WriteLine("Gold is currently valued at " + eveMaterial);
                    Console.WriteLine("That will be £" + (int)Materials.Gold * materialAmount + " for " + materialAmount + " Grams");
                }
                else if (materialSelection == "Silver")
                {
                    int eveMaterial = (int)Materials.Silver;
                    Console.WriteLine("Silver is currently valued at " + eveMaterial);
                    Console.WriteLine("That will bes £" + (int)Materials.Silver * materialAmount + " for " + materialAmount + " Grams");
                }
                else if (materialSelection == "Copper")
                {
                    int eveMaterial = (int)Materials.Copper;
                    Console.WriteLine("Copper is currently valued at " + eveMaterial);
                    Console.WriteLine("That will be £" + (int)Materials.Copper * materialAmount + " for " + materialAmount + " Kilograms");
                }
                else if (materialSelection == "Bronze")
                {
                    int eveMaterial = (int)Materials.Bronze;
                    Console.WriteLine("Bronze is currently valued at " + eveMaterial);
                    Console.WriteLine("That will be £" + (int)Materials.Bronze * materialAmount + " for " + materialAmount + " Kilograms");
                }
                else
                {
                    Console.WriteLine("Sorry mate you forgot to check you're material, go back and do it right this time!");
                }

            }
        }
    }
}
