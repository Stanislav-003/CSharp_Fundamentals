using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork10
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();

            triangles.Add(new Triangle(new Point(2, 6), new Point(4, 1), new Point(1, 7)));
            triangles.Add(new Triangle(new Point(1, 3), new Point(1, 6), new Point(0, 4)));
            triangles.Add(new Triangle(new Point(5, 7), new Point(5, 0), new Point(2, 5)));

            foreach (Triangle t in triangles)
            {
                t.Print();
            }

            var closestVertex = (from t in triangles
                                 let closestVertexD = new[]
                                 {
                                    t.Distance(t.Vertex1, new Point(0, 0)),
                                    t.Distance(t.Vertex2, new Point(0, 0)),
                                    t.Distance(t.Vertex3, new Point(0, 0)),
                                 }.Min()
                                 orderby closestVertexD
                                 select t).First();

            Console.WriteLine($"Трикутник {triangles.IndexOf(closestVertex) + 1} із найближчою до початку координат вершиною (0,0)");
            closestVertex.Print();
        }
    }
}
