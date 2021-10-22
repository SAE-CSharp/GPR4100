// If this is the first file you opened, go back to the folder and open the "Program.cs" file instead!

using System;

// Remember: make sure that all files for the same program use the same namespace!

namespace ExampleCode_ClassesObjects
{
    // To create a new class, we just need the "class" keyword, followed by the name of the new class.
    
    class Student
    {
        // A class acts as a blueprint for something we call an "object", which is effectively another
        // way of storing information. However, an object created from a class is much more versatile
        // than a variable, or even an array. Each new class is effectively a new data type, so when
        // creating one, we need to state what information it can store.

        // One type of thing a class can store is an "attribute" - this is much like a parameter for
        // a method, in that it's declared like a variable, but you don't necessarily need to assign a
        // value to it right away. For this example, we'll have the "Student" class store a name, age,
        // campus, and student ID number.

        string studentName;
        int studentAge;
        string studentCampus;
        int studentID;

        // Once we've delcared the class' attributes, we'll want to create a special method called a
        // "constructor" to allow us to assign values to the attributes elsewhere in the program. This is
        // important beause, again, a class acts like a blueprint - we want to be able to assign
        // different values to the different objects created from it.

        // The constructor is declared with just "public" and its name, which is identical to the name of
        // the class. As with any other method, we can then put parameters in the regular brackets so
        // that we can pass values to the method when we call it. In this case, we want the constructor
        // to have parameters for all 4 of the attributes.

        public Student(string name, int age, string campus, int ID)
        {
            // Within the constructor, we assign values to the attributes from the constructor's
            // parameters. This is done using the "this" keyword, which refers to the class it's
            // contained in, without having to use the name of the class.

            this.studentName = name;
            this.studentAge = age;
            this.studentCampus = campus;
            this.studentID = ID;
        }

        // If you don't declare the constructor manually, it will have a "default" constructor created
        // for it automatically. You can do this if you don't need to assign any values to an object's
        // attributes when you create it from a class - values can always be assigned later, if you set
        // the class up to handle that!

        // While the overall class is publically accessible to the rest of the program by default, its
        // contents are not - anything not declared with a specific "access modifier" is set to "private"
        // by default. We've set the constructor to be public, but it's good practise to leave a class'
        // attributes as private. However, we still want to be able to access the information elsewhere
        // in the program, so to achieve this we can use what are known as "getter" and "setter" methods.
        // These methods are set to be public, meaning that they can be accessed outside of the class,
        // but because they're declared within the class they can still access the attributes.

        // For the "getter" methods, we want to set their return types to be the data type of whatever
        // attribute they are meant to retrieve. We can then use "return", "this" and the name of the
        // relevant attribute to pass the requested information back.

        public string GetName()
        {
            return this.studentName;
        }
        public int GetAge()
        {
            return this.studentAge;
        }
        public string GetCampus()
        {
            return this.studentCampus;
        }
        public int GetID()
        {
            return this.studentID;
        }

        // For the "setter" methods, since they set the values of the attributes rather than retrieving
        // them, we can set their return types to "void". However, since we want to set the values from
        // a user input, we need to make sure to include a parameter to handle the input.

        public void SetName(string name)
        {
            this.studentName = name;
        }
        public void SetAge(int age)
        {
            this.studentAge = age;
        }
        public void SetCampus(string campus)
        {
            this.studentCampus = campus;
        }
        public void SetID(int ID)
        {
            this.studentID = ID;
        }

        // As these "getter" and "setter" methods show, you can create methods within a new class as well
        // as giving it attributes. I'll demonstrate how to use these methods outside of the class back
        // in the "Program.cs" file, but first, I'll give one more example - a method to display the data
        // stored in an object created with this class.

        public void DisplayInfo()
        {
            Console.WriteLine("| >> Student Information <<\n|");
            Console.WriteLine("| Name:\n| - " + this.studentName);
            Console.WriteLine("| Age:\n| - " + this.studentAge);
            Console.WriteLine("| SAE campus:\n| - " + this.studentCampus);
            Console.WriteLine("| Student ID:\n| - " + this.studentID);
            Console.WriteLine();
        }

        // And with that, go back to the "Program.cs" file, and we'll pick up where we left off!

// - - - - - - - - - - - - - - - - GO TO: PROGRAM.CS - - - - - - - - - - - - - - - - //

    }
}
