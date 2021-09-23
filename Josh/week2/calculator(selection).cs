 float x, y, result = 0
                ;
            char op;

            Console.WriteLine("Enter first value: ");
            x = float.Parse(Console.ReadLine());


            Console.WriteLine("Enter second value: ");
            y = float.Parse(Console.ReadLine());


            Console.WriteLine("What would you like to do with these numbers. (+ - * or / )");
            op = char.Parse(Console.ReadLine());

            if (op == '+')
            {
                result = x + y;
            }
            else if (op == '-')
            {
                result = x - y;
            }
            else if (op == '*')
            {
                result = x * y;
            }
            else if (op == '/')
            {
                result = x / y;
            }
            else
            {
                Console.WriteLine("Invalid input entered!");
            }
            Console.WriteLine(x + " " + op + " " + y + " = " + result);
