using System;
using System.Collections.Generic;
using System.Text;

namespace TH_Remove_Add_Repair
{
    class Book
    {
        private string _nxb;

        public string Nxb
        {
            get { return _nxb; }
            set { _nxb = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public string ViewInfo()
        {
            return $"{_nxb}\t\t\t{_name}\t\t\t{_author}";
        }
        public void PrintBook(Dictionary<string, Book> books)
        {
            foreach (KeyValuePair<string, Book> bookl in books)
            {
                //Book book = bookl.Value;
                Console.WriteLine(bookl.Value.ViewInfo());
            }

        } 



    }
}
