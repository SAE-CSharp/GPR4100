using System;

namespace Methods_Functions
{
    class Program
    {
        static void Namemethod(string name, int age)    //(parameters)                              //static(modifier) = related to class not objects
        {                                                                                           //void = gives no return
            Console.WriteLine("Hello " + name + "\nI am " + age + " years old.");                   //replace void with a datatype to be able to return data from the function
        }

        static int Cube1(int x, int y)
        {
            int result;
            result = x + y;
            return result;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void Main(string[] args)                                                             //Main method
        {                                                                                           //Methods are a containers that holds a collection of code that performs particualr operations (functions)
            string name;                                                                            //Reduces repeated code, enables reusability
            int age, x, y, result;

            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("\nEnter your age:");
            age = Int32.Parse(Console.ReadLine());

            Namemethod(name, age);      //(arguements)



            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");



            Console.WriteLine("\nEnter 1st number:");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter 2nd number:");
            y = Int32.Parse(Console.ReadLine());

            result = Cube1(x, y);

            Console.WriteLine("\n" + x + " + " + y + " = " + result);
        }      
    }
}
