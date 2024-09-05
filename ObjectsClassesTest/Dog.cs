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
        private string breed;
        private string gender;

        // Constructors
        public Dog(string name, string type, string color, string breed, string gender, int age) : base(name, type, color, age)
            {
            this.breed = breed;
            this.gender = gender;
            }

        // Getters & Setters
        public string Breed
        {
            get { return breed; }
            set
            {
               breed = ValidateInput(value, 3, 30, "breed");
               
            }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                value = value.Trim().ToLower();

                // Gender can only be Male or Female
                if (value != "male" && value != "female")
                {
                    throw new ArgumentException("Error! The dog can either be 'Male' or 'Female'.");
                }

                gender = value;                
            }
        }

        // Methods
        public override void AnimalSound() => Console.WriteLine("VOFFF!!!");
    }
}
