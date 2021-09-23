// making a mix of float, int and string within an input response

            string Yes;
            string No;
            string yes;
            string no;
            string y;
            string n;
            string Y;
            string N;
            string FullName;
            Console.WriteLine("Enter your full name");
            FullName = Console.ReadLine();
            Console.WriteLine("Your name is " + FullName);
            Console.WriteLine("are you sure " + FullName + " is your name?");
            FullName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Are you sure your age is " + Age + "?");
            Console.ReadLine();

            Console.WriteLine("In miles, How far is your accommodation from the SAE Liverpool?");
            float distance = float.Parse(Console.ReadLine());
            Console.WriteLine("The distance is " + distance + "miles from SAE Liverpool, Correct?");
            Yes = Console.ReadLine();
            yes = Console.ReadLine();
            Y = Console.ReadLine();
            y = Console.ReadLine();

            Console.WriteLine("Thank you for your time");


            Console.WriteLine("****************************************************************");

            //seeing how long i havce left to life (its not that long)

            int diet, PlayerAge;
            float exeT, DeathYears;

            Console.WriteLine("How old are you?");
            PlayerAge = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many days a week do you eat healthly?");
            diet = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many hours a week do you exercise for?");
            exeT = float.Parse(Console.ReadLine());


            DeathYears = (int)PlayerAge * (exeT / diet);

            Console.WriteLine("you have " + DeathYears + "years to live");

            Console.WriteLine("****************************************************************");

            Console.WriteLine("please enter a number above 5");
            int X;
            X = Int32.Parse(Console.ReadLine());
            if (X > 5) Console.WriteLine("thank you for entering a number above 5");

            else { Console.WriteLine("the number you entered is not above 5, please try again"); }


            Console.WriteLine("****************************************************************");


            //creating a calculator

            int num1, num2, answer;

            char opp;

            Console.WriteLine("please enter an operation from the following, +, -, *, % ");
            opp = Char.Parse(Console.ReadLine());
            if (opp == '+')
            {
                Console.WriteLine("Please enter the first number");
                num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                num2 = Int32.Parse(Console.ReadLine());
                answer = num1 + num2;
                Console.WriteLine("your Answer is " + answer);
            }

            else if (opp == '-')
            {
                Console.WriteLine("Please enter the first number");
                num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                num2 = Int32.Parse(Console.ReadLine());
                answer = num1 - num2;
                Console.WriteLine("your Answer is " + answer);
            }

            else if (opp == '*')
            {
                Console.WriteLine("Please enter the first number");
                num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                num2 = Int32.Parse(Console.ReadLine());
                answer = num1 * num2;
                Console.WriteLine("your Answer is " + answer);
            }

            else if (opp == '%')
            {
                Console.WriteLine("Please enter the first number");
                num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                num2 = Int32.Parse(Console.ReadLine());
                answer = num1 % num2;
                Console.WriteLine("your Answer is " + answer);
            }

            else
            {
                Console.WriteLine("Please enter a proper operation");
