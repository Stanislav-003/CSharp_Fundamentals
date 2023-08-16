using System;

namespace HomeWork6
{
    class Program
    {
        public class MyException : Exception
        {
            public MyException(string message) : base(message) { }
        }

        public static int[] ReadNumber(int start, int end)
        {
            int[] numbers = new int[10];
            int backNumber = start - 1;

            Console.WriteLine($"Введіть 10 цілих чисел в діапазоні від {start} до {end}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{i + 1}: ");

                try
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int number))
                    {
                        throw new MyException("Введене значення не є цілим числом. Спробуйте ще раз!");
                    }

                    if (number < start || number > end || number <= backNumber)
                    {
                        throw new MyException("Введене число виходить за рамки вказаного діапазону або менше за попереднє. Спробуйте ще раз!");
                    }

                    numbers[i] = number;
                    backNumber = number;
                }
                catch (MyException ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
            }
            return numbers;
        }

        static void Main(string[] args)
        {
            int startValue;
            int endValue;

            do
            {
                try
                {
                    Console.Write("Введіть початкове значення діапазону: ");
                    startValue = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введіть кінцеве значення діапазону: ");
                    endValue = Convert.ToInt32(Console.ReadLine());

                    if (startValue > endValue)
                    {
                        throw new MyException("Початкове значення не може бути більше кінцевого. Спробуйте ще раз!\n");
                    }

                    break;
                }
                catch (MyException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);

            int[] numbers = ReadNumber(startValue, endValue);

            Console.WriteLine("\nВаші числа: ");
            //foreach (int number in numbers)
            //{
            //    Console.Write(number + ", ");
            //}
            //Console.WriteLine("");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                Console.Write((i < numbers.Length - 1) ? ", " : ".");
            }
        }
    }
}
