using System;
using System.Collections;
namespace ManagerAnimal
{
    public class Cage
    {
        public Tiger[] tigers = new Tiger[0];
        public Animal[] animalList = new Animal[0];
        public void AddAnimals(string name, int age, string description, string speak)
        {
            Tiger tiger = new Tiger(name, age, description, speak);
            Array.Resize(ref animalList, animalList.Length + 1);
            animalList[animalList.Length - 1] = tiger;
            System.Console.WriteLine("Name\t\t\tAGE\t\t\tdescription\t\t\tSpeak");

         }
        public void Show()
        {
            foreach (var tiger in tigers)
            {
            System.Console.WriteLine(tiger.ViewInfo());
            }
        }

        public void AddAnimal(string name, int age, string description)
        {
            Animal animals = new Animal(name, age, description);
            Array.Resize(ref animalList, animalList.Length + 1);
            animalList[animalList.Length - 1] = animals;
            System.Console.WriteLine("Name\t\t\tAGE\t\t\tdescription");

        }
        public void Remove(string name)
        {
            for (int i = 0; i < animalList.Length; i++)
            {
                if (animalList[i].Name == name)
                {
                    for (int j = i; j < animalList.Length - 1; j++)
                    {
                        animalList[j] = animalList[j + 1];
                    }
                    Array.Resize(ref animalList, animalList.Length - 1);
                }
            }
        }
        public void ShowAnimalList()
        {
            foreach (var animal in animalList)
            {
                System.Console.WriteLine(animal.ViewInfo());
            }
        }

    }
}