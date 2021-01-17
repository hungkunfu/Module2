using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bai_Tap_Nhom_Module2_ShopCart
{
    class Management
    {
        public Dictionary<string, Cart> carts = new Dictionary<string, Cart>();
        public Dictionary<string, Cart> billS = new Dictionary<string, Cart>();
        public void NewOrder(Cart cart)
        {
            carts.Add(cart.cartID, cart);
        }
        public void Show()
        {
            foreach (Cart item in carts.Values)
            {
                Console.WriteLine(item.Show());
            }
        }
        public Cart CheckCartID(string cartid)
        {
            foreach (Cart item in carts.Values)
            {
                if (item.cartID.ToUpper().Equals(cartid.ToUpper()))
                {
                    return item;
                }
            }
            return null;
        }
        public void Update(string cartid, Order order)
        {
            bool istrue = false;
            foreach (Order item in carts[cartid].OrderList)
            {
                if (item.NameSP.ToLower().Contains(order.NameSP.ToLower()))
                {
                    item.Count += order.Count;
                    istrue = true;
                    break;
                }
            }
            if (!istrue)
            {
                carts[cartid].OrderList.Add(order);
            }
        }
        public void RemoveCartID(string cartid)
        {
            Cart item = CheckCartID(cartid);
            if (item != null)
            {
                carts.Remove(item.cartID);
            }
            else
            {
                Console.WriteLine("Not Found !!");
            }
        }
        public void RemoveNameSp(string cartid, string name, int count)
        {
            foreach (Order item in carts[cartid].OrderList)
            {
                if (item.NameSP.ToLower().Equals(name.ToLower()))
                {
                    if (item.Count > count)
                    {
                        item.Count -= count;
                    }
                }
            }
        }
        public void Pay(string cartid)
        {
            Console.WriteLine(carts[cartid].ShowPay());
            /* Phần in bill ra */
            string path = @"C:\Users\HungTran\Source\Repos\Bai_Tap_Nhom_Module2_ShopCart\Bai_Tap_Nhom_Module2_ShopCart\BillCart\";
            string fileName = "BillCart.txt";
            using (StreamWriter sw = File.CreateText(($@"{path}\{fileName}")))
            {
                sw.WriteLine(carts[cartid].ShowPay());
            }
            string fileNames = $"Bill_{cartid}.json";
            string pathjson = $@"C:\Users\HungTran\Source\Repos\Bai_Tap_Nhom_Module2_ShopCart\Bai_Tap_Nhom_Module2_ShopCart\Bill_Json\{ fileNames}";
            JsonCart.StreamWriterCart(pathjson, carts[cartid]);
        }
        public void Search(string cartid)
        {
            Cart item = CheckCartID(cartid);
            if (item != null)
            {
                Console.WriteLine(item.Show());
            }
            else
            {
                Console.WriteLine("Not Found ");
            }

        }

    }
}
