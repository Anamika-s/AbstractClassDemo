using System;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           // Shape shape = new Shape();
            Console.WriteLine("Square -------- ");
            Square square = new Square();
            square.GetDimensions();
            square.CalculateArea();
            square.DisplayArea();

            Console.WriteLine("Rectangle -------- ");
            Rectangle rectangle = new Rectangle();
            rectangle.GetDimensions();
            rectangle.CalculateArea();
            rectangle.DisplayArea();

            Console.WriteLine("Triangle -------- ");
            Triangle triangle = new Triangle();
            triangle.GetDimensions();
            triangle.CalculateArea();
            triangle.DisplayArea();
        }
    }
}
