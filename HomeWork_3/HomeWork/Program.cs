using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.Write("Введіть будь-який рядок string: ");
            string text = Console.ReadLine();

            int a = 0;
            int o = 0;
            int i = 0;
            int e = 0;
            int n = 0;
            while (n < text.Length)
            {
                switch (char.ToLower(text[n]))
                {
                    case 'a':
                        a++;
                        break;

                    case 'o':
                        o++;
                        break;

                    case 'i':
                        i++;
                        break;

                    case 'e':
                        e++;
                        break;
                }
                n++;

                //if (text[n] == 'a')
                //{
                //    a++;
                //}
                //if (text[n] == 'o')
                //{
                //    o++;
                //}
                //if (text[n] == 'i')
                //{
                //    i++;
                //}
                //if (text[n] == 'e')
                //{
                //    e++;
                //}
                //n++;
            }
            Console.WriteLine($"Кількість букв а = {a}");
            Console.WriteLine($"Кількість букв o = {o}");
            Console.WriteLine($"Кількість букв i = {i}");
            Console.WriteLine($"Кількість букв e = {e}");

            //2.1
            Console.Write("Enter the month: ");
            string mounth = Console.ReadLine();
            Console.Write("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            switch (mounth.ToLower())
            {
                case "january":
                case "march":
                case "may":
                case "july":
                case "august":
                case "october":
                case "december":
                    Console.WriteLine("31");
                    break;
                case "april":
                case "june":
                case "september":
                case "november":
                    Console.WriteLine("30");
                    break;
                case "february":
                    if (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0))
                    {
                        Console.WriteLine("29");
                    }
                    else
                    {
                        Console.WriteLine("28");
                    }

                    //int daysInMonth = DateTime.DaysInMonth(year, 2);
                    //Console.WriteLine(daysInMonth);
                    break;
            }

            //2.2
            Console.Write("Введіть рік: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть місяць: ");
            int mounth = Convert.ToInt32(Console.ReadLine());

            int daysInMonth = System.DateTime.DaysInMonth(year, mounth);
            Console.WriteLine(daysInMonth);

            //3
            Console.WriteLine("Введіть 10 цілих чисел:");
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введіть елемент {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool sumOrMult = false;
            int mult = 1;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                if (array[i] < 0)
                {
                    sumOrMult = true;
                    for (int k = 5; k < 10; k++)
                    {
                        mult *= array[k];
                    }
                }
                sum += array[i];
            }

            if (sumOrMult == true)
            {
                Console.WriteLine(mult);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
