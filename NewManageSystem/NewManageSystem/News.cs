using System;
using System.Collections.Generic;
using System.Text;

namespace NewManageSystem
{
     class News : INew
    {
        public static News[] newslist = new News[0];
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private DateTime _publishdate;

        public DateTime PublishDate
        {
            get { return _publishdate; }
            set { _publishdate = value; }
        }
        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        private string _conten;

        public string Content
        {
            get { return _conten; }
            set { _conten = value; }
        }
        private float _averageRate;

        public float AverageRate
        {
            get { return _averageRate; }
            set { _averageRate = value; }
        }

        public int[] RateList { get => _rateList; set => _rateList = value; }

        private int[]  _rateList = new int[3];

        public News() { }
        public News(string tiltle, DateTime publishDate, string author, string content)
        {
            _title = tiltle;
            _publishdate = publishDate;
            _author = author;
            _conten = content;
        }


      public string Display()
        {
            return $"{_title}\t\t\t{_publishdate}\t\t\t{_author}\t\t\t{_conten}\t\t\t{_averageRate}";

        }
       
        public float Caculate()
        {
            return (float)(RateList[0] + RateList[1] + RateList[2]) / 3;
        }
        public void Insert(string tiltle, DateTime publishDate, string author, string content)
        {
           
            News news = new News(tiltle, publishDate, author, content);
            Array.Resize(ref newslist, newslist.Length + 1);
            newslist[newslist.Length - 1] = news;
           for(int i  = 0; i < RateList.Length; i++)
            {
                Console.Write("Rate" + (i + 1) + " : ");
                RateList[i] = int.Parse(Console.ReadLine());

            }
        }
        public  void Showlist()
        {
            foreach (var list in newslist)
            {
                Console.Write(list.Display());

            }
        }
        public void Sum()
        {
            Console.WriteLine(Caculate());
            
        }


    }
}
