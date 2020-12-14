using System;
namespace QuanLiDanhSachProduct
{
    public class Shop
    {
        public Product[] productlist = new Product[0];
        public void AddProduct(string name, string desc, double price)
        {
            Product product = new Product(name, desc, price);
            Array.Resize(ref productlist, productlist.Length + 1);
            productlist[productlist.Length - 1] = product;
            System.Console.WriteLine("Name \t\t\t DESPRESSTION \t\t\t Price");
        }
        public void ShowProduct()
        {
            foreach (var product in productlist)
            {
                System.Console.WriteLine(product.ViewInfo());
            }
        }
        public void Remove(string name)
        {
            for (int i = 0; i < productlist.Length; i++)
            {
                if (productlist[i].Name == name)
                {
                    for (int j = i; j < productlist.Length - 1; j++)
                    {
                        productlist[j] = productlist[j + 1];
                    }
                    Array.Resize(ref productlist, productlist.Length - 1);
                }
            }
        }
    }
}