using System;

namespace Bai_Tap_Collection_Generic
{
    class Program
    {
       public static Fourm fourm = new Fourm();
        static void Main(string[] args)
        {
           
            int choice;
            bool checkchoice;
            while (true )
            {
                Console.WriteLine("==========MENU=========");
                Console.WriteLine("1. Create Post");
                Console.WriteLine("2. Update Post");
                Console.WriteLine("3. Remove Post");
                Console.WriteLine("4. Show Posts");
                Console.WriteLine("5. Search");
                Console.WriteLine("6. Rating");
                Console.WriteLine("7. Exit");
                Console.WriteLine("==========================    Welcome to Posts   ================================");
                do
                {
                    
                    checkchoice = int.TryParse(Console.ReadLine(), out choice);
                   
                } while (!checkchoice);
               
                switch (choice)
                {
                    case 1:

                        Post p = new Post();
                        //Console.Write("Nhap vao Id: ");
                        
                        //p.Id = int.Parse(Console.ReadLine());
                        Console.Write("Nhap vao Title: ");
                        p.Title = Console.ReadLine();
                        Console.Write("Nhap vao Content: ");
                        p.Content = Console.ReadLine();
                        Console.Write("Nhap vao Author: ");
                        p.Author = Console.ReadLine();
                   
                        fourm.AddPost(p);
                        
                        break;
                    case 2:
                        string newconten;
                        int id;
                        Console.WriteLine("Nhap vao ID can Update content moi");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap vao Conten Moi:");
                        newconten = Console.ReadLine();
                        fourm.UpdatePostList(id, newconten);
                        break;
                    case 3:
                       
                        Console.WriteLine("Danh sach da xoa:");
                        fourm.RemovePostId();
                        break;
                    case 4:
                        Console.WriteLine("=====Danh sach bai dang====");
                        Console.WriteLine("ID\t\t\tTITLE\t\t\tCONTENT\t\t\tAUTHOR\t\t\tAVERAGE");
                        fourm.ShowPostList();
                        break;
                    case 5:
                        Console.WriteLine("ID\t\t\tTITLE\t\t\tCONTENT\t\t\tAUTHOR\t\t\tAVERAGE");
                        fourm.Search();
                       
                        break;
                    case 6:

                        bool check;
                        int rate;
                        int InputId;
                        do
                        {
                            Console.WriteLine("Nhap vao Id");
                            check = int.TryParse(Console.ReadLine(), out InputId);
                        } while (!check || InputId <= 0);
                        int index = fourm.SearchID(InputId);
                       if (index!= -1)
                        {
                            do
                            {
                                Console.WriteLine("Nhap vap rate :");
                                check = int.TryParse(Console.ReadLine(), out rate);
                            } while (!check || rate <= 0 || rate > 5);
                            fourm.postList[index].Rate.Add(rate);
                            fourm.postList[index].CaculatorRate();
                        }
                        else
                        {
                            Console.WriteLine("khong tim thay");
                        }
                  
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                }
                  
            }
        }
    }
}
