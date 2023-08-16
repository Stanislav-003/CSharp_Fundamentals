using System;

namespace HomeWork6._2
{
    class Program
    {
        public static int Div(int number1, int number2)
        {
            return number1 / number2;
        }

        static void Main(string[] args)
        {
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
        }
    }
}
