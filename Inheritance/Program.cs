using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var pidgeon = new Bird();
            pidgeon.Beak = "Short and sharp";
            pidgeon.Food = "Worms";
            pidgeon.GroundAnimal = false;
            pidgeon.Name = "Ruby";
            pidgeon.Legs = 2;
            pidgeon.Eyes = 2;
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var lizard = new Reptile();
            lizard.Name = "Slizard";
            lizard.Legs = 4;
            lizard.GroundAnimal = true;
            lizard.Color = "Green";
            lizard.Eyes = 2;
            lizard.Habitat = "Desert";

            var pets = new Animal[] { pidgeon, lizard };
            foreach (var pet in pets)
            {
                Console.WriteLine($"Pet's Name: Goes by {pet.Name} and knows it's name!");
                Console.WriteLine($"How many legs?: It has {pet.Legs}.");
                Console.WriteLine($"How many eyes does it have?: It has {pet.Eyes} and great vision.");
                Console.WriteLine($"Is it a ground animal?: {pet.GroundAnimal}");
                Console.WriteLine("");
            }
        }
    }
}

