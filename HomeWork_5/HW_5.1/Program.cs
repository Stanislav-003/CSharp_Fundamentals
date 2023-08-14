using System;
using System.Collections.Generic;


namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>
            {
                new Programmer("C#"),
                new Programmer("HTML"),
                new Builder("Молоток"),
                new Builder("Топор")
            };

            foreach (var developer in developers)
            {
                developer.Create();
                developer.Destroy();
                Console.WriteLine();
            }
        }
    }
}
