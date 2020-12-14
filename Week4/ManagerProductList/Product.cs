using System;
namespace ManagerProductList
{
    public class Product
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        double price;
        private string description;
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
            return $"{name} \t\t\t {description} \t \t\t {price}";
        }
    }
}