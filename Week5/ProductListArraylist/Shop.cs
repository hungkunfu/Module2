using System;
using System.Collections;
namespace ProductListArraylist
{
    public class Shop
    {
        ArrayList productList = new ArrayList();
        // public Product p = new Product();
        public void AddProduct(Product p)
        {

            System.Console.Write("Nhap vao Name:");
            p.Name = Console.ReadLine();
            System.Console.WriteLine("Nhap vao Gia");
            p.price = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap vao Mo ta:");
            p.description = Console.ReadLine();
            productList.Add(p);


        }
        public void ShowProductlist()
        {
            foreach (Product p in productList)
            {
                p.viewInfo();
            }
        }
        public void Remove()
        {
            bool check = false;
            System.Console.Write("Nhap ten ban muon xoa : ");
            string name = Console.ReadLine();
            foreach (Product p in productList)
            {
                if (name.Equals(p.Name))
                {
                    check = true;
                    productList.Remove(p);
                    break;
                }

            }
            if (check == true)
            {
                System.Console.WriteLine("xoa thanh cong");
            }

            else
            {
                System.Console.WriteLine("khong ton tai teen ");
            }


        }
    }
}
