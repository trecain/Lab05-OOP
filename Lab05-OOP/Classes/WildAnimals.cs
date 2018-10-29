using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public abstract class WildAnimals : Animal
    {
        /// <summary>
        /// sets rabies level propery
        /// </summary>
        public int RabiesLevel { get; set; }


        /// <summary>
        /// wild animals object constructor, which also sets the rabies level
        /// </summary>
        /// <param name="name"></param>
        /// <param name="legs"></param>
        /// <param name="speech"></param>
        /// <param name="rabies"></param>
        public WildAnimals(string name, int legs, string speech, int rabies) : base(name, legs, speech)
        {
            RabiesLevel = rabies;
        }


        /// <summary>
        /// sets abstract method and returns a boolean
        /// </summary>
        /// <returns></returns>
        public abstract bool BiteSomeone();
    }
}
