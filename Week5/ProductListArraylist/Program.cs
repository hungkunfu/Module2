using System;

namespace ProductListArraylist
{
    class Program
    {
        // public 
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            // Product p = new Product();
            // shop.AddProduct(p);
            // shop.ShowProductlist();
            // shop.Remove();
            // shop.ShowProductlist();
            int choice;
            while (true)
            {
                System.Console.WriteLine("=====menu=====");
                System.Console.WriteLine("1 Add");
                System.Console.WriteLine("2. showlist");
                System.Console.WriteLine("3. remove");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Product p = new Product();
                        shop.AddProduct(p);
                        break;
                    case 2:
                        shop.ShowProductlist();
                        break;
                    case 3:
                        shop.Remove();
                        shop.ShowProductlist();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;


                }
            }
        }
    }
}
