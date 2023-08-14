using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5
{
    class Programmer : IDeveloper
    {
        public string Tool { get; set; }
        public string Language { get; set; }

        public Programmer(string language)
        {
            Language = language;
            Tool = "Комп'ютера";
        }

        public void Create()
        {
            Console.WriteLine($"Програміст, за допомогою {Tool}, створює код на мові {Language}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Програміст, за допомогою {Tool}, видаляє код на мові {Language}");
        }
    }
}

