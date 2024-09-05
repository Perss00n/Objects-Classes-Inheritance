/*
Created By: Perss00n
Email: Perss00n@gmail.com
Discord: Perss00n
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ObjectsClassesTest
{
    internal abstract class Animal
    {
        ////// Fields /////
        private string name; // Name of the animal
        private string type; // Type of the animal
        private string color; // Color of the animal
        private int age; // Age of the animal
        ///// END OF FIELDS /////


        ///// CONSTRUCTORS /////
        // Constructor to initialize the animal with its name, type, color, and age
        public Animal(string name, string type, string color, int age)
        {
            this.name = name; // Set the name field
            this.type = type; // Set the type field
            this.color = color; // Set the color field
            this.age = age; // Set the age field
        }
        ///// END OF CONSTRUCTORS /////
        

        ///// GETTERS & SETTERS /////
        // Property for the animal's name with validation
        public string Name
        {
            get { return name; }
            set
            {
                name = ValidateInput(value, 1, 50, "name"); // Validate and set the name
            }
        }

        // Property for the animal's type with validation
        public string Type
        {
            get { return type; }
            set
            {
                type = ValidateInput(value, 2, 50, "type"); // Validate and set the type
            }
        }

        // Property for the animal's color with validation
        public string Color
        {
            get { return color; }
            set
            {
                color = ValidateInput(value, 3, 30, "color"); // Validate and set the color                              
            }
        }

        // Property for the animal's age with validation
        public int Age
        {
            get { return age; }
            set
            {
                age = ValidateAnimalAge(value, 0, 120); // Validate and set the age
            }
        }
        ///// END OF GETTERS AND SETTERS /////


        ///// METHODS /////
        // Abstract method that must be implemented by derived classes to define the animal's sound
        public abstract void AnimalSound();

        // A validation method that checks all input strings
        public static string ValidateInput(string input, int minLength, int maxLength, string fieldName)
        {
            // Trim the input to remove leading and trailing spaces
            input = input.Trim();

            // Replace multiple spaces with a single space
            input = Regex.Replace(input, @"\s+", " ");

            // Check if input is empty after trimming and replacing multiple spaces
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException($"Error! The animal {fieldName} can't be null or empty.");
            }

            // Check length constraints
            if (input.Length < minLength || input.Length > maxLength)
            {
                throw new ArgumentException($"Error! The animal {fieldName} must contain a minimum of {minLength} characters and a maximum of {maxLength}.");
            }

            // Only allow letters and single spaces. Check if input matches the pattern
            if (!Regex.IsMatch(input, @"^[a-zA-Z\s]+$"))
            {
                throw new ArgumentException($"Error! The animal {fieldName} can only contain alphabetic characters.");
            }

            return input; // Return the validated input
        }

        // Validate the animal's age
        public static int ValidateAnimalAge(int input, int minAge, int maxAge)
        {
            // Check if age is within valid range
            if (input < minAge || input > maxAge)
            {
                throw new ArgumentException($"Error! Please enter a valid age between {minAge} and {maxAge}.");
            }

            return input; // Return the validated age
        }

        ///// END OF METHODS /////
    }
}
