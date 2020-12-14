namespace ManagerAnimal
{
    public class Tiger : Animal
    {
        public Tiger() { }
        private string speak;
        public Tiger(string name, int age, string description, string speak) : base(name, age, description)
        {
            this.speak = speak;
            // ghi de len thong tin lop cha
            // base.ViewInfo();
        }
        public override string ViewInfo()
        {
            return $"{base.ViewInfo()} \t\t {speak}";

        }
    }

}
