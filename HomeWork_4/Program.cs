using System;

namespace HomeWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Output();

            Person person1 = new Person("Andriy", 2000);
            person1.Output();

            Person[] people = new Person[6];
            people[0] = person;
            people[1] = person1;

            for (int i = 2; i < people.Length; i++)
            {
                people[i] = Person.Input();
            }

            Console.WriteLine("\nІнформація про людей:");

            for (int i = 0; i < people.Length; i++)
            {
                people[i].Output();
                Console.WriteLine($"Вік: {people[i].Age()} років");
            }

            Console.WriteLine("\nЗміна імен для людей з віком менше 16:");

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Age() < 16)
                {
                    people[i].ChangeName();
                }
            }

            Console.WriteLine("\nОновлена інформація про людей:");

            for (int i = 0; i < people.Length; i++)
            {
                people[i].Output();
            }

            Console.WriteLine("\nЛюди з однаковими іменами:");

            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"Людина {i + 1} та людина {j + 1} мають однакове ім'я: {people[i].Name}");
                    }
                }
            }
        }
    }
}
