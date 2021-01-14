using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoffees
{
    class Table : ITable
    {
        public string TableID { get; set; }
        public string ThuNgan { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public List<Order> orderlist = new List<Order>();
        public int TongTien => Pay();
        public string Showorderlist()
        {
            string line = "";
            foreach (var item in orderlist)
            {
               line += item.ToString();
            }
            return line;
        }
        public int Pay()
        {
            int pay = 0;
            foreach (var item in orderlist)
            {
                pay += item.Total;
            }
            return pay;
        }

        public string Show()
        {
            return $"Bàn : {TableID}\n" +
                    $"Thời Gian Vào : {StartTime}\t" +
                    $"Thời Gian Ra : {EndTime}\n" +
                    $"{Showorderlist()}\n";
        }
        public string ShowPay()
        {
            return $"Bàn  : {TableID}\n" +
                   $"Thời Gian Vào : {StartTime}\t" +
                   $"Thời Gian Ra : {EndTime}\n" +
                   $"{Showorderlist()}\n\n" +
                   $"Tổng Tiền : {TongTien}" +
                   $"  Người Thu tiền : {ThuNgan}";
        }
        public string ShowBill()
        {
            return $"Bàn  : {TableID}\n" +
                   $"Thời Gian Vào : {StartTime}\t" +
                   $"Thời Gian Ra : {EndTime}\n" +                 
                   $"Tổng Tiền : {TongTien}\t" +
                   $"  Người Thu tiền : {ThuNgan}";
        }

    }
}
