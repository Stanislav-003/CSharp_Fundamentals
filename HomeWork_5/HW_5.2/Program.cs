using System;
using System.Collections.Generic;

namespace HomeWork5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> Dictionary = new Dictionary<uint, string>();

            int people = 7;
            for (int i = 0; i < people; i++)
            {
                Console.Write($"Введіть ID для {i + 1} людини: ");
                uint id = Convert.ToUInt32(Console.ReadLine());

                Console.Write($"Введіть ім'я для {i + 1} людини: ");
                string name = Console.ReadLine();

                Dictionary[id] = name;
            }

            Console.Write("Введіть ID відповідної людини: ");
            uint findId = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(Dictionary.TryGetValue(findId, out string Name) ? $"{Name}" : "Спробуйте ще раз!");
        }
    }
}
