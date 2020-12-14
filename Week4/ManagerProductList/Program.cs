using System;

namespace ManagerProductList
{

    class Program
    {
        public static Shop shop = new Shop();
        static void Main(string[] args)
        {
            string name, desc;
            double price;
            string names;
            System.Console.Write("Nhap vao Ten Sp : ");
            name = Console.ReadLine();
            System.Console.Write(" Nhap vao mo ta : ");
            desc = Console.ReadLine();
            System.Console.Write("Nhap vao gia :");
            price = double.Parse(Console.ReadLine());
            shop.AddProduct(name, desc, price);
            shop.ShowProduct();
            System.Console.WriteLine();
            System.Console.WriteLine("Nhap ten ban muon xoa sp");
            names = Console.ReadLine();
            shop.Remove(names);
            shop.ShowProduct();
        }
    }
}
