using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap_Collection_Generic
{
    class Post : IPost
    {
        private static int _Id ;
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
        private string _content;

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        private double _averageRate;

        public double AverageRate
        {
            get { return _averageRate; }
            set { _averageRate = value; }
        }
        public List<int> Rate = new List<int>();
        public Post()
        {
            _id = ++_Id;
        }
        public Post(string title, string content, string author)
        {
            _id = _Id;
            _title = title;
            _content = content;
            _author = author;
        }
        public double CaculatorRate()
        {
            double sum = 0;
                foreach (int rate in Rate)
                {
                     sum += rate;
                }
                   _averageRate = sum / Rate.Count;
            return _averageRate;

        }
       

        public string Display()
        {
            //CaculatorRate();
            return $"{_id}\t\t\t{_title}\t\t\t{_content}\t\t\t{_author}\t\t\t{_averageRate}";
        }
    }

 }
