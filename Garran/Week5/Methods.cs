using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[4] { 4, 8, 2, 6 };
            printarray(array1);

            string[] myArray = new string[3] { "tom", "Fred", "Chris" };
            printStringArray(myArray);
          
            SayHello("Tom", 20); // Argument
           /* SayHello("Alex", 25);
            SayHello("Lee", 23);
            SayHello("Jan", 27);
            SayHello("Dan", 22);
            SayHello("Fred", 19);*/
            Sae();
            GetInfo();
            AddTwoNumbers(3, 5);
            int z = AddTwoNumber(5, 8);
            int a = z + 15;
            int A = square(12);
            Console.WriteLine("a = " + A);
            int B = square(A * 2);
            Console.WriteLine("B = " + A);
            int C = square(B * A);
            Console.WriteLine("C = " + C);

        }
        static void SayHello(string name, int age) // Parameter
        {
            Console.WriteLine("Hello " + name + " your age is " + age);
        }
        static void Sae()
        {
            Console.WriteLine("Hello SAE");
        }
        static void GetInfo()
        {
            Console.WriteLine("Enter your name");
            string name = (Console.ReadLine());
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name + " your age is " + age);
        }
        static void AddTwoNumbers(int x, int y)
        {
            int z = x + y;
            Console.WriteLine(" the result of adding x + y is: " + z);
        }
        static int AddTwoNumber(int x, int y)
        {
            int z = x + y;
            return z;
        }
        static int square(int x)
        {
            int i = x * x; //

            return i; //Return x*x

        }

        static void printarray(int[] newarray)
        {
            for(int i=0; i<newarray.Length; i++)
            {
                Console.WriteLine(" the array element is " + newarray[i]);
            }
        }
        static void printStringArray(string [] stringArray)
        {
            for(int i=0; i < stringArray.Length; i++)
            {
                Console.WriteLine(" the array element is " + stringArray[i]);
            }
        }

       // Create a method to pass a string array as q parameter of your method
      
    }
}
