using System;
using System.Collections;
namespace ProductArrayList
{
    public class Shop
    {
        public ArrayList productlist = new ArrayList();
        public void AddProduct(Product p)
        {
            // Product product = new Product();
            System.Console.Write("Nhap vao Name: ");
            p.Name = Console.ReadLine();
            do
            {
                System.Console.Write("Nhap vao Gia: ");
                p.price = double.Parse(Console.ReadLine());
            } while (p.price < 0 || p.price > 100);
            System.Console.Write("Nhap vao Mo Ta: ");
            p.description = Console.ReadLine();
            productlist.Add(p);
        }
        public void ShowProduct()
        {
            foreach (Product p in productlist)
            {
                p.viewInfo();
            }
        }
        public void Remove()
        {
            bool check = false;
            System.Console.Write("Nhap vao Ten Ban muon xoa : ");
            string name = Console.ReadLine();
            foreach (Product p in productlist)
            {
                if (name.Equals(p.Name))
                {
                    check = true;
                    productlist.Remove(p);
                    // break;
                }
            }
            if (check == true)
            {
                System.Console.WriteLine("Da xoa thanh cong!!!");
            }
            else
            {
                System.Console.WriteLine("Khong co ten trong danh sach moi ban chon lai");
            }

        }
        public void Search()
        {
            System.Console.WriteLine("Nhap vao ten ban muon tim:");
            string name = Console.ReadLine();
            foreach (Product p in productlist)
            {
                if (name.Equals(p.Name))
                {
                    p.viewInfo();
                }
            }
        }
    }
}