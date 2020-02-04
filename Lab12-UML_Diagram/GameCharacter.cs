using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_UML_Diagram
{
    class GameCharacter
    {
        //fields
        private string name;
        private int strength;
        private int intelligence;

        //properties
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        //constructors

        //methods
        public virtual void Play()
        { 
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Str: {Strength}");
            Console.WriteLine($"Int: {Intelligence}");
        }
    }
}
