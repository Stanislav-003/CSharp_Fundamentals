using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork8
{
    class Square : Shape
    {
        public int Side { get; set; }
        public Square(string name, int side) : base(name)
        {
            Side = side;
        }
        public override double Area()
        {
            double squareArea = Math.Pow(Side, 2);
            return squareArea;
        }
        public override double Perimeter()
        {
            double squarePerimeter = Side * 4;
            return squarePerimeter;
        }
    }
}
