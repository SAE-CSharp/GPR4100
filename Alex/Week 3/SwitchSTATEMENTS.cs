 class Program
    {
        enum Colour { Black=1, Red=2, Green=3, Blue=4, Purple=5, Yellow=6, Pink=7, Turquoise=8, Magenta=9, White=10 }
        static void Main(string[] args)
        {
           
         

            Console.WriteLine("Please enter a colour from the following");
            Console.WriteLine("A or 1 = Black");
            Console.WriteLine("B or 2 = Red");
            Console.WriteLine("C or 3 = Green");
            Console.WriteLine("D or 4 = Blue");
            Console.WriteLine("E or 5 = Purple");
            Console.WriteLine("F or 6 = Yellow");
            Console.WriteLine("G or 7 = Pink");
            Console.WriteLine("H or 8 = Turquoise");
            Console.WriteLine("I or 9 = Magenta");
            Console.WriteLine("J or 10 = White");
            int color = Int32.Parse(Console.ReadLine());


            switch (color)
            {
                case (int)Colour.Black: //Value = 1
                    Console.WriteLine("Black colour");
                    break;
                case (int)Colour.Red: //Value = 2
                    Console.WriteLine("Red colour");
                    break;
                case (int)Colour.Green: //Value = 3
                    Console.WriteLine("Green colour");
                    break;
                case (int)Colour.Blue: //Value = 4
                    Console.WriteLine("blue colour");
                    break;
                case (int)Colour.Purple: //Value = 5
                    Console.WriteLine("Purple colour");
                    break;
                case (int)Colour.Yellow: //Value = 6
                    Console.WriteLine("Yellow colour");
                    break;
                case (int)Colour.Pink: //Value = 7
                    Console.WriteLine("Pink colour");
                    break;
                case (int)Colour.Turquoise: //Value = 8
                    Console.WriteLine("Turquoise colour");
                    break;
                case (int)Colour.Magenta: //Value = 9
                    Console.WriteLine("Megenta colour");
                    break;
                case (int)Colour.White: //Value = 10
                    Console.WriteLine("White colour");
                    break;


                default:
                    Console.WriteLine("Unknown colour");
                    break;
            }
            
            char colour;
            
            colour = char.Parse(Console.ReadLine());

            switch (colour)
            {
                case 'A': //Value = 1
                    Console.WriteLine("Black colour");
                    break;
                case 'B': //Value = 2
                    Console.WriteLine("Red colour");
                    break;
                case 'C': //Value = 3
                    Console.WriteLine("Green colour");
                    break;
                case 'D': //Value = 4
                    Console.WriteLine("blue colour");
                    break;
                case 'E': //Value = 5
                    Console.WriteLine("Purple colour");
                    break;
                case 'F': //Value = 6
                    Console.WriteLine("Yellow colour");
                    break;
                case 'G': //Value = 7
                    Console.WriteLine("Pink colour");
                    break;
                case 'H': //Value = 8
                    Console.WriteLine("Turquoise colour");
                    break;
                case 'I': //Value = 9
                    Console.WriteLine("Megenta colour");
                    break;
                case 'J': //Value = 10
                    Console.WriteLine("White colour");
                    break;


                default:
                    Console.WriteLine("Unknown colour");
                    break;

        }
    }
    }
}
