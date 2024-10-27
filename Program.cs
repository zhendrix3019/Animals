using System;
using System.Collections.Generic;
using Animals.Interfaces;
using Animals.Models;
using Animals.Services;

namespace Animals
{
    class Program
    {
        private static FileOutput _outFile = new FileOutput("animals.txt");

        static void Main(string[] args)
        {
            List<ITalkable> zoo = new List<ITalkable>();

            // Lines to Replace Begin Here
            AnimalCreator creator = new AnimalCreator(zoo);
            creator.AddAnimal();
            // End Lines to Replace

            foreach (var thing in zoo)
            {
                PrintOut(thing);
            }

            _outFile.FileClose();

            // Reading from the file
            FileInput inData = new FileInput("animals.txt");
            string line;
            while ((line = inData.FileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            inData.FileClose();
        }

        public static void PrintOut(ITalkable p)
        {
            Console.WriteLine($"{p.Name} says={p.Talk()}");
            _outFile.FileWrite($"{p.Name} | {p.Talk()}");
        }
    }
}
