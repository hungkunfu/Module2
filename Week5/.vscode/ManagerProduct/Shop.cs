
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Solution_Ex1_Prac2
{
    class Shop
    {
        ArrayList ProductList = new ArrayList();
        public void addProduct(Product p)
        {
            Console.Write("Nhap Vao Name: ");
            p.Name = Console.ReadLine();
            do
            {
                Console.Write("Nhap Vao Gia: ");
                p.Price = double.Parse(Console.ReadLine());
            } while (!(p.Price > 0 && p.Price <= 100));
            Console.Write("Nhap Vao Mo Ta: ");
            p.Description = Console.ReadLine();
            Console.Write("So Luong: ");
            int N = int.Parse(Console.ReadLine());
            p.Rate = new int[N];
            for (int i = 0; i < N; i++)
            {
                do
                {
                    Console.Write("Rate " + (i + 1) + ": ");
                    p.Rate[i] = int.Parse(Console.ReadLine());
                } while (!(p.Rate[i] >= 1 && p.Rate[i] <= 5));
            }
            ProductList.Add(p);
            
        }
        public void removeProduct()
        {
            bool search = false;
            Console.Write("Nhap vao ten Ban muon xoa: ");
            String name = Console.ReadLine();
            foreach (Product p in ProductList)
            {
                if (name.Equals(p.Name))
                {
                    search = true;
                    ProductList.Remove(p);
                    break;
                }
            }
            if (search == true)
                Console.WriteLine("Ban Da xoa Thanh cong!");
            else
                Console.WriteLine("Khong tim Thay!");
        }
        public void iterateProductList()
        {
            foreach (Product p in ProductList)
            {
                p.viewInfo();
                float averateRate = 0;
                foreach (int rate in p.Rate)
                {
                    averateRate += rate;
                }
                Console.WriteLine("Gia tri Trung binh: " + averateRate / p.Rate.Length);
            }
        }
        public void searchProduct()
        {
            double minPrice;
            double maxPrice;
            bool search = false;
            do
            {
                Console.Write("Please enter Min price: ");
                minPrice = double.Parse(Console.ReadLine());
            } while (!(minPrice > 0 && minPrice <= 100));
            do
            {
                Console.Write("Please enter Max price: ");
                maxPrice = double.Parse(Console.ReadLine());
            } while (!(minPrice <= 100 && maxPrice > minPrice));
            foreach (Product p in ProductList)
            {
                if (p.Price >= minPrice && p.Price <= maxPrice)
                {
                    search = true;
                    p.viewInfo();
                }
            }
            if (search == false)
            {
                Console.WriteLine("Khong tim thay");
            }
        }
    }
}
