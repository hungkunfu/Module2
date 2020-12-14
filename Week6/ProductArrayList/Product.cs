using System;
using System.Collections;
namespace ProductArrayList
{
    public class Product
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string description;
        public double price;
        public Product()
        {

        }
        public Product(string name, double price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;

        }
        public void viewInfo()
        {
            System.Console.WriteLine($"{name}\t\t\t{price}\t\t\t{description}");
        }

    }
}