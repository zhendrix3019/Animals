using System;
using System.Collections.Generic;
using Animals.Interfaces;
using Animals.Models;

namespace Animals.Services
{
    public class AnimalCreator
    {
        private List<ITalkable> _animalList;

        public AnimalCreator(List<ITalkable> animalList)
        {
            _animalList = animalList;
        }

        public void AddAnimal()
        {
            Console.Write("What type of animal would you like to create (Dog/Cat/Teacher)? ");
            string animalType = Console.ReadLine();

            try
            {
                switch (animalType.Trim().ToLower())
                {
                    case "dog":
                        CreateDog();
                        break;
                    case "cat":
                        CreateCat();
                        break;
                    case "teacher":
                        CreateTeacher();
                        break;
                    default:
                        Console.WriteLine("Invalid animal type entered.");
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void CreateDog()
        {
            Console.Write("Enter the dog's name: ");
            string name = Console.ReadLine();

            Console.Write("Is the dog friendly (true/false)? ");
            string friendlyInput = Console.ReadLine();
            if (!bool.TryParse(friendlyInput, out bool isFriendly))
            {
                throw new FormatException("Friendly must be 'true' or 'false'.");
            }

            Dog dog = new Dog(isFriendly, name);
            _animalList.Add(dog);
            Console.WriteLine("Dog added successfully.");
        }

        private void CreateCat()
        {
            Console.Write("Enter the cat's name: ");
            string name = Console.ReadLine();

            Console.Write("How many mice has the cat killed? ");
            string miceKilledInput = Console.ReadLine();
            if (!int.TryParse(miceKilledInput, out int miceKilled))
            {
                throw new FormatException("Mice killed must be a number.");
            }

            Cat cat = new Cat(miceKilled, name);
            _animalList.Add(cat);
            Console.WriteLine("Cat added successfully.");
        }

        private void CreateTeacher()
        {
            Console.Write("Enter the teacher's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the teacher's age: ");
            string ageInput = Console.ReadLine();
            if (!int.TryParse(ageInput, out int age))
            {
                throw new FormatException("Age must be a number.");
            }

            Teacher teacher = new Teacher(age, name);
            _animalList.Add(teacher);
            Console.WriteLine("Teacher added successfully.");
        }
    }
}
