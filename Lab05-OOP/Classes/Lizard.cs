using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP.Interfaces;

namespace Lab05_OOP.Classes
{
    public abstract class Lizard : DomesticatedAnimals
    {
        /// <summary>
        /// sets tailcolor property
        /// </summary>
        public string TailColor { get; set; }

        /// <summary>
        /// Lizard constructor, with tailcolor param
        /// </summary>
        /// <param name="name"></param>
        /// <param name="legs"></param>
        /// <param name="speech"></param>
        /// <param name="color"></param>
        /// <param name="tail"></param>
        public Lizard(string name, int legs, string speech, string color, string tail) : base(name, legs, speech, color)
        {
            TailColor = tail;
        }


        /// <summary>
        /// overrides and seals request food method
        /// </summary>
        /// <returns></returns>
        public override sealed string RequestFood()
        {
            string res = "*stomach growling* I'm hungry.";
            return res;
        }


        /// <summary>
        /// overrides the sleep method and returns a string
        /// </summary>
        /// <returns></returns>
        public override string Sleep()
        {
            Console.WriteLine("Knocked out");
            return "Knocked out";
        }
    }
    
}
