using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork8
{
    abstract class Shape : IComparable
    {
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(object obj)
        {
            Shape shape = obj as Shape;
            if (shape != null)
            {
                if (this.Area() > shape.Area())
                    return 1;
                if (this.Area() < shape.Area())
                    return -1;
                else
                    return 0;
            }
            //if (shape != null)
            //    return this.Area().CompareTo(shape.Area());
            else
                throw new ArgumentException("Параметр не є типа Shape!");
        }
    }
}
