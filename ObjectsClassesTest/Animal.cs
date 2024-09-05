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
        private string name;
        private string type;
        private string color;
        private int age;
        ///// END OF FIELDS /////


        ///// CONSTRUCTORS /////
        public Animal(string name, string type, string color, int age)
            {
            this.name = name;
            this.type = type;
            this.color = color;
            this.age = age;
            }
        ///// END OF CONSTRUCTORS /////
        

        ///// GETTERS & SETTERS /////
        public string Name
        {
            get { return name; }
            set
            {
                name = ValidateInput(value, 1, 50, "name");
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                type = ValidateInput(value, 2, 50, "type");
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                color = ValidateInput(value, 3, 30, "color");                              
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
           age = ValidateAnimalAge(value, 0, 120);            
            }
        }
        ///// END OF GETTERS AND SETTERS /////


        ///// METHODS /////
        public abstract void AnimalSound();

        // A validation method that checks all inputs
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

            return input;
        }


        // Validate animals age
        public static int ValidateAnimalAge(int input, int minAge, int maxAge)
        {
            if (input < minAge || input > maxAge)
            {
                throw new ArgumentException($"Error! Please enter a valid age between {minAge} and {maxAge}.");
            }

            return input;
        }

        ///// END OF METHODS /////

    }
}
