using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap_Collection_Generic
{
    class Fourm
    {

        //Post post = new Post();
     public   MyList<Post> postList = new MyList<Post>();
        public void AddPost(Post p)
        {
            //bool check;
            
            postList.Add(p);

        }
        public void ShowPostList()
        {
           for(int i = 0; i < postList.Count; i++)
            {
                Console.WriteLine(postList[i].Display());
            }
          
        }
        public void UpdatePostList(int id, string newcontent)
        {
            bool check = false;
             for(int i =0; i< postList.Count; i++)
            {
                if (postList.list[i].Id.Equals(id))
                {
                    check = true;
                    postList.list[i].Content = newcontent;
                    break;
                }
            }
             if(check == true)
            {
                Console.WriteLine("Update Thanh cong");
            }else
            {
                Console.WriteLine("Khong Ton tai ID ");
            }
        }
        public void Search()
        {
            bool check = false;
            string authors, titles;
            Console.Write("Nhap vao Author : ");
            authors = Console.ReadLine();
            Console.Write("Nhap vao Title : ");
            titles = Console.ReadLine();
            //authors = authors.ToUpper();
            //titles = titles.ToUpper();
            for (int i = 0; i < postList.Count; i++)
            {
                if (authors == postList.list[i].Author || titles == postList.list[i].Title)
                {
                    check = true;
                    Console.WriteLine(postList.list[i].Display());
                }
            }
            if(check == true)
            {
                Console.WriteLine("-----success-----");
            }else
            {
                Console.WriteLine("Khong Tim Thay");
            }
        }
        public void RemovePostId()
        {
            bool check = false;
            Console.WriteLine("Nhap vao ID muon xoa :");
            int id = int.Parse(Console.ReadLine());
            for(int i = 0; i < postList.Count; i++)
          
            {
                if (id== postList[i].Id)
                { 
                    check = true;
                    postList.Remove(postList[i]);
                    break;
                }
            }
            if(check == true)
            {
                Console.WriteLine("Xoa Thanh Cong");
            }else
            {
                Console.WriteLine("Khong tim thay Moi Nhap lai");
            }
        }
        public int SearchID(int id)
        {
          for(int i =0; i< postList.Count; i++)
            {
                if (id == postList.list[i].Id)
                {
                    return i;
                }
            }
            return -1;
        }
       

    }
}
