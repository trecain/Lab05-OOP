using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public abstract class DomesticatedAnimals : Animal
    {
        public string EyeColor { get; set; }

        public DomesticatedAnimals(string name, int legs, string speech, string eyeColor) : base(name, legs, speech)
        {
            EyeColor = eyeColor;
        }

        public abstract string RequestFood();
    }
}
