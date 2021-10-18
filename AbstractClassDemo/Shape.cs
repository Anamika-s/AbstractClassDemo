using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassDemo
{
    abstract class Shape
    {
        protected double area;
        public abstract void GetDimensions();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
}
