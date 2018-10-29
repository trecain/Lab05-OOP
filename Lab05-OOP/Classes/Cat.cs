using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public class Cat : DomesticatedAnimals
    {
        /// <summary>
        /// Type property
        /// </summary>
        public string Type { get; set; }


        /// <summary>
        /// Cat constructor that sets the type property
        /// </summary>
        /// <param name="name"></param>
        /// <param name="legs"></param>
        /// <param name="speech"></param>
        /// <param name="color"></param>
        /// <param name="type"></param>
        public Cat(string name, int legs, string speech, string color, string type) : base(name, legs, speech, color )
        {
            Type = type;
        }


        /// <summary>
        /// overrides the request food method and returns a string
        /// </summary>
        /// <returns></returns>
        public override string RequestFood()
        {
            string food = "Grub out";
            Console.WriteLine(food);
            return food;
        }
    }
}
