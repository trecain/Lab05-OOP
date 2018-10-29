using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public class Eagle : Raccoon
    {
        /// <summary>
        /// constructor for eagle class and raccoon inherited class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="legs"></param>
        /// <param name="speech"></param>
        /// <param name="rabies"></param>
        /// <param name="eatsTrash"></param>
        public Eagle(string name, int legs, string speech, int rabies, bool eatsTrash) : base(name, legs, speech, rabies, eatsTrash)
        {

        }


        /// <summary>
        /// overrides bitesomeone method and returns true
        /// </summary>
        /// <returns></returns>
        public override bool BiteSomeone()
        {
            Console.WriteLine("Chomp, chomp, chomp");
            return true;
        }
    }
}
