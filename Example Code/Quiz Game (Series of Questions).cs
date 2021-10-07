// This code is an example of how you might go about asking the user a series of questions, then
// asking them more questions or ending the game based on whether they gave a correct answer. While
// this example uses the idea of a quiz, you can use it for any kind of game or system that has a
// series of right or wrong answers. If the questions asked need to change with previous answers,
// that requires a different approach that I may explore another time.

// NOTE: I'm not putting this here for you to copy-paste as-is! This is an example of how to
// approach something like this, so that you can use it as a basis for making your own things!
// Be creative - there are lots of ways this approach can be used!

using System;

namespace ExampleCode_SeriesOfQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctQs;
            int failedQs;
            int maxFails = 1;

            // These integer variables are to determine how many questions the user has and hasn't answered
            // correctly, and how many incorrect answers the user is allowed before the game ends.

            int answer;

            // This integer variable will be used to receive the answers the user gives, so that the program
            // can check if they answered correctly.

            bool playerAlive;

            // This boolean variable will be used to tell the program whether to keep asking questions.

        start:
        // This is a "label", and we can use it to jump back to this point in the code. This is also where we
        // reset the values for some of the variables we declared.
            correctQs = 0;
            failedQs = 0;
            playerAlive = true;

            /*-------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            Console.WriteLine("Welcome to my multiple choice quiz game!\nYou need to enter the number that corresponds to the correct answer for each question.\n");
            if (maxFails == 1)
            {
                Console.WriteLine("If you answer any question incorrectly, the game will end.\n");
            }
            else
            {
                Console.WriteLine("If you answer " + maxFails + " questions incorrectly, the game will end.\n");
            }

            // This welcomes the user, and tells them how many incorrect answers will end the game.

/*-------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            if (playerAlive)
            // This conditional checks whether the user has reached the maximum number of incorrect answers,
            // and only executes the code it contains if they haven't. The "playerAlive" variable is a boolean,
            // so we can use it in a conditional on its own. Later, we will change the variable's value if
            // the user gives too many incorrect answers.
            
            {
                Console.WriteLine("Question 1:\nWhich month gets an extra day in a leap year?");
                Console.WriteLine("  [1] February\n  [2] May\n  [3] August");

                answer = Int32.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                    // This "case" determines what the program does if the correct answer is given - the "1"
                    // should be changed to be the same as the correct input, whether it's a different
                    // number, or even a different data type.

                        playerAlive = true;
                        correctQs++;
                        Console.WriteLine("\nCorrect!\n");
                        break;
                        // The code to be executed for the correct answer sets "playerAlive" to the value
                        // needed for the player to continue, increases their score by 1, tells them that
                        // they got the right answer, and exits the switch statement.

                    default:
                    // The "default" case is like the "else" part of an if/else statement - it says what to
                    // do if no other condition is satisfied - in this case, if the wrong answer is given.

                        playerAlive = false;
                        failedQs++;
                        Console.Write("\nIncorrect. ");
                        if (failedQs < maxFails)
                        {
                            Console.Write((maxFails - failedQs) + " more incorrect answer(s) will end the game.");
                        }
                        Console.WriteLine("The correct answer was: [1] February\n");
                        break;
                        // The code to be executed for the incorrect answer sets "playerAlive" to the value
                        // that will end the game, increases the failed answer counter by 1, tells them that
                        // they got the wrong answer, and exits the switch statement.
                }

                if ( !(failedQs < maxFails) )
                {
                    playerAlive = false;
                }
                // At the end of the question block, we check whether the number of incorrect answers is less
                // than the number that will end the game, and if it is NOT, we set "playerAlive" to false to
                // prevent later questions from triggering.
            }

            // This if statement can now be copied as many times as you want, to give the quiz as many questions
            // as you want. Each time, the condition that checks how many incorrect answers have been given
            // against how many end the game will determine whether the next question should be asked.

/*-------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            if (playerAlive)
            {
                Console.WriteLine("Question 2:\nWhat is 5^3? (5 cubed)");
                Console.WriteLine("  [1] 100\n  [2] 125\n  [3] 175");

                answer = Int32.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 2:
                        playerAlive = true;
                        correctQs++;
                        Console.WriteLine("\nCorrect!\n");
                        break;

                    default:
                        playerAlive = false;
                        failedQs++;
                        Console.Write("\nIncorrect. ");
                        if (failedQs < maxFails)
                        {
                            Console.Write((maxFails - failedQs) + " more incorrect answer(s) will end the game.");
                        }
                        Console.WriteLine("The correct answer was: [2] 125\n");
                        break;
                }

                if (!(failedQs < maxFails))
                {
                    playerAlive = false;
                }
            }

/*-------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            if (playerAlive)
            {
                Console.WriteLine("Question 3:\nWhich of these is a type of bird?");
                Console.WriteLine("  [1] Tern\n  [2] Whelk\n  [3] Gull");

                answer = Int32.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                    case 3:
                    // If two cases are placed next to each other like this, either condition being fulfilled
                    // will execute the relevant code. You can use this if there are multiple correct answers.
                    // Here, both answers 1 and 3 will be recognised as correct answers.

                        playerAlive = true;
                        correctQs++;
                        Console.WriteLine("\nCorrect!");
                        if (answer == 1)
                        {
                            Console.WriteLine("[3] Gull was also a correct answer.\n");
                        }
                        else
                        {
                            Console.WriteLine("[1] Tern was also a correct answer.\n");
                        }
                        break;
                        // Personally, I would make sure to tell the user if there was more than one correct
                        // answer to a quiz question.

                    default:
                        playerAlive = false;
                        failedQs++;
                        Console.Write("\nIncorrect. ");
                        if (failedQs < maxFails)
                        {
                            Console.Write((maxFails - failedQs) + " more incorrect answer(s) will end the game.");
                        }
                        Console.WriteLine("The correct answers were: [1] Tern and [3] Gull\n");
                        break;
                }

                if (!(failedQs < maxFails))
                {
                    playerAlive = false;
                }
            }

/*-------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            if (playerAlive)
            {
                Console.WriteLine("Question 4:\nHow many different values can a \"boolean\" variable have?");
                // We need to use \" rather than just using " on its own, because otherwise the program will
                // think that the quotes represent the end of one string and the start of another.
                Console.WriteLine("  [1] Three\n  [2] Five\n  [3] Two");

                answer = Int32.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 3:
                        playerAlive = true;
                        correctQs++;
                        Console.WriteLine("\nCorrect!\n");
                        break;

                    default:
                        playerAlive = false;
                        failedQs++;
                        Console.Write("\nIncorrect. ");
                        if (failedQs < maxFails)
                        {
                            Console.Write((maxFails - failedQs) + " more incorrect answer(s) will end the game.");
                        }
                        Console.WriteLine("The correct answer was: [3] Two\n");
                        break;
                }

                if (!(failedQs < maxFails))
                {
                    playerAlive = false;
                }
            }

/*-------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            if (playerAlive)
            {
                Console.WriteLine("\nCongratulations! You answered enough questions correctly!\n");
            }
            else
            {
                Console.WriteLine("\nGame over! Unfortunately, you got too many questions wrong.\n");
            }
            // This tells the user whether they were successful.

            Console.WriteLine("You got " + correctQs + " questions right!");
            if (maxFails > 1)
            {
                Console.WriteLine("You got " + failedQs + " questions wrong.");
            }
            // This tells the user how they did on the quiz.

            Console.WriteLine("\nWould you like to play again? (y/n)");
            char restart = Char.Parse(Console.ReadLine());
            if (restart == 'y' || restart == 'Y')
            {
                Console.Clear();
                goto start;
            }
            // This gives the user the option to restart the quiz.
        }
    }
}
