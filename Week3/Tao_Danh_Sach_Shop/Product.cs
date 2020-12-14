using System;
namespace Tao_Danh_Sach_Shop
{
    public class Product
    {
        private string name;
        public string Names => name;
        private string description;
        double price;
        int[] rate = new int[0];
        public Product(string name, string description, int price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
       
        }

        public string ViewInfo()
        {
            return ($"{name}\t\t {description} \t\t\t  {price} \t\t\t  {CalculatorRate()}  ");
        }
        private double CalculatorRate()
        {
            int total = 0;

            if (rate.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < rate.Length; i++)
            {
                total += rate[i];
            }
            return total / rate.Length;
        }
        

    }
}




