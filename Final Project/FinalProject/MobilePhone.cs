using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class MobilePhone : IPhone
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public int MemorySize { get; set; }
        public MobilePhone(string name, string company, int price, string color, int memorySize)
        {
            Name = name;
            Company = company;
            Price = price;
            Color = color;
            MemorySize = memorySize;
        }
    }
}
