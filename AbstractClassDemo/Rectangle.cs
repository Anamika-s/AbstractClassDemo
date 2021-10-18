using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassDemo
{
    class Rectangle : Shape
    {
        int length;
        int width;
        
        public override void GetDimensions()
        {
            Console.WriteLine("Enter Value for Length");
            length = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Value for Width");
            width = Convert.ToByte(Console.ReadLine());

        }
        public override void CalculateArea()
        {
            area = length * width;
        }
        
    }
}
