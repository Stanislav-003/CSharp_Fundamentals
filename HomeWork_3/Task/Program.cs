using System;

namespace Task
{
    class Program
    {
        enum name { water, pepsi, coffee }

        static void choseName()
        {
            Console.WriteLine("Введіть назву напою (water, pepsi, coffee): ");
            string drink = Console.ReadLine();

            if (Enum.IsDefined(typeof(name), drink))
            {
                switch (drink.ToLower())
                {
                    case "water":
                        Console.WriteLine("Ви обрали воду, ціна 10грн");
                        break;
                    case "pepsi":
                        Console.WriteLine("Ви обрали пепсі, ціна 25грн");
                        break;
                    case "coffee":
                        Console.WriteLine("Ви обрали каву, ціна 40грн");
                        break;
                    default:
                        Console.WriteLine("Спробуйте ще раз!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Напій не знайдено!");
            }
        }

        static void Main(string[] args)
        {
            //1
            Console.Write("Введіть перше число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть останнє число: ");
            int lastNumber = Convert.ToInt32(Console.ReadLine());

            int allIteration = 0;
            for (int i = firstNumber; i <= lastNumber; i++)
            {
                if (i % 3 == 0)
                {
                    allIteration++;
                }
            }
            Console.WriteLine($"Всого чисел: {allIteration}");

            //2
            Console.WriteLine("Введіть будь-який текст: ");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
                i = i + 1;
            }

            //3.1
            Console.WriteLine("Введіть назву напою (Water, Pepsi, Coffee): ");
            string name = Console.ReadLine();

            switch (name.ToUpper())
            {
                case "WATER":
                    Console.WriteLine("Ви обрали воду, ціна 10грн");
                    break;
                case "PEPSI":
                    Console.WriteLine("Ви обрали пепсі, ціна 25грн");
                    break;
                case "COFFEE":
                    Console.WriteLine("Ви обрали каву, ціна 40грн");
                    break;
                default:
                    Console.WriteLine("Спробуйте ще раз!");
                    break;
            }

            //3.2
            choseName();

            //4
            Console.WriteLine("Введіть послідовність чисел: ");
            double sum = 0;
            double n = 0;
            while (true)
            {
                double num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    break;
                }
                sum = sum + num;
                n++;
            }
            Console.WriteLine($"Середнє арифметичне заданих чисел: {sum / n}");

            //5
            Console.Write("Введіть рік: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 100 != 0 || (year % 100 == 0 && year % 400 == 0)))
            {
                Console.WriteLine($"{year} - високосний рік");
            }
            else
            {
                Console.WriteLine($"{year} - невисокосний рік");
            }

            //6
            Console.Write("Введіть число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine(sum);

            //7
            int number = Convert.ToInt32(Console.ReadLine());

            bool Even = false;
            while (number > 0)
            {
                if ((number % 10) % 2 != 0)
                {
                    Even = true;
                    break;
                }
                number /= 10;
            }

            if (Even == true)
            {
                Console.WriteLine("Число містить непарні цифри");
            }
            else
            {
                Console.WriteLine("Число не містить непарні цифри");
            }
        }
    }
}
