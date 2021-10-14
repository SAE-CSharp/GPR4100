 class Program
    {
        static void Main(string[] args)
        {
            //string subdivide = "running sub-submain ";
            
           SUBsubmain("running sub subdivide", 20);
           /* Console.WriteLine("please enter your name");
            string name = (Console.ReadLine());
            Console.WriteLine("please enter your age");
            int age = Int32.Parse(Console.ReadLine());*/
            submain();


            int res = Addnumbers();
            Console.WriteLine("the recieved number is " + res);





        }

        static void submain()
        {
            Console.WriteLine("please enter your name");
            string name = (Console.ReadLine());
            Console.WriteLine("please enter your age");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("submain method");
            Console.WriteLine("i am " + name + " and i am " + age + " years old ");

        }
         static void SUBsubmain(string subdivide, int num)
        {
            Console.WriteLine("method " + subdivide + " " + num);
            Console.WriteLine("gandhi is good");
        }


        static int Addnumbers()
        {
            int x, y;
            Console.WriteLine(" plaease enter the first number");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            y = Int32.Parse(Console.ReadLine()); 
             int result = x + y;

            return result;

        }
        
    }
