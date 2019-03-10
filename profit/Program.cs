using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[10];
            Animal animal = null;
            for (int i = 0; i < animals.Length; i++)
            {
                animal = new Animal(123,22.4,"cow");
                animals[i] = animal;
            }
            Animal nwe = new Animal();
            return;
        }
    }
}
