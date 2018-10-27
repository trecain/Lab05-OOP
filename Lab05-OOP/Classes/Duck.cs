using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP.Interfaces;

namespace Lab05_OOP.Classes
{
    public class Duck : Raccoon, ISun
    {
        /// <summary>
        /// Duck constructor and raccoon inheritance
        /// </summary>
        /// <param name="name"></param>
        /// <param name="legs"></param>
        /// <param name="speech"></param>
        /// <param name="rabiesLevel"></param>
        /// <param name="eatsTrash"></param>
        public Duck (string name, int legs, string speech, int rabiesLevel, bool eatsTrash ) : base(name, legs, speech, rabiesLevel, eatsTrash)
        {

        }
        

        /// <summary>
        /// returns true for bitesomeone method on class
        /// </summary>
        /// <returns></returns>
        public override bool BiteSomeone()
        {
            Console.WriteLine("Chomp, chomp, chomp");
            return true;
        }


        /// <summary>
        /// sets sun bathe property to true
        /// </summary>
        public bool SunBathes { get; set; } = true; 


        /// <summary>
        /// bathes method that returns string
        /// </summary>
        /// <returns></returns>
        public string Bathes()
        {
            Console.WriteLine("Feel that sun on my skin");
            return "Soaking those rays up";
        }
    }
}
