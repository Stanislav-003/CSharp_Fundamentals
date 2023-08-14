using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5._1
{
    class Bird : IFlyable
    {
        public string Name { get; set; }
        public bool CanFly { get; set; }
        public Bird(string name, bool canFly)
        {
            Name = name;
            CanFly = canFly;
        }

        public void Fly()
        {
            Console.WriteLine($"Птах {Name} летить.");
        }
    }
}
