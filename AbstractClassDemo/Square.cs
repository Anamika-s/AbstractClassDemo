using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassDemo
{
    class Square : Shape
    {
        int side;
        public override void CalculateArea()
        {
            area = side * side;
        }

        public override void GetDimensions()
        {
            Console.WriteLine("Enter Value for side");
            side = Convert.ToByte(Console.ReadLine());

        }
    }
}
