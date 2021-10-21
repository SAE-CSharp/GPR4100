// This code is an example of how you might go about completing the week 5 homework, which
// was to create a program that could create a "number triangle" of any size given to it.
// Since at time of writing we have recently covered how methods work, I'm going to use
// this example to show how you might put that into practise!

// NOTE: I'm not putting this here for you to copy-paste as-is! This is an example of how
// to approach something like this, so that you can use it as a basis for making your own
// things! Be creative - there are lots of ways this approach can be used!

using System;

namespace ExampleCode_NumberTriangles
{
    class Program
    {
        // Firstly for the approach I'm using, we want a method that can display a
        // sequence of numbers from 1 to any endpoint it is given. This method does not
        // need to pass a value back to another part of the program, so we'll use the
        // "void" return type. We also want a single integer parameter, so that we can
        // tell the method what endpoint we want.

        static void NumLine(int length)
        {
            // Since we want the method to start the sequence with "1", we'll set the
            // starting value of its local variable to 1. We also want it to include the
            // endpoint value in the sequence, so we'll use the less than/equal to
            // logical operator in the condition.

            for (int n = 1; n <= length; n++)
            {
                // Using "Console.Write()" allows us to add text to an existing line,
                // rather than starting a new line. However, this does mean that we need
                // to specify starting a new line after the loop finishes running.
                
                Console.Write(n + " ");
            }
            Console.Write("\n");
        }

        // Next for this approach, we need to create a method that can count up by one
        // each time it is run, then down again after reaching a certain point. It would
        // be easier to do this by using the same variables every time, and just stating
        // them directly within the method, rather than taking them as arguments when
        // running the method. However, it is always good to generalise methods whenever
        // possible, since that means that you can reuse them for any purpose you need
        // to later on, so we'll be doing it slightly differently. Let me explain:

        // We want the method to be able to take an integer array as an input and return
        // one as an input. This is so that we can track the current value of the
        // up/down sequence, the maximum value it can go to, and the cirection it should
        // currently be counting in. We're doing it this way so that, if you needed to
        // use the method for multiple up/down counts at once, the program could
        // individually keep track of each one without getting mixed up.

        static int[] CountUpDown(int[] arrayIn)
        {
            // This local array will be used to store the method's output. It needs to
            // have a size of 3 to store all three pieces of relevant information.

            int[] arrayOut = new int[3];

            // For this example, I am having the element at index 0 be the maximum
            // value of the counter, the element at index 1 be its current value, and
            // the element at index 2 be the current direction it's counting in.

            // Since all the elements of an array have to be the same data type, we'll
            // represent counting up with "1", and counting down with "-1". Helpfully,
            // this means we can just set index 1 of the output array to the sum of
            // indices 1 and 2 of the input array.

            arrayOut[1] = arrayIn[1] + arrayIn[2];

            // Now we need to make sure that the element representing the counting
            // direction is set correctly for the next time we run the method. To do
            // this, we can simply check the element we just set in the output array! If
            // it's equal to 1, then we need to set index 2 of the output array to 1, as
            // that will ensure that the method will count up the next time it runs. If
            // it's equal to the maximum value we set, we need to set index 2 to -1, so
            // that the method will count down next time instead. Otherwise, we just set
            // index 2 to the same as the input array, since we want it to keep going in
            // the same direction.

            if (arrayOut[1] == 1)
            {
                arrayOut[2] = 1;
            }
            else if (arrayOut[1] == arrayIn[0])
            {
                arrayOut[2] = -1;
            }
            else
            {
                arrayOut[2] = arrayIn[2];
            }

            // I've used this particular approach so that, if I wanted to, I could have
            // the count bounce back and forth between 1 and the maximum value given any
            // number of times.

            // Before we return the output array, we need to make sure that it has the
            // information about the maximum value of the count stored as well, so we
            // just set index 0 of the output array directly from index 0 of the input
            // array.

            arrayOut[0] = arrayIn[0];
            return arrayOut;
        }

        // Now that the two specific methods we need for this example are set up, we move
        // on to the Main method.

        static void Main(string[] args)
        {
            // First things first, we need to get the size for the number triangle from
            // the user, by parsing "Console.ReadLine()" to an integer.
            
            Console.WriteLine("Please enter a peak value for a number triangle.");
            int inputVal = Int32.Parse(Console.ReadLine());

            // I just use empty instances of "Console.WriteLine()" to leave blank lines
            // on the console tha make it look nicer for the user.

            Console.WriteLine();

            // Here we declare the array that we'll use to track the counting up & down.
            // I could've just put the initial values of "counter" and "modifier directly
            // into the array, but for the sake of clarity in this example, I've declared
            // them as variables first.

            int counter = 1;
            int modifier = 1;
            int[] countTrack = { inputVal, counter, modifier };

            // This is the code that actually prints the number triangle. As you can see,
            // the code for this within Main takes up very little space, as the methods
            // used were defined elsewhere, making the program as a whole much more
            // compact. If I wanted to run this function again within a single run of the
            // program, this is all the code I'd need to copy, instead of copying the
            // entire contents of both methods over again.

            // Since we want the triangle to go from 1, to max, and back to 1, we want
            // the for loop to run a number of times equal to twice the maximum value,
            // minus one, since we only print the line that includes the maximum value
            // once. We can start the local variable at 0 here, since we don't need to
            // use it for anything beyond controlling how many times the loop runs.

            for (int i = 0; i < (2 * inputVal) - 1; i++)
            {
                // Since we selected index 1 as the current value of the counter, we need
                // to pass that to the "NumLine()" method.
                
                NumLine(countTrack[1]);

                // Now we need to adjust the counter, so we set the new values of the
                // counter array from the output of the "CountUpDown()" method when it's
                // passed the *current* values of the counter array.

                countTrack = CountUpDown(countTrack);
            }

            // One more empty "Console.WriteLine()" for neatness!

            Console.WriteLine();
        }
    }
}
