using System;

namespace exe3
{
    class Program
    {
        static void Main(string[] args)
        {

        /*Here are some of the most frequently used escaping sequences: 
	- \' – single quote 
    - \" – double quotes 
    - \\ – backslash
    - \n – new line
     - \t – offset(tab)*/

            string myName = "Zara";
            string institute = "SAE";
            int Age = 100;
            float distance = 10.5f;
            Console.WriteLine("my name is "+myName+"");
            Console.WriteLine("I\'m a student at "+institute+" and I\'m "+Age+" years \n studying \"GPR4100\" ");
            Console.WriteLine("I live  in Huyton  \t faraway from city center it's about"+distance+" miles");
    
        }
    }
}
