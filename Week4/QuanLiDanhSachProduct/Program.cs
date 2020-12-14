using System;

namespace QuanLiDanhSachProduct
{
    class Program
    {
        public static Shop shop = new Shop();
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                System.Console.WriteLine("=========MENU========");
                System.Console.WriteLine("1 -- ADD SP ");
                System.Console.WriteLine("2 -- SHOW SP");
                System.Console.WriteLine("3 -- REMOVE SP");
                System.Console.WriteLine("4 -- Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        System.Console.WriteLine("---------Danh sach san Pham hien co----------");
                        shop.ShowProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public static void AddProduct()
        {
            string name, desc;
            double price;
            System.Console.Write("Nhap vao ten sp :");
            name = Console.ReadLine();
            System.Console.Write("Nhap vao mo ta : ");
            desc = Console.ReadLine();
            System.Console.Write("Nhap vap gia tien :");
            price = double.Parse(Console.ReadLine());
            shop.AddProduct(name, desc, price);
            System.Console.WriteLine();
        }
        public static void DeleteProduct()
        {
            string name;
            System.Console.Write("Nhap vao ten sp Ban muon xoa : ");
            name = Console.ReadLine();
            shop.Remove(name);
        }
    }
}
