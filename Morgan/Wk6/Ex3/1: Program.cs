using System;

namespace MCarpenter_Wk6_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // For the sake of speed and efficiency, and since I understand the
            // basics of how inheritance works, I'm just going to create some
            // abstract code for this, rather than following the specific
            // example used in class.

            Child1 cObj_1 = new Child1(4, "abc", 6.6f);
            Child2 cObj_2 = new Child2(7, "def", true);

            Console.WriteLine(">> Child 1 <<\n");
            Console.WriteLine("Common attribute 1: " + cObj_1.getCmn1() + " | " + (cObj_1.getCmn1()).GetType());
            Console.WriteLine("Common attribute 2: " + cObj_1.getCmn2() + " | " + (cObj_1.getCmn2()).GetType());
            Console.WriteLine("Specific attribute: " + cObj_1.getSpcf() + " | " + (cObj_1.getSpcf()).GetType());
            Console.WriteLine();

            Console.WriteLine(">> Child 2 <<\n");
            Console.WriteLine("Common attribute 1: " + cObj_2.getCmn1() + " | " + (cObj_2.getCmn1()).GetType());
            Console.WriteLine("Common attribute 2: " + cObj_2.getCmn2() + " | " + (cObj_2.getCmn2()).GetType());
            Console.WriteLine("Specific attribute: " + cObj_2.getSpcf() + " | " + (cObj_2.getSpcf()).GetType());
            Console.WriteLine();
        }
    }
}
