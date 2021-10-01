using System;

namespace MCarpenter_Wk3_Ex4
{
    class Program
    {
        enum colours {Red = 1, Green = 5, Blue = 7, Yellow = 10, Purple = 17, Orange = 19};
        
        static void Main(string[] args)
        {
            Console.WriteLine("Available colours:\n  [1] Blue\n  [2] Green\n  [3] Orange\n  [4] Purple\n  [5] Red\n  [6] Yellow\nPlease select a colour:");
            int colourSel = Int32.Parse(Console.ReadLine());

            switch (colourSel)
            {
                case 1:
                    Console.WriteLine("\nYou have selected Blue. The ID of Blue is " + (int)colours.Blue + ".");
                    break;

                case 2:
                    Console.WriteLine("\nYou have selected Green. The ID of Green is " + (int)colours.Green + ".");
                    break;

                case 3:
                    Console.WriteLine("\nYou have selected Orange. The ID of Orange is " + (int)colours.Orange + ".");
                    break;

                case 4:
                    Console.WriteLine("\nYou have selected Purple. The ID of Purple is " + (int)colours.Purple + ".");
                    break;

                case 5:
                    Console.WriteLine("\nYou have selected Red. The ID of Red is " + (int)colours.Red + ".");
                    break;

                case 6:
                    Console.WriteLine("\nYou have selected Yellow. The ID of Yellow is " + (int)colours.Yellow + ".");
                    break;


                default:
                    Console.WriteLine("\nYou have not selected a valid colour.");
                    break;
            }



            Console.WriteLine("\n");
        }
    }
}
