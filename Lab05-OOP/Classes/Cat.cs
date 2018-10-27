using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public class Cat : DomesticatedAnimals
    {
        public string Type { get; set; }

        public Cat(string name, int legs, string speech, string color, string type) : base(name, legs, speech, color )
        {
            Type = type;
        }

        public override string RequestFood()
        {
            string food = "Grub out";
            Console.WriteLine(food);
            return food;
        }
    }
}
