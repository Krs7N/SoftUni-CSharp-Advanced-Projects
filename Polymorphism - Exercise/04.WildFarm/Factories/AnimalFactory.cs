﻿using _04.WildFarm.Exceptions;
using _04.WildFarm.Factories.Contracts;
using _04.WildFarm.Models;
using _04.WildFarm.Models.Contracts;

namespace _04.WildFarm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public Animal CreateAnimal(string[] cmdArgs)
        {
            string type = cmdArgs[0];
            string name = cmdArgs[1];
            double weight = double.Parse(cmdArgs[2]);
            string fourthArg = cmdArgs[3];

            Animal animal;
            if (type == "Owl")
            {
                animal = new Owl(name, weight, double.Parse(fourthArg));
            }
            else if (type == "Hen")
            {
                animal = new Hen(name, weight, double.Parse(fourthArg));
            }
            else if (type == "Mouse")
            {
                animal = new Mouse(name, weight, fourthArg);
            }
            else if (type == "Dog")
            {
                animal = new Dog(name, weight, fourthArg);
            }
            else if (type == "Cat")
            {
                animal = new Cat(name, weight, fourthArg, cmdArgs[4]);
            }
            else if (type == "Tiger")
            {
                animal = new Tiger(name, weight, fourthArg, cmdArgs[4]);
            }
            else
            {
                throw new InvalidAnimalTypeException();
            }

            return animal;
        }
    }
}