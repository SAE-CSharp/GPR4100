namespace GuessQuestion
{
    class Program
    {
 
        static void Main(string[] args)
        {
            int score = 0;
            Console.WriteLine("You will automatically begin with a score of 0 " +
                "\n Please answer as many questions as possible to build your score " +
                "\n where is the spire in Ireland located? \n 1. Dublin \n 2. Cork");
            int questions = Int32.Parse(Console.ReadLine());

            switch (questions)
            {
                case 1:
                    score += 1;
                    Console.WriteLine("Your answer is correct your score is now " + score);
                        break;
                case 2:
                    score = 1;
                    Console.WriteLine("Your answer is not  correct please try again " +
                        "\n Where are the remains of King Tutankhamun? \n 1. America \n 2. Egypt");
                    int option = Int32.Parse(Console.ReadLine());
                    if (option == 1 || option ==2)
                    {
                        score += 1;
                        Console.WriteLine("Well done, you are correct! Your score is now " + score);
                    }
                    else
                    {
                        Console.WriteLine("You were incorrect :(");
                    }

                    break;

            }
            if (score >= 2)
            {
                Console.WriteLine("Well done you will now move to the next level");
            }

            Console.WriteLine("Currectly your score is " + score + "How many points will you get in this round");
            Console.WriteLine("Who named the Pacific Ocean? \n 1. Ferdinand Magellan \n 2. Beyonce");
            int questions1 = Int32.Parse(Console.ReadLine());
            switch (questions1)
            {
                case 1:
                    score += 1;
                    Console.WriteLine("Your answer is correct your score is now " + score);
                    break;

                case 2:
                    score += 1;
                    Console.WriteLine("Your answer is not  correct please try again " +
                        "\n How many languages are written from right to left? \n 1. 12 \n 2. 15");
                    int option = Int32.Parse(Console.ReadLine());
                    if (option == 1 || option == 2)
                    {
                        score += 1;
                        Console.WriteLine("Well done, you are correct! Your score is now " + score);
                    }
                    else
                    {
                        Console.WriteLine("You were incorrect :(");
                    }

                    break;
            }

        }
}
