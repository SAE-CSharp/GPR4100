using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           // cat object
            cat cat1 = new cat();
            
            cat1.setName("Chucky");
            string catname = cat1.getName();
            Console.WriteLine(catname);

            // animal object
            animal a = new animal();
            a.Eat();


            // triangle object
            triangle t = new triangle();
            t.setWidth(10.2);
            t.setheight(20.1);
            double width = t.getwidth();
            double height = t.getheight();
            double area = t.getarea();
            Console.WriteLine("the width is " + width + " and the height is " + height + " and the area of the triangle is " + area);

        }

    }
}
