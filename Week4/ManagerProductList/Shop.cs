using System;
namespace ManagerProductList
{
    public class Shop
    {
        public Product[] productslist = new Product[0];
        public void AddProduct(string name, string desc, double price)
        {
            Product product = new Product(name, desc, price);
            Array.Resize(ref productslist, productslist.Length + 1);
            productslist[productslist.Length - 1] = product;
            System.Console.WriteLine("Name \t\t\t Description \t\t\t Price");

        }
        public void ShowProduct()
        {
            foreach (var item in productslist)
            {
                System.Console.Write(item.ViewInfo());
            }
        }
        public void Remove(string name)
        {
            for (int i = 0; i < productslist.Length; i++)
            {
                if (productslist[i].Name == name)
                {
                    for (int j = i; j < productslist.Length - 1; j++)
                    {
                        productslist[j] = productslist[j+1];
                    }
                    Array.Resize(ref productslist, productslist.Length - 1);
                }
            }
        }

    }
}