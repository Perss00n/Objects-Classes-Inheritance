using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsClassesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dog dog1 = new Dog("Midas", "dog", "black", "Flatcoated Retriever", "male", 7);
                Dog dog2 = new Dog("Skip", "dog", "black", "Hunting Labrador", "female", 3);

                dog1.Type = "Parrot";

                Console.WriteLine($"This is my {dog1.Type} {dog1.Name}! {(dog1.Gender == "male" ? "He" : "She")} is a {dog1.Gender} {dog1.Color} {dog1.Breed} aged {dog1.Age} years old. ");
                dog1.AnimalSound();
                Console.WriteLine();
                Console.WriteLine($"This is my {dog2.Type} {dog2.Name}! {(dog2.Gender == "male" ? "He" : "She")} is a {dog2.Gender} {dog2.Color} {dog2.Breed} aged {dog2.Age} years old. ");
                dog2.AnimalSound();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Something went wrong!");
            }

            Console.ReadLine();

        }
    }
}
