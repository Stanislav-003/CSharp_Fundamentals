using System;

namespace Task2
{
    class Program
    {
        enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted };

        struct Color
        {
            public byte R;
            public byte G;
            public byte B;

            public override string ToString()
            {
                return string.Format("{0}, {1}, {2}", R, G, B);
            }
        }
        static void Main(string[] args)
        {
            //1
            Console.Write("Введіть день: ");
            int dayOfMounth = Convert.ToInt32(Console.ReadLine());
            Console.Write((dayOfMounth >= 1) && (dayOfMounth <= 31) ? "Введіть місяць: " : "Такого дня не існує!");
            int mounthOfYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((mounthOfYear >= 1) && (mounthOfYear <= 12) ? $"Сьогоднішня дата: {dayOfMounth}/{mounthOfYear}" : "Такого місяця не існує!");
            Console.WriteLine("");


            //2
            Console.Write("Введіть подвійне число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            a %= 1;
            a *= 10;
            int b = (int)a;
            a %= 1;
            a *= 10;
            int c = (int)a;
            Console.WriteLine($"Сума: {b + c}");
            Console.WriteLine("");


            //3
            Console.Write("Введіть годину: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((hour >= 00) && (hour <= 05) ? "Доброї ночі!" :
                              (hour >= 06) && (hour <= 12) ? "Доброго ранку!" :
                              (hour >= 13) && (hour <= 17) ? "Добрий день!" :
                              (hour >= 18) && (hour <= 23) ? "Добрий вечір!" : "Ви ввели неіснуючий час!");
            Console.WriteLine("");


            //4
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);


            //5
            Color color;
            color.R = 255;
            color.G = 255;
            color.B = 255;
            Console.WriteLine("White " + color);
            color.R = 0;
            color.G = 0;
            color.B = 0;
            Console.WriteLine("Black " + color);
        }
    }
}
