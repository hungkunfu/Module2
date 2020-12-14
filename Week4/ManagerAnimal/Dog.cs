namespace ManagerAnimal
{
    public class Dog : Animal
    {
         // override ghi de
        public Dog() { }
        private string speak;
        public Dog(string name, int age, string description, string speak) : base(name, age, description)
        {
            this.speak = speak;

        }
        // từ khóa new để che giâu lơp cha khi trùng tên method
        public override string ViewInfo()
        {

            return $"{base.ViewInfo()} \t\t {speak}";
        }

    }
}