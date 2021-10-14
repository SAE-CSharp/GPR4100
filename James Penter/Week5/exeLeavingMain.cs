using System;

namespace exeLeavingMain
{
    class Program
    {
        static void Main(string[] args)//method 
        {

            Info("James.", 22);//already assigned
            Info("Joe.", 19);
            Info("Jack.", 27);
            Info("Josh.", 24);

            Sae();

            int res = Cube1();//user input 
            //int res2 = res + 15;


            Console.WriteLine("The result recieved is " + res);


        }
        static void Info(string name, int num)
        //void means no datatype with the function. after string is added it will demand a string value in the brackets.
        {
            Console.WriteLine("Hello there my name is: " + name + " my current age is: " + num);
        }
        static void Sae()
        {
            Console.WriteLine("How are you feeling today");
            string mood = Console.ReadLine();
            Console.WriteLine(mood + "... So that's how you're feeling");


        }//method


        static int Cube1()
        {
            Console.WriteLine("Input a value for X:");
            
            int xresult = Int32.Parse(Console.ReadLine());
            

            Console.WriteLine("Input a value for Y:");


            int yresult = Int32.Parse(Console.ReadLine());
            

            Console.WriteLine("Your value for x is..." + xresult);
            Console.WriteLine("Your value for y is..." + yresult);



            return xresult + yresult;


        } 

        
    }
}
