/*
Created By: Perss00n
Email: Perss00n@gmail.com
Discord: Perss00n
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsClassesTest
{
    internal class Dog : Animal
    {
        // Fields
        private string breed; // Breed of the dog
        private string gender; // Gender of the dog

        // Constructors
        // Initializes a new instance of the Dog class with specific attributes
        public Dog(string name, string type, string color, string breed, string gender, int age) 
            : base(name, type, color, age) // Calls the base class constructor
        {
            this.breed = breed; // Set the breed field
            this.gender = gender; // Set the gender field
        }

        // Getters & Setters
        // Property for the dog's breed with validation
        public string Breed
        {
            get { return breed; }
            set
            {
                breed = ValidateInput(value, 3, 30, "breed"); // Validate and set the breed
            }
        }

        // Property for the dog's gender with validation
        public string Gender
        {
            get { return gender; }
            set
            {
                value = value.Trim().ToLower(); // Trim spaces and convert to lowercase

                // Gender can only be Male or Female
                if (value != "male" && value != "female")
                {
                    throw new ArgumentException("Error! The dog can either be 'Male' or 'Female'.");
                }

                gender = value; // Set the gender
            }
        }

        // Methods
        // Override the abstract method from the Animal class to provide the dog's sound
        public override void AnimalSound() => Console.WriteLine("VOFFF!!!");
    }
}
