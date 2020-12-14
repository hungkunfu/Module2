using System;

namespace ManagerProduct
{
    class Program
    {
        public static Shop shop = new Shop();
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Menu menus = new Menu();
                System.Console.WriteLine();
                menus.menu();
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        System.Console.WriteLine("=======Danh sach SP======");
                        // ShowProductList();
                        ADDProductList();
                        break;
                    case 2:
                        shop.ShowProduct();
                        break;
                    case 3:
                        System.Console.WriteLine("Danh Sach SP ban da xoa");
                        Delete();
                        break;
                    case 4:
                        System.Console.WriteLine("=========Danh sach sp ban tim ========");
                        SearchProduct();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public static void ADDProductList()
        {
            string name, decs;
            double price;
            System.Console.Write("Nhap vao Ten SP : ");
            name = Console.ReadLine();
            System.Console.Write("Nhap vao Mo Ta : ");
            decs = Console.ReadLine();
            System.Console.Write("Nhap vao Gia ");
            price = double.Parse(Console.ReadLine());
            shop.AddProductlist(name, decs, price);
        }
        public static void Delete()
        {

            string name;
            System.Console.Write("Nhap vao Ten SP Muon DELETE:");
            name = Console.ReadLine();
            shop.Remove(name);
            shop.ShowProduct();
        }
        public static void SearchProduct()
        {
            string name;
            System.Console.Write("Nhap vao Ten SP Muon Tim:");
            name = Console.ReadLine();
            System.Console.WriteLine();
            shop.Search(name);
        }
    }
}
