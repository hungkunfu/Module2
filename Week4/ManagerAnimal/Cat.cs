namespace ManagerAnimal
{
    public class Cat : Animal
    {
        public Cat() { }
        private string speak;
        public Cat(string name, int age, string description, string speak) : base(name, age, description)
        {

            this.speak = speak;

        }
       
    }
}
    
