
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution_Ex1_Prac2
{
    class Product
    {
        public String Name;
        public String Description;
        public double Price;
        public int[] Rate;
        public Product() { }
        public Product(string Name, string Description, double Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
        }
        public void viewInfo()
        {
            Console.WriteLine("Name: " + Name);
        
            Console.WriteLine("Price: " + Price);
  
            Console.WriteLine("Description: " + Description);
           
        }
    }
}
