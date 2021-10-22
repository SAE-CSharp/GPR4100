// This code example is intended to demonstrate how to create and use classes and objects in C# - due to
// how this is done in Visual Studio, this example code will be split across multiple files. I will note
// within the code when to reference another file within this folder.

using System;

// The "namespace" comes into play when splitting  your code across multiple files - it's used by the
// compiler in grouping and referencing sections of code. Make sure that the namespace is the same across
// all your files!

namespace ExampleCode_ClassesObjects
{
    // The "Program" class is automatically created by Visual Studio when you start a new project - it's
    // the default class that is automatically run. Don't delete or rename it!

    // Each new class is a new data type, and can be defined with the same format as "Program". You can
    // create new classes within the same file as "Program", but as we'll learn over time, it's better
    // practise not to keep all your code in a single file.

    // In Visual Studio, to create a new class, you need to look at the "Solution Explorer" sidebar - on
    // the left or right of the Visual Studio window - and right click on the namespace of your code.
    // This will be the item in the list that is ONLY the name of the namespace, not the item starting
    // with "Solution".

    // One of the options this brings up will be "Add". Moving your mouse over that will bring up more
    // options, and from those, you want to click on "Class..." which is near the bottom. This will bring
    // up a new menu with a list of things you can create, and "Class" should already be selected. You
    // can name the new class at the bottom of the menu - make sure the name always ends in ".cs" - and
    // once you've named the class, you can click "Add".

    // Creating a new class this way in Visual Studio will create and open a separate file for it, and
    // Visual Studio will automatically switch to viewing it. The main "Program" class, and any other
    // created classes, can be accessed from the list along the top of the code view. You'll want to hop
    // over to the "Student.cs" file now - this is the first example class I'll be using.

    // A quick note, though - while I've only created one extra class (and therefore one extra file) for
    // this example, you can create as many as you need for your own program!

// - - - - - - - - - - - - - - - - GO TO: STUDENT.CS - - - - - - - - - - - - - - - - //

    // If you're back here, that means you should have read through the "Student.cs" file - if you
    // haven't, you'll be lacking some important information you need to understand the rest of this
    // example code!
    
    class Program
    {
        static void Main(string[] args)
        {
            // With the "Student" class created, we first need to receive user input so that we have
            // values to create an object with.

            Console.WriteLine("-- { STUDENT 1 } --");

            Console.WriteLine("\nPlease enter your name.");
            string userName = Console.ReadLine();

            Console.WriteLine("\nPlease enter your age.");
            int userAge = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter which SAE campus you attend.");
            string userCampus = Console.ReadLine();

            Console.WriteLine("\nPlease enter your student ID.");
            int userID = Int32.Parse(Console.ReadLine());

            Console.Clear();
            
            Console.WriteLine("-- { STUDENT 1 } --");

            Console.WriteLine();

            // The newlines ("\n") and empty instance of "Console.WriteLine()" I've added are there to
            // make everything display in a way that is more pleasing to the user.

            // "Console.Clear()" can be used to clear everything currently displayed from the console.

            // We can now use these inputs to create a new object from the "Student" class. First, we
            // declare a new object of type "Student", give it a name, and then use the "new" keyword
            // with the "constructor" method we created within the class to assign values to it, by
            // using the variables we declared from user input as the arguments.

            Student student1 = new Student(userName, userAge, userCampus, userID);

            // Now we can call methods we declared in the "Student" class to retrieve and display this
            // information! We can do this using the individual "getter" methods:

            Console.WriteLine("| >> Student Information <<\n|");
            Console.WriteLine("| Name:\n| - " + student1.GetName());
            Console.WriteLine("| Age:\n| - " + student1.GetAge());
            Console.WriteLine("| SAE campus:\n| - " + student1.GetCampus());
            Console.WriteLine("| Student ID:\n| - " + student1.GetID());

            Console.WriteLine();

            // As shown above, we can use the format "<object>.<method>()" to call a method that exists
            // within an object based on a class that has methods inside it. We can also use this with
            // the "setter" methods to change the values of an object's attributes:

            Console.WriteLine("Please re-enter your information, correcting any errors.");

            Console.WriteLine("\nPlease enter your name.");
            userName = Console.ReadLine();
            student1.SetName(userName);

            Console.WriteLine("\nPlease enter your age.");
            userAge = Int32.Parse(Console.ReadLine());
            student1.SetAge(userAge);

            Console.WriteLine("\nPlease enter which SAE campus you attend.");
            userCampus = Console.ReadLine();
            student1.SetCampus(userCampus);

            Console.WriteLine("\nPlease enter your student ID.");
            userID = Int32.Parse(Console.ReadLine());
            student1.SetID(userID);

            Console.Clear();
            Console.WriteLine("-- { STUDENT 1 } --\n");

            // As we created a method within the "Student" class that does the job of displaying the
            // information stored in an object created from that class, we can use that method in the
            // same way to achieve the same effect:

            student1.DisplayInfo();

            // This does the exact same thing, and allows us to only write one line of code each time
            // we need to display the stored information for any object!

            // We can create as many new objects as we need to from a single class - to demonstrate,
            // let's do the same again, with a second "Student" object:

            Console.WriteLine("-- { STUDENT 2 } --");

            Console.WriteLine("\nPlease enter your name.");
            userName = Console.ReadLine();

            Console.WriteLine("\nPlease enter your age.");
            userAge = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter which SAE campus you attend.");
            userCampus = Console.ReadLine();

            Console.WriteLine("\nPlease enter your student ID.");
            userID = Int32.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("-- { STUDENT 2 } --\n");

            Student student2 = new Student(userName, userAge, userCampus, userID);

            student2.DisplayInfo();

            // And now we can make use of both objects whenever we need to within the program!

            Console.WriteLine("< Press Enter to continue >");
            Console.ReadLine();
            Console.Clear();
            
            // If you don't set the value of something from "Console.ReadLine()", it will effectively
            // just pause the program until you press Enter. I wouldn't necessarily recommend using
            // this, but I've used it here to allow the user to view the information displayed before
            // moving on.

            Console.WriteLine("-- { STUDENT 1 } --\n");
            student1.DisplayInfo();

            Console.WriteLine("-- { STUDENT 2 } --\n");
            student2.DisplayInfo();
        }
    }
}
