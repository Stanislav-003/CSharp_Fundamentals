using System;

namespace HomeWork6
{
    class Program
    {
        //public static int Div(int number1, int number2) 
        //{
        //    return number1 / number2;
        //}

        public class BrokeNumberException : Exception
        {
            public BrokeNumberException(string message) : base(message) { }
        }

        public class TypeNumberException : Exception
        {
            public TypeNumberException(string message) : base(message) { }
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
                        throw new TypeNumberException("Введене значення не є цілим числом. Спробуйте ще раз!");
                    }

                    if (number < start || number > end || number <= backNumber)
                    {
                        throw new BrokeNumberException("Введене число виходить за рамки вказаного діапазону або менше за попереднє. Спробуйте ще раз!");
                    }

                    numbers[i] = number;
                    backNumber = number;
                }
                catch (TypeNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
                catch (BrokeNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
            }
            return numbers;
        }

        static void Main(string[] args)
        {

            #region HW_6.1
            bool goOut = true;

            while (goOut)
            {
                try
                {
                    Console.Write("Введіть перше число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введіть друге число: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Div(a, b));
                    goOut = false;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Введіть число типу Int32: " + e.Message);
                }
            }
            #endregion

            #region HW_6.2
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
                        Console.WriteLine("Початкове значення не може бути більше кінцевого. Спробуйте ще раз!\n");
                        continue;
                    }

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено невірний формат числа. Спробуйте ще раз!\n");
                }
            } while (true);


            try
            {
                int[] numbers = ReadNumber(startValue, endValue);

                Console.WriteLine("Ваші числа: ");
                foreach (int number in numbers)
                {
                    Console.Write(number + ", ");
                }
            }
            catch (TypeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (BrokeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

        }
    }
}
