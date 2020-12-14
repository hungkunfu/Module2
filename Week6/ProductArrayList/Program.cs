using System;

namespace ProductArrayList
{
    class Program
    {
        public static Shop shop = new Shop();
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                System.Console.WriteLine("=======MENU=======");
                System.Console.WriteLine("1. Them sp ");
                System.Console.WriteLine("2. Hien thi Sp");
                System.Console.WriteLine("3. Xoa sp ");
                System.Console.WriteLine("4. Tim kiem sp ");
                System.Console.WriteLine("5. Exit");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Product p = new Product();
                        shop.AddProduct(p);
                        break;
                    case 2:
                        System.Console.WriteLine("Danh sach sp ");
                        shop.ShowProduct();
                        break;
                    case 3:
                        shop.Remove();
                        System.Console.WriteLine("Danh sach sp da xoa");
                        shop.ShowProduct();
                        break;
                    case 4:
                        shop.Search();
                        System.Console.WriteLine("danh sach sp sau khi tim kiem");
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
