  float x, y, Result;
            char op;

            Console.WriteLine("Enter your first number:");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("What operation would you like to do?");
            op = char.Parse(Console.ReadLine());

            if (op == '+')
            {
                Result = x+y;
                Console.WriteLine("The answer is:" + Result);
            }
            else if (op == '-')
            {
                Result = x - y;
                Console.WriteLine("The answer is:" + Result);
            }
            else if (op == '*')
            {
                Result = x * y;
                Console.WriteLine("The answer is:" + Result);
            }
            else if (op == '/')
            {
                Result = x / y;
                Console.WriteLine("The answer is:" + Result);
            }
            else
            {
                Console.WriteLine("This is not a valid Operator..");
            }
