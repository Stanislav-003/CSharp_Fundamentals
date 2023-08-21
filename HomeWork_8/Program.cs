using System;
using System.Collections.Generic;

namespace HomeWork8
{
    class Program 
    {
        static Circle CreateCircle(string name)
        {
            Console.Write("Введіть радіус: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            return new Circle(name, radius);
        }

        static Square CreateSquare(string name)
        {
            Console.Write("Введіть сторону: ");
            int side = Convert.ToInt32(Console.ReadLine());
            return new Square(name, side);
        }
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Оберіть форму Circle або Square для {i + 1} елемента: ");
                string shapeType = Console.ReadLine().ToLower();

                switch (shapeType)
                {
                    case "circle":
                        shapes.Add(CreateCircle($"Circle {i + 1}"));
                        break;
                    case "square":
                        shapes.Add(CreateSquare($"Square {i + 1}"));
                        break;
                    default:
                        Console.WriteLine("Невірний тип форми.");
                        i--;
                        break;
                }
            }

            Console.WriteLine("\nІнформація про форми: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Фігура: {shape.Name}");
                Console.WriteLine($"Площа: {shape.Area()}");
                Console.WriteLine($"Периметр: {shape.Perimeter()}");
                Console.WriteLine();
            }

            Shape shapeWithMaxPerimeter = null;
            double maxPerimeter = 0;

            foreach (Shape shape in shapes)
            {
                double perimeter = shape.Perimeter();
                if (perimeter > maxPerimeter)
                {
                    maxPerimeter = perimeter;
                    shapeWithMaxPerimeter = shape;
                }
            }

            if (shapeWithMaxPerimeter != null)
            {
                Console.WriteLine($"Фігура з найбільшим периметром: {shapeWithMaxPerimeter.Name}");
            }
            else
            {
                Console.WriteLine("Не вдалося знайти фігуру з найбільшим периметром.");
            }

            shapes.Sort();
            Console.WriteLine();

            Console.WriteLine("Відсортований список фігур!");
            foreach (var s in shapes)
            {
                Console.WriteLine($"{s.Name}, {s.Area()}");
            }
        } 
    }
}
