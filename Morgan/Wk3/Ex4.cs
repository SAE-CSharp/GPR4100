using System;

namespace MCarpenter_Wk3_Ex4
{
    class Program
    {
        enum colours {Red, Green, Blue, Yellow, Purple, Orange};
        
        static void Main(string[] args)
        {
            Console.WriteLine("Available colours:\n  [B] Blue\n  [G] Green\n  [O] Orange\n  [P] Purple\n  [R] Red\n  [Y] Yellow\nPlease select a colour:");
            char colourSel = Char.Parse(Console.ReadLine());

            switch (colourSel)
            {
                case 'B':
                    Console.WriteLine("\nYou have selected Blue. The ID of Blue is " + (int)colours.Blue + ".");
                    break;

                case 'G':
                    Console.WriteLine("\nYou have selected Green. The ID of Green is " + (int)colours.Green + ".");
                    break;

                case 'O':
                    Console.WriteLine("\nYou have selected Orange. The ID of Orange is " + (int)colours.Orange + ".");
                    break;

                case 'P':
                    Console.WriteLine("\nYou have selected Purple. The ID of Purple is " + (int)colours.Purple + ".");
                    break;

                case 'R':
                    Console.WriteLine("\nYou have selected Red. The ID of Red is " + (int)colours.Red + ".");
                    break;

                case 'Y':
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
