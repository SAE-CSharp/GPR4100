using System;

namespace MCarpenter_Wk3_Ex3
{
    class Program
    {
        enum metal {Cu = 231, Au = 400, Fe = 8, Mg = 106, Zn = 75};

        static void Main(string[] args)
        {
            Console.WriteLine("Available colours:\n  [1] Blue\n  [2] Orange\n  [3] Purple\n  [4] Red\nPlease select a colour:");
            int colourSel = Int32.Parse(Console.ReadLine());

            if (colourSel == 2 || colourSel == 4)
            {
                Console.WriteLine("\nYou have selected a warm colour");
            }
            else if (colourSel == 1 || colourSel == 3)
            {
                Console.WriteLine("\nYou have selected a cold colour");
            }
            else
            {
                Console.WriteLine("\nYou have not selected a valid option");
            }

        select:
            bool metalChecked = false;
            Console.WriteLine("\nAvailable metals:\n  - Copper\n  - Gold\n  - Iron\n  - Magnesium\n  - Zinc\nPlease select a metal:");
            string metalSel = Console.ReadLine();

            if (metalSel == "Copper" || metalSel == "Gold" || metalSel == "Iron" || metalSel == "Magnesium" || metalSel == "Zinc")
            {
                metalChecked = true;
            }
            else
            {
                metalChecked = false;
            }
            
            if (!metalChecked)
            {
                Console.WriteLine("\nError: invalid selection");
                goto select;
            }
            
            Console.WriteLine("\nPlease enter a quantity in kg:");
            float metalQty = float.Parse(Console.ReadLine());

            int metalCost = 0;
            if (metalSel == "Copper")
            {
                metalCost = (int)metal.Cu;
            }
            else if (metalSel == "Gold")
            {
                metalCost = (int)metal.Au;
            }
            else if (metalSel == "Iron")
            {
                metalCost = (int)metal.Fe;
            }
            else if (metalSel == "Magnesium")
            {
                metalCost = (int)metal.Mg;
            }
            else if (metalSel == "Zinc")
            {
                metalCost = (int)metal.Zn;
            }
            else
            {

            }

            Console.WriteLine("\n" + metalSel + " currently costs £" + metalCost + " per kg.");
            Console.WriteLine(metalQty + "kg of " + metalSel + " would cost £" + ((float)metalCost * metalQty) + ".");

            Console.WriteLine("\n");
        }
    }
}
