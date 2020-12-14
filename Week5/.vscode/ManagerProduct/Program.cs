
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution_Ex1_Prac2
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("1. Add new Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Iterate product list");
            Console.WriteLine("4. Search product");
            Console.WriteLine("5. Exit");
        }
        static void Main(string[] args)
        {
            int choice;
            Shop shop = new Shop();
            Menu();
            while (true)
            {
                Console.Write("Please choose an item: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Product p = new Product();
                        shop.addProduct(p);
                        break;
                    case 2:
                        shop.removeProduct();
                        break;
                    case 3:
                        shop.iterateProductList();
                        break;
                    case 4:
                        shop.searchProduct();
                        break;
                    case 5: return;
                }
            }
        }
    }
}
