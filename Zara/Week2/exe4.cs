using System;

namespace exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            //int result = x + y;
            //+ addition
            Console.WriteLine("the result of x+y operation is"+(x+y));
            //- subtraction
            Console.WriteLine("the result of x+y operation is" + (x + y));
            //* multiplication
            Console.WriteLine("the result of x+y operation is" + (x + y));
            // /division
            Console.WriteLine("the result of x+y operation is" + (x + y));
            // % modulus
            Console.WriteLine("the result of x+y operation is" + (x + y));
            Console.WriteLine("********************************************");
            x = 7;
             y = 4;
            Console.WriteLine(" the result of x/y ="+(x/y));
            Console.WriteLine(" the result of (float)x/y =" + (float)x / y);
            Console.WriteLine(" the result of x/(float)y =" + (x / y));
            Console.WriteLine(" the result of (float)x/(float)y =" + (x / y));
            int a = 5;
            int b = 4;
            a++;    //a +=1;
            b++;    // b +=1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a--;
            b--;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            /*Console.WriteLine("the decremente a of is: " + (a--));
            Console.WriteLine("the decremente b of is: " + (b--));*/
            Console.WriteLine("********************************************");

            int z = 1;
            int v = 3;

            z += 5;  //z = z+5;
            Console.WriteLine("Z is: "+z);
            v -= 2;  //v = v-2;
            //*, /, %

        }
    }
}
