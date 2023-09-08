using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork10
{
    public class Triangle
    {
        public Point Vertex1 { get; set; }
        public Point Vertex2 { get; set; }
        public Point Vertex3 { get; set; }

        private static int counter = 0;
        public int TriangleNumber { get; private set; }

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
            Vertex3 = vertex3;
            TriangleNumber = ++counter;
        }

        public double Distance(Point p1, Point p2)
        {
            int dx = p1.X - p2.X;
            int dy = p1.Y - p2.Y;
            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }

        public double Perimeter()
        {
            double st1 = Distance(Vertex1, Vertex2);
            double st2 = Distance(Vertex2, Vertex3);
            double st3 = Distance(Vertex3, Vertex1);

            return st1 + st2 + st3;
        }

        public double Square()
        {
            double st1 = Distance(Vertex1, Vertex2);
            double st2 = Distance(Vertex2, Vertex3);
            double st3 = Distance(Vertex3, Vertex1);
            double p = (st1 + st2 + st3) / 3;

            return Math.Sqrt(p * (p - st1) * (p - st2) * (p - st3));
        }

        public void Print()
        {
            Console.WriteLine($"Трикутник {TriangleNumber}");
            Console.WriteLine($"Вершини трикутника: {Vertex1}, {Vertex2}, {Vertex3}");
            Console.WriteLine($"Периметр трикутника: {Perimeter()}");
            Console.WriteLine($"Площа трикутника: {Square()}\n");
        }
    }
}
