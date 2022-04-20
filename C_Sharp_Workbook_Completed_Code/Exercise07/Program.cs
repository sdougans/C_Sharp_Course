using System;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(2, 4);
            Console.WriteLine("Area is " + rect1.CalculateArea());
            Console.WriteLine("Perimeter is " + rect1.CalculatePerimeter());
            Console.WriteLine("Is the shape a suqare? " + rect1.CheckSquare());


            Rectangle rect4 = new Rectangle(4, 4);
            Console.WriteLine("Area is " + rect4.CalculateArea());
            Console.WriteLine("Perimeter is " + rect4.CalculatePerimeter());
            Console.WriteLine("Is the shape a suqare? " + rect4.CheckSquare());
        }
    }
}
