namespace Abstract
{
    abstract class Animal
    {
        public int Numberoffeet;
        public Animal() { }
        public Animal(int legs)
        {
            Numberoffeet = legs;
        }
        public abstract string Move();
        public abstract string Speak();

    }
}