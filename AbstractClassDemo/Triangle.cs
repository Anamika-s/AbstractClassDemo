using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassDemo
{
    class Triangle : Shape
    {
         
            int basee;
            int height;
             
            public override void GetDimensions()
            {
                Console.WriteLine("Enter Value for Base");
                basee = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter Value for Height");
                height = Convert.ToByte(Console.ReadLine());

            }
            public override void CalculateArea()
            {
                area = .5 * (double)basee * (double)height;
            }
            
        }
}
