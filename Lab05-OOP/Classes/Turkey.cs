using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public class Turkey : Lizard
    {
        /// <summary>
        /// Turkey constructor for inherited classes
        /// </summary>
        /// <param name="name"></param>
        /// <param name="legs"></param>
        /// <param name="speech"></param>
        /// <param name="color"></param>
        /// <param name="tail"></param>
        public Turkey(string name, int legs, string speech, string color, string tail) : base(name, legs, speech, color, tail)
        {

        }


        /// <summary>
        /// Method that returns true if a turkey can gobble
        /// </summary>
        /// <returns></returns>
        public bool Gobble()
        {
            Console.WriteLine("Gobble, gobble, gobble");
            return true;
        }


        /// <summary>
        /// Carnivore function that returns a false since turkey doesn't eat meat
        /// </summary>
        /// <returns></returns>
        public bool Carnivore()
        {
            Console.WriteLine("No way, I don't eat that");
            Sleep();
            return false;
        }
    }
}
