using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap_Nhom_Module2_ShopCart
{
   public class Cart:ICart
    {

        public string cartID { get; set; }
        public string Cashier { get; set; }
        public string StarTime { get; set; }
        public string EndTime { get; set; }

        public List<Order> OrderList = new List<Order>();
        public int SumTotal => Pay();

        public string ShowOrderList()
        {
            string list = "";
            foreach (Order item in OrderList)
            {
                list += item.ToString();
            }
            return list;
        }

        public int Pay()
        {
            int pay = 0;
            foreach (Order item in OrderList)
            {
                pay += item.Total;
            }
            return pay;
        }

        public string Show()
        {

            return $"Gio Hang : {cartID}\n" +
                    $"Star Time: {StarTime}\t" +
                    $"End Time: {EndTime}\n" +
                    $"{ShowOrderList()}\n";

        }
        public string ShowPay()
        {
            return $"Gio Hang : {cartID}\n" +
                    $"Star Time: {StarTime}\t" +
                    $"End Time: {EndTime}\n\n" +
                    $"{ShowOrderList()}\n\n" +
                    $"SumTotal: {SumTotal}\t" +
                    $"Thu Ngan: {Cashier}";
        }

    }
}
