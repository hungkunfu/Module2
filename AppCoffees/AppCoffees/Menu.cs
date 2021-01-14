using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace AppCoffees
{
    class Menu
    {
        public static ManagementCoffee management = new ManagementCoffee();

        public static void MainCoffee()
        {
            
            int choice;
            bool check;
            while (true)
            {
                Console.WriteLine("COFFEE TRUNG NGUYÊN ");
                Console.WriteLine("1. Chọn Đồ Uống");
                Console.WriteLine("2. Thêm Đồ Uống");
                Console.WriteLine("3. Xóa Thức Uống");
                Console.WriteLine("4. Xóa Bàn");
                Console.WriteLine("5. Tính Tiền ");
                Console.WriteLine("6. Tìm kiếm ");
                Console.WriteLine("7. Hiển Thị Bàn Đang Sử Dụng");
                Console.WriteLine("8. Exit");
                Console.Write("Nhập vào lựa chọn ");
                check = int.TryParse(Console.ReadLine(), out choice);
                if (choice < 1 || choice > 8)
                {
                    Console.Clear();
                }
                switch (choice)
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
                            RemoveDrinkInTable();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            RemoveTable();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Pay();
                            break;
                        }

                    case 6:
                        {
                            Console.Clear();
                            Search();
                            break;
                        }
                    case 7:
                        {
                            Show();
                            break;
                        }
                    case 8:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        #region
        public static void Add()
        {
            Table table = new Table();
            Console.WriteLine("Nhập Bàn : ");
            table.TableID = Console.ReadLine();
            List<Order> order = new List<Order>();
            string yn;
            if (management.CheckTableId(table.TableID) == null)
            {
                do
                {

                    Console.WriteLine("Nhập Tên Thức Uống : ");
                    var nameDrink = Console.ReadLine();
                    Console.WriteLine("Nhập Giá: ");
                    var price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập Số Lượng : ");
                    var count = int.Parse(Console.ReadLine());
                    bool istrue = false;
                    foreach (Order item in order)
                    {
                        if (nameDrink.ToLower().Equals(item.NameDrink.ToLower()))
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
                            NameDrink = nameDrink,
                            Price = price,
                            Count = count
                        });
                    }
                    Console.WriteLine("Bạn Muốn Chọn Thức uống Thêm Không Y/N ? ");
                    yn = Console.ReadLine();
                }
                while (yn.Equals("Y"));
                management.NewOrder(new Table()
                {
                    TableID = table.TableID,
                    StartTime = DateTime.Now.ToString(),
                    orderlist = order
                });
            }
            else
            {
                Console.WriteLine("Bàn Đã Sử Dụng !");
            }

            management.Show();

        }
        public static void Update()
        {
            Table table = new Table();
            Console.WriteLine("Nhập Bàn : ");
            table.TableID = Console.ReadLine();
            if (management.CheckTableId(table.TableID) != null)
            {
                string yn;
                do
                {
                    Order order = new Order();
                    Console.WriteLine("Nhập Tên Thức Uống: ");
                    order.NameDrink = Console.ReadLine();
                    Console.WriteLine("Nhập Giá : ");
                    order.Price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập Số Lượng : ");
                    order.Count = int.Parse(Console.ReadLine());
                    management.Update(table.TableID, order);
                    management.Show();
                    Console.WriteLine("Bạn Muốn Chọn Thêm không  Y/N ");
                    yn = Console.ReadLine();
                }
                while (yn.ToLower().Equals("Y".ToLower()));
            }
            else
            {
                Console.WriteLine("Not found !!");
            }
        }

        public static void RemoveDrinkInTable()
        {
            Console.WriteLine("Nhập Table ID: ");
            var tableId = Console.ReadLine();
            if (management.CheckTableId(tableId) != null)
            {
                string yn;
                do
                {
                    Console.WriteLine("Nhập Tên Thức Uống: ");
                    var nameDrink = Console.ReadLine();
                    Console.WriteLine("Nhập Số Lượng : ");
                    var count = int.Parse(Console.ReadLine());
                    management.RemoveDrink(tableId, nameDrink, count);
                    management.Show();
                    Console.WriteLine("Bạn Muốn Chọn Thức uống Thêm Không Y/N ?  ");
                    yn = Console.ReadLine();
                }
                while (yn.ToLower().Equals("Y".ToLower()));
            }

        }
        public static void RemoveTable()
        {
            Console.WriteLine("Nhập Table ID: ");
            string tableId = Console.ReadLine();
            management.RemoveTableId(tableId);
            management.Show();

        }
        public static void Show()
        {
            management.Show();
        }
        public static void Pay()
        {
            Console.WriteLine("Nhập Table ID: ");
            string tableId = Console.ReadLine();
            Table item = management.CheckTableId(tableId);
            if (item != null)
            {
                Console.WriteLine("Nhập Tên Thu Ngân : ");
                item.ThuNgan = Console.ReadLine();
                item.EndTime = DateTime.Now.ToString();
            }
            management.Pay(tableId);

            management.RemoveTableId(tableId);
        }
        public static void Search()
        {
            Console.WriteLine("Nhập Table ID: ");
            string tableId = Console.ReadLine();
            management.Search(tableId);

        }
        public static void ShowBillOfDay()
        {
            management.ShowBill();
        }
        #endregion
    }
}




