using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            sayHello("Jessica",1);                          // this is the method called with two arguments
            Console.WriteLine("Liverpool? Y/N");
            string liverpool = Console.ReadLine();
            if (liverpool == "Y") { saySAE(); }
            nameAge();

            Cube1();


        }

        static void sayHello(string name, int num)          // two paramiters in sayHello method, one string the other int
        {
            Console.WriteLine("Sup "+name+"\t"+num);        ////name and num are declared in the method so they have to be be defined on line 10
        }

        static void saySAE()
        {
            Console.WriteLine("Hello SAE Liverpool");
        }
        static void nameAge()                               ////there are no variables decared in the method so nothing has to be declared on line 14
        {
            Console.WriteLine("Enter name!");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter age!");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hallo " + Name + " idc that you're " + Age);
        }

        static int Cube1()
        {
            Console.WriteLine("Enter 1st number!");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number!");
            int y = Convert.ToInt32(Console.ReadLine());
            int result = x + y;
            Console.WriteLine(x+" + "+y+" = "+result);
            return result;                                  //////without a void the return is nesiccssary 
        }
    }
}
