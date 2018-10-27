using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public abstract class DomesticatedAnimals : Animal
    {
        /// <summary>
        /// sets eyecolor property for abstract class
        /// </summary>
        public string EyeColor { get; set; }


        /// <summary>
        /// constructor for domesticatedanimals abstract class and sets eye color
        /// </summary>
        /// <param name="name"></param>
        /// <param name="legs"></param>
        /// <param name="speech"></param>
        /// <param name="eyeColor"></param>
        public DomesticatedAnimals(string name, int legs, string speech, string eyeColor) : base(name, legs, speech)
        {
            EyeColor = eyeColor;
        }

        /// <summary>
        /// abstract request foods method
        /// </summary>
        /// <returns></returns>
        public abstract string RequestFood();
    }
}
