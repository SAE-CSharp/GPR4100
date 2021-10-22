using System;

namespace MCarpenter_Wk6_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle shape1 = new Rectangle();
            shape1.SetHeight(4);
            shape1.SetWidth(6);

            Triangle shape2 = new Triangle();
            shape2.SetHeight(7);
            shape2.SetWidth(3);

            Console.WriteLine("Shape 1: " + shape1.GetShapeType());
            Console.WriteLine("Height: " + shape1.GetHeight());
            Console.WriteLine("Width: " + shape1.GetWidth());
            Console.WriteLine("Area: " + shape1.GetArea());

            Console.WriteLine();

            Console.WriteLine("Shape 2: " + shape2.GetShapeType());
            Console.WriteLine("Height: " + shape2.GetHeight());
            Console.WriteLine("Width: " + shape2.GetWidth());
            Console.WriteLine("Area: " + shape2.GetArea());

            Console.WriteLine();
        }
    }
}
