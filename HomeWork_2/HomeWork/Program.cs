using System;

namespace HomeWork2
{
    class Program
    {
        enum HTTPError
        {
            BadRequest = 400,
            Unauthorized,
            PaymentRequired,
            Forbidden,
            NotFound
        };
        static void ChoseError()
        {
            Console.WriteLine("Введіть номер помилки (400 - BadRequest, 401 - Unauthorized, 402 - PaymentRequired, 403 - Forbidden, 404 - NotFound): ");
            int err = Convert.ToInt32(Console.ReadLine());

            if (Enum.IsDefined(typeof(HTTPError), err))
            {
                Console.WriteLine("Ви ввели: {0}", Enum.GetName(typeof(HTTPError), err));
            }
            else 
            {
                Console.WriteLine("Спробуйте ще раз!");
            }

        }

        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public override string ToString()
            {
                return string.Format($"Собаку звати {name}, порода {mark}, вік {age} років.");
            }
        }


        static void Main(string[] args)
        {
            //1
            Console.Write("Введіть перше число: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write((a >= -5) && (a <= 5) ? "Введіть друге число: " : "Число не підходить");
            float b = float.Parse(Console.ReadLine());
            Console.Write((b >= -5) && (b <= 5) ? "Введіть третє число: " : "Число не підходить");
            float с = float.Parse(Console.ReadLine());
            Console.Write((с >= -5) && (с <= 5) ? "Дякую!" : "Число не підходить");

            //2.1
            Console.WriteLine("Введіть три числа: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((a >= b) && (a >= c) ? $"Число {a} - max" :
                              (b >= a) && (b >= c) ? $"Число {b} - max" :
                              (c >= a) && (c >= b) ? $"Число {c} - max" : "Спробуйте ще раз!");

            Console.WriteLine((a <= b) && (a <= c) ? $"Число {a} - min" :
                              (b <= a) && (b <= c) ? $"Число {b} - min" :
                              (c <= a) && (c <= b) ? $"Число {c} - min" : "Спробуйте ще раз!");

            //2.2
            Console.WriteLine("Введіть три числа: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("max: {0}", Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("min: {0}", Math.Min(a, Math.Min(b, c)));

            //3
            ChoseError();

            //4
            Dog myDog;

            Console.Write("Введіть назву собаки: ");
            myDog.name = Console.ReadLine();

            Console.Write("Введіть породу собаки: ");
            myDog.mark = Console.ReadLine();

            Console.Write("Введіть вік собаки: ");
            myDog.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(myDog);
        }
    }
}
