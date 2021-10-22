using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
           Traingle t =new Traingle(15.0, 20.5);
            double a=t.getArea();
            Console.WriteLine(a);
          
        }
    }
}
