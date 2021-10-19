using System;


namespace Triangle_Homework
{
    class Program
    {
        // Declaring a method for the top of the triangle
        static void Triangle(int Start, int End)
        {
            int i, j, k, Val;

            // for loop runs until i is equal to the Number input
            for (i = 1; i <= Start; i++)
            {
                // sets the variable that is used to type numbers
                Val = 1;
                for (k = 1; k <= i; k++)
                {
                    Console.Write(Val);
                    // increases the valu so that it is increased until it reaches the input number
                    Val++;
                }
                Console.WriteLine("");

                for (i = 1; i < End; i++)
                {
                    Val = 1;
                    for (j = 1; j < End - i; j++)
                    {
                        // Console.Write(" ");  
                    }
                    for (k = 1; k <= j; k++)
                    {
                        Console.Write(Val);
                        Val++;
                    }
                    Console.WriteLine("");
                }
            }
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Set N");
            Console.Write("N = ");
            n = Convert.ToInt32(Console.ReadLine());
            Triangle(n,n);

            Console.ReadLine();
        }
    }
}
