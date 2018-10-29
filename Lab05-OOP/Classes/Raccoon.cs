using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public abstract class Raccoon : WildAnimals
    {
        /// <summary>
        /// Gets and sets eats trash property
        /// </summary>
        public bool EatsTrash { get; set; }

        /// <summary>
        /// Raccoon constructor that sets eatstrash property with boolean
        /// </summary>
        /// <param name="name"></param>
        /// <param name="legs"></param>
        /// <param name="speech"></param>
        /// <param name="rabies"></param>
        /// <param name="eatsTrash"></param>
        public Raccoon(string name, int legs, string speech, int rabies, bool eatsTrash) : base(name, legs, speech, rabies )
        {
            EatsTrash = eatsTrash;
        }


        /// <summary>
        /// returns true that a raccoon can scratch
        /// </summary>
        /// <returns>returns bool</returns>
        public bool CanScratch()
        {
            return true;
        }


        /// <summary>
        /// returns string of raccoon sleeping
        /// </summary>
        /// <returns></returns>
        public override string Sleep()
        {
            Console.WriteLine("Goodnight");
            return "zzzzzzzzzZZZZZZZZ";
        }
    }
}
