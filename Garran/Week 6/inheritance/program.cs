using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();

            cat1.setName("Kals");
            string Catname = cat1.getName();
            Console.WriteLine(Catname);

            //Animal object
            Animal a = new Animal();
            a.Eat();

            //Triangle object 

            Triangle t = new Triangle();
            t.setWidth(10.2);
            t.setHeight(20.1);
            double width = t.getWidth();
            double height = t.getheight();
            double area = t.getArea();

            Console.WriteLine("The width is " + width + " and the height is " + height + " and the area of the triangle is " + area);
        }
    }
}
