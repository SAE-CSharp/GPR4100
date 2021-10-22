using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cat object
            Cat cat1 = new Cat();
            cat1.setName("Felix");
            string Catname = cat1.getName();
            Console.WriteLine(Catname);

            // Animal object
            Animal a = new Animal();
            a.Eat();

            //Triangle object
            Triangle t = new Triangle();
            t.setWidth(14.2);
            t.setHeight(22.2);
            double width = t.getWidth();
            double height = t.getHeight();
            double area = t.getArea();
            Console.WriteLine("the width is " + width + " and the height is " + height + " finally the area is " + area);
            
        }
    }
}
