using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_UML_Diagram
{
    class MagicUsingCharacter : GameCharacter
    {
        //field
        private int magicalEnergy;

        //prop
        public int MagicalEnergy { get; set; }

        //const

        //methods
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magic Energy: {MagicalEnergy}");
        }
    }
}
