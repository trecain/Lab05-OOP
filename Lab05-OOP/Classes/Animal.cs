using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        private string Speech { get; set; }

        public Animal(string name, int legs, string speech)
        {
            Name = name;
            Legs = legs;
            Speech = speech;
        }

        public virtual string Sleep()
        {
            Console.WriteLine("ZZZZZZZzzzzzzzz");
            return "Goodnight";
        }

        public string UserSpeech()
        {
            return Speech;
        }
    }
}
