using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5._1
{
    class Plane : IFlyable
    {
        public string Mark { get; set; }
        public bool HighFly { get; set; }

        public Plane(string mark, bool highFly)
        {
            Mark = mark;
            HighFly = highFly;
        }

        public void Fly()
        {
            Console.WriteLine($"Літак {Mark} летить.\n");
        }
    }
}
