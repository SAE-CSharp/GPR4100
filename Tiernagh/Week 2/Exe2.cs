string fullname;
            Console.WriteLine("Enter your full name ");
            fullname = Console.ReadLine();
            Console.WriteLine("Your name is " + fullname);
            Console.WriteLine("Are you sure you want to use this name? "+fullname+ "Why don\'t you use another one");
            fullname = Console.ReadLine();
            Console.WriteLine("How old are you? ");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your age is: "+age);
            Console.WriteLine("How far is your home to the city ");
            float distance = float.Parse(Console.ReadLine());
            Console.WriteLine("The distance is: "+distance);
            Console.WriteLine("Enter the first letter of your name ");
            string firstletter;
            firstletter = Console.ReadLine();
            Console.WriteLine("The first letter of your name is "+firstletter);
