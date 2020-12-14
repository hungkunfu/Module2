using System;

namespace Tao_Danh_Sach_Shop
{
    class Program
    {
        public static Shop shop = new Shop();
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Menu menu = new Menu();
                menu.MenuList();
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreateProduct();
                        ShowProduct();
                        break;
                    case 2:
                        Remove();
                        break;
                    case 4:

                        Search();
                        System.Console.WriteLine();

                        break;

                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }


        }

        // show sp ra 
        private static void ShowProduct()
        {
            foreach (var product in shop.productsList)
            {
                System.Console.WriteLine(product.ViewInfo());
            }
        }

        // add them sp vào
        private static void CreateProduct()
        {
            string name;
            string desc;
            int price;
            System.Console.Write("Nhap vao ten SP : ");
            name = Console.ReadLine();
            if (shop.IsExitProduct(name))
            {
                System.Console.Write("Nhap vao description : ");
                desc = Console.ReadLine();
                System.Console.Write("Nhap vao  price :");
                price = Int32.Parse(Console.ReadLine());
                shop.AddProduct(name, desc, price);
            }
            else
            {
                System.Console.WriteLine(" Them san Pham Da trung Moi Nhap lai");
            }



        }
        // xóa sp
        private static void Remove()
        {
            string name;

            System.Console.Write("Nhap vao ten SP muon xoa : ");
            name = Console.ReadLine();
            shop.RemoveProduct(name);
            ShowProduct();
        }
        // tìm kiếm sản phẩm1
        private static void Search()
        {
            string names;
            System.Console.WriteLine("Nhap vao ten can tim ");
            names = Console.ReadLine();
            shop.SearchProduct(names);

        }
        // iterate product 

    }
}
