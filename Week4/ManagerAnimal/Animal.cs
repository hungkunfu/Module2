using System;
using System.Collections;
namespace ManagerAnimal
{
    public class Animal
    {
        public string name;
        // public Type type;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int age;
        public string description;
        public Animal() { }
        public Animal(int age)
        {
            this.age = age;

        }
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Animal(string name, int age, string description )
        {
            this.name = name;
            this.age = age;
            this.description = description;
        }
        public virtual string ViewInfo()
        {
            return $"{name} \t\t\t {age} \t\t\t {description}";
        }
        public virtual string Speak(){
            return "";
        }

    }
       
    }
    