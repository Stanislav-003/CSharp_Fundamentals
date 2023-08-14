using System;
using System.Collections.Generic;

namespace Task_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> flyingObjects = new List<IFlyable>();

            
            flyingObjects.Add(new Bird("Перепілка", true));
            flyingObjects.Add(new Plane("Boeing 747", true));
            flyingObjects.Add(new Bird("Фазан", true));
            flyingObjects.Add(new Plane("Airbus A380", true));
            flyingObjects.Add(new Bird("Гуска", true));
            flyingObjects.Add(new Plane("Стінгер", true));
            flyingObjects.Add(new Bird("Морянка", true));
            flyingObjects.Add(new Plane("Гострайдер", true));
            flyingObjects.Add(new Bird("Фламінго", true));
            flyingObjects.Add(new Plane("Віджет", true));


            foreach (var flyingObject in flyingObjects)
            {
                flyingObject.Fly();
            }
        }
    }
}
