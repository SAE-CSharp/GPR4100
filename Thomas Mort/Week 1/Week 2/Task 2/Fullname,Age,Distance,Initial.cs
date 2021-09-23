            string fullName;
            Console.WriteLine("Enter your Full name:");
            fullName = Console.ReadLine();
            Console.WriteLine("Your name is: " +fullName);
            Console.WriteLine("Are you sure you want to use that name " +fullName+ "\n Why not use another one?");
            fullName = Console.ReadLine();
            
            Console.WriteLine("\nHow old are you?");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your age is:" + age);

            Console.WriteLine("\nHow far is the distance between your house and your uni?");
            float distance = float.Parse(Console.ReadLine());
            Console.WriteLine("the distance is: " + distance);

            Console.WriteLine("\nWhat is the first letter of your name?");
            string firstLetter = (Console.ReadLine());
            Console.WriteLine("The first letter of your name is: " + firstLetter);
