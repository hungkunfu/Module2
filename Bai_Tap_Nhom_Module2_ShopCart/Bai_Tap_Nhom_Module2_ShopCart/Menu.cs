using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap_Nhom_Module2_ShopCart
{
    class Menu
    {
        public static Management management = new Management();

        public static void CreateMenu(out int selected)
        {
            do
            {
                Console.WriteLine("FORUM MANAGEMENT SHOP");
                Console.WriteLine("1. Add Gio Hang ");
                Console.WriteLine("2. Update Gio Hang ");

                Console.WriteLine("3. Remove Cart.");
                Console.WriteLine("4. Pay");
                Console.WriteLine("5. Search");
                Console.WriteLine("6. Exit");

                Console.Write("Please select an option :  ");
                int.TryParse(Console.ReadLine(), out selected);
                if (selected < 1 || selected > 7)
                {
                    Console.Clear();
                }
            }
            while (selected < 1 || selected > 7);

        }

        public static void Process()
        {
            int selected = 0;
            do
            {
                CreateMenu(out selected);
                switch (selected)
                {
                    case 1:
                        {
                            Console.Clear();
                            Add();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Update();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            RemoveCart();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Pay();
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            Search();
                            break;
                        }
                    case 6:
                        Environment.Exit(0);
                        break;

                }
            }
            while (selected != 6);
        }
        public static void Add()
        {
            Cart carts = new Cart();
            Console.WriteLine("Chon Gio Hang : ");
            carts.cartID = Console.ReadLine();
            List<Order> order = new List<Order>();
            string yn;
            if (management.CheckCartID(carts.cartID) == null)
            {
                do
                {

                    Console.WriteLine("Nhập Tên Sản Phẩm : ");
                    var namesp = Console.ReadLine();
                    Console.WriteLine("Nhập Price: ");
                    var price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập Count: ");
                    var count = int.Parse(Console.ReadLine());
                    bool istrue = false;
                    foreach (Order item in order)
                    {
                        if (namesp.ToLower().Equals(item.NameSP.ToLower()))
                        {
                            item.Count += count;
                            istrue = true;
                            break;
                        }
                    }
                    if (!istrue)
                    {
                        order.Add(new Order()
                        {
                            NameSP = namesp,
                            Price = price,
                            Count = count
                        });
                    }
                    Console.WriteLine("Enter Continue Y/N ");
                    yn = Console.ReadLine();
                }
                while (yn.ToLower().Equals("Y".ToLower()));
                management.NewOrder(new Cart()
                {
                    cartID = carts.cartID,
                    StarTime = DateTime.Now.ToString(),
                    OrderList = order
                });
            }
            else
            {
                Console.WriteLine("Cart Da su dung !");
            }

            management.Show();

        }
        public static void Update()
        {
            Cart cart = new Cart();
            Console.WriteLine("Nhập Gio Hang Can them: ");
            cart.cartID = Console.ReadLine();
            if (management.CheckCartID(cart.cartID) != null)
            {
                string yn;
                do
                {
                    Order order = new Order();
                    Console.WriteLine("Nhập Name Sp : ");
                    order.NameSP = Console.ReadLine();
                    Console.WriteLine("Nhập Price: ");
                    order.Price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập Count: ");
                    order.Count = int.Parse(Console.ReadLine());
                    management.Update(cart.cartID, order);
                    management.Show();
                    Console.WriteLine("Enter Continue Update Y/N ");
                    yn = Console.ReadLine();
                }
                while (yn.ToLower().Equals("Y".ToLower()));
            }
            else
            {
                Console.WriteLine("Not found !!");
            }
        }


        public static void RemoveCart()
        {
            Console.WriteLine("Nhập giỏ hàng: ");
            string tableId = Console.ReadLine();
            management.RemoveCartID(tableId);
            management.Show();

        }
        public static void Show()
        {
            management.Show();
        }
        public static void Pay()
        {
            Console.WriteLine("Nhập Gio Hang Can Thanh Toan: ");
            string cartid = Console.ReadLine();
            Cart item = management.CheckCartID(cartid);
            if (item != null)
            {
                Console.WriteLine("Nhập Cashier: ");
                item.Cashier = Console.ReadLine();
                item.EndTime = DateTime.Now.ToString();
            }
            management.Pay(cartid);
            management.RemoveCartID(cartid);
        }
        public static void Search()
        {
            Console.WriteLine("Nhập Giỏ Hàng: ");
            string tableId = Console.ReadLine();
            management.Search(tableId);

        }
    }
}
