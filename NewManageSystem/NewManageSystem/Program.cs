using System;

namespace NewManageSystem
{
    class Program
    {
        public static News news = new News();
       
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Menu menus = new Menu();
                menus.menu();
                Console.WriteLine();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertList();
                        break;
                    case 2:
                        Console.WriteLine("====Danh sach Tin tuc====");
                        ShowLists();
                        break;
                    case 3:
                        Console.WriteLine("===Ti le trung binh===");
                        SumList();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
           
        }
        public static void InsertList()
        {
            string title, author, content;
            DateTime publishdate;
            bool check;
           
            Console.Write("Nhap vao Tieu de : ");
            title = Console.ReadLine();
            do
            {
                Console.Write("Nhap vao Ngay xuat Ban: ");
                check = DateTime.TryParse(Console.ReadLine(), out publishdate);

            } while (!check);
            
            Console.Write("Nhap vao ten tac gia : ");
            author = Console.ReadLine();
            Console.Write("Nhap vao noi dung : ");
            content = Console.ReadLine();
             news.Insert(title, publishdate, author, content);
             
        }
        public static void ShowLists() 
        {
            news.Showlist();
        }
        public static void SumList()
        {
            news.Sum();
        }
       
    }

}
