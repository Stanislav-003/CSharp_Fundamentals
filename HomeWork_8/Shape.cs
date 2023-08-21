using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork8
{
    abstract class Shape 
    {
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();
        
    }
}
