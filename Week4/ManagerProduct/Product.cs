using System;
namespace ManagerProduct
{
    public class Product
    {
       private string name;
       public string Name
       {
           get { return name; }
           set { name = value; }
       }
               private string description;
        double price;
        private int[] rate;
        public Product() { }
        public Product(string name, string description, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price;

        }
        public string ViewInfo()
        {
            return $"{name}\t\t\t{description}\t\t\t{price}";
        }
    }
}