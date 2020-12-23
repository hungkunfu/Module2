using System;
using System.Collections.Generic;

namespace TH_Remove_Add_Repair
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Dictionary<string, Book> bookList = new Dictionary<string, Book>();
            bookList.Add("9780321344755", new Book { Nxb = "9780321344755", Name = "Don't Make Me Think (Beta)", Author = "Steve Krug" });
            bookList.Add("1491904909", new Book { Nxb = "1491904909", Name = "User Story Mapping", Author = "Jeff Patton" });
            bookList.Add("9780465050659", new Book { Nxb = "9780465050659", Name = "The Design of Everyday Things", Author = "Don Norman" });
            book.PrintBook(bookList);

            // sua name of booklist 
            bookList["9780321344755"] = new Book { Nxb = "9780321344755", Name = "Don't Make Me Think", Author = "Steve Krug" };

            Console.WriteLine("Edit book with ISBN");
            book.PrintBook(bookList);
            // search phan tu trong booklist
            Console.WriteLine("Search for a specific book with ISBN");
            if (bookList.ContainsKey("9780321344755") == false)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Book books = bookList["9780321344755"];
                Console.WriteLine("Found this book: " + books.Name);
            }
            // remove mootj phan tu cua booklisst
            bookList.Remove("9780321344755");

            Console.WriteLine("Remove book with ISBN");
            book.PrintBook(bookList);
        }
    }
}
