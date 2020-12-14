using System;
using System.Text;
namespace Tao_Danh_Sach_Shop
{
    public class Shop
    {
        public Product[] productsList = new Product[0];
        public void AddProduct(string name, string desc, int price)
        {

            Product product = new Product(name, desc, price);
            Array.Resize(ref productsList, productsList.Length + 1);
            productsList[productsList.Length - 1] = product;
            System.Console.WriteLine($"Name \t\t\t Description \t\t\t Price \t\t CalculatorRate");


        }

        public void RemoveProduct(string name)
        {
            for (int i = 0; i < productsList.Length; i++)
            {
                if (productsList[i].Names == name)
                {
                    for (int j = i; j < productsList.Length - 1; j++)
                    {
                        productsList[j] = productsList[j + 1];
                    }
                    Array.Resize(ref productsList, productsList.Length - 1);
                }

            }
        }
        public bool IsExitProduct(string name)
        {
            for (int i = 0; i < productsList.Length; i++)
            {
                if (productsList[i].Names == name)
                {
                    return false;
                }


            }
            return true;

        }
        public void SearchProduct(string name)
        {
            for (int i = 0; i < productsList.Length; i++)
            {
                if (productsList[i].Names == name)
                {
                    System.Console.Write(productsList[i].ViewInfo());

                }
            }
        }

    }
}