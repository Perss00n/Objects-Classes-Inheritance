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
    internal class Program
    {
        // Main method where the program starts
        static void Main(string[] args)
        {
            try
            {
                // Create two Dog objects with different attributes
                Dog dog1 = new Dog("Midas", "dog", "black", "Flatcoated Retriever", "male", 7);
                Dog dog2 = new Dog("Skip", "dog", "black", "Hunting Labrador", "female", 3);

                // Change the type of the first dog
                dog1.Type = "Parrot";

                // Display information about the first dog
                Console.WriteLine($"This is my {dog1.Type} {dog1.Name}! {(dog1.Gender == "male" ? "He" : "She")} is a {dog1.Gender} {dog1.Color} {dog1.Breed} aged {dog1.Age} years old. ");
                dog1.AnimalSound(); // Call method to display the sound the dog makes
                Console.WriteLine();

                // Display information about the second dog
                Console.WriteLine($"This is my {dog2.Type} {dog2.Name}! {(dog2.Gender == "male" ? "He" : "She")} is a {dog2.Gender} {dog2.Color} {dog2.Breed} aged {dog2.Age} years old. ");
                dog2.AnimalSound(); // Call method to display the sound the dog makes
            }
            catch (ArgumentException ex)
            {
                // Handle and display specific argument-related errors
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                // Handle and display general errors
                Console.WriteLine("Error! Something went wrong!");
            }

            Console.ReadLine(); // Wait for user to press Enter before ending the program
        }
    }
}

