using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork8
{
    class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(string name, int radius) : base(name)
        {
            Radius = radius;
        }
        public override double Area()
        {
            double circleArea = Math.PI * Math.Pow(Radius, 2);
            return circleArea;
        }
        public override double Perimeter()
        {
            double circlePerimeter = 2 * Math.PI * Radius;
            return circlePerimeter;
        }
    }
}
