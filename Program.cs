using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.Write("Введіть сторону квадрата: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"Периметр квадрата = {a * 4} см");
            Console.WriteLine($"Площа квадрата = {Math.Pow(a, 2)} см^2");

            //2
            //Console.Write("Як Вас звати?:  ");
            //string name = Console.ReadLine();
            //Console.WriteLine("");
            //Console.Write("Скільки Вам років?:  ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");
            //Console.WriteLine($"Вас звати {name}, Вам {age} років.");

            //3
            //Console.Write("Введіть радіус кола у см: ");
            //double r = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("");
            //Console.WriteLine($"Довжина кола = {2 * Math.PI * r:F2} см");
            //Console.WriteLine($"Площа кола = {Math.PI * Math.Pow(r, 2):F2} см^2");
            //Console.WriteLine($"Об'єм кола = {4/3 * Math.PI * Math.Pow(r, 3):F2} см^3");
        }
    }
}
