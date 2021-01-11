using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace Bai_Tap_Module2_Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"H:\MODULE_2\Bai_Tap_Module2_Bai2\Bai_Tap_Module2_Bai2\Input";
            string input = "data.json";
            string output = "output.json";
            string output2 = "Outcome.json";
            string data;
            using (StreamReader rd = File.OpenText($@"{path}\{input}"))
            {
                data = rd.ReadToEnd();
            }
            ListStudent result = JsonConvert.DeserializeObject<ListStudent>(data);
            List<ResStudent> resStudents = new List<ResStudent>();
            foreach (Student std in result.students)
            {
                var item = new ResStudent()
                {
                    Mahs = std.Mahs,
                    HoTen = std.HoTen,
                    GioiTinh = std.GioiTinh,
                    Lop = std.Lop,
                    Monhoc = std.Monhoc
                };
               
                resStudents.Add(item);

            }
            resStudents.Sort(new SortDTB());
            using (StreamWriter sw = File.CreateText($@"{path}\{output2}"))
            {
                sw.Write(JsonConvert.SerializeObject(resStudents));
            }
        }

    }

    public class ListStudent
    {
        public List<Student> students = new List<Student>();

    }
    public class Student
    {
        public string Mahs { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string Lop { get; set; }
        public List<Monhocs> Monhoc { get; set; }

    }
    public class Monhocs
    {
        public string scorename { get; set; }
        public double score { get; set; }


    }
    public class ResStudent : Student
    {

        public double DTB => CalculatorAveScore();
        public string XepLoaiMonHoc => XepLoai();
        public double CalculatorAveScore()

        {
            double total = 0.0;
            foreach (var item in Monhoc)
            {
                if (item.scorename.ToLower().Equals("Toan".ToLower()))
                {
                    total += item.score * 2;
                }
                else
                {
                    total += item.score;
                }

            }
            return total / 4;
        }
        public string XepLoai()
        {

            double sum = CalculatorAveScore();
            return sum >= 9 ? "Xuat sac" : sum >= 8 ? "Gioi" : sum >= 7 ? "Kha" : sum >= 6.5 ? "TBK" : sum >= 5 ? "TB" : sum >= 3.5 ? "yeu" : "";
        }


    }
    public class SortDTB : IComparer<ResStudent>
    {
        public int Compare(ResStudent x, ResStudent y)
        {
            if (x == null || y == null)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                if (x.DTB > y.DTB)
                {
                    return -1;
                }
                if (x.DTB < y.DTB)
                {
                    return 1;
                }
                else
                  return 0;
            }
        }
    }
}


