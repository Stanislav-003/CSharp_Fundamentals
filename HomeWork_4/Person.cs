using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_4
{
    class Person
    {
        private string name;
        private int birthYear;

        public string Name
        {
            get { return name; }
        }

        public int BirthYear
        {
            get { return birthYear; }
        }

        public Person()
        {
            name = "Stanislav";
            birthYear = 2003;
        }

        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            return age;
        }

        public static Person Input()
        {
            Console.Write("Введіть ім'я: ");
            string name = Console.ReadLine();
            Console.Write("Введіть рік народження: ");
            int birthYear = int.Parse(Console.ReadLine());
            Person person = new Person(name, birthYear);
            return person;
        }

        public void ChangeName()
        {
            if (Age() < 16)
            {
                name = "Дуже молодий";
            }
        }

        public override string ToString()
        {
            return $"Ім'я: {name}, Рік народження: {birthYear}";
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        public static bool operator ==(Person person1, Person person2)
        {
            return person1.Name == person2.Name;
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return person1.Name != person2.Name;
        }
    }
}
