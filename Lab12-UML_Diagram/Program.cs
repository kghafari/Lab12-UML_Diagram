using System;

namespace Lab12_UML_Diagram
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] characters = new GameCharacter[]
            {
               new Wizard("Dumbledore", 3, 9, 10, 6),
               new Wizard("Merlin", 3, 9, 10, 6),
               new Wizard("Gandalf", 3, 9, 10, 6),
               new Warrior("Conan the Barbarian", 25, 2, "Broadsword"),
               new Warrior("Mad Max", 25, 2, "Everything"),
            };

            foreach (var character in characters)
            {
                character.Play();
                Console.WriteLine();
            }

            
        }
    }
}
