using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class RadioPhone : IPhone
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
        public int RadiusAction { get; set; }
        public bool AnsweringMachine { get; set; }
        public RadioPhone(string name, string company, int price, int radiusAction, bool answeringMachine)
        {
            Name = name;
            Company = company;
            Price = price;
            RadiusAction = radiusAction;
            AnsweringMachine = answeringMachine;
        }
    }
}
