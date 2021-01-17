using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bai_Tap_Nhom_Module2_ShopCart
{
    class JsonCart
    {
        public static void StreamWriterCart(string pathjson, Cart cart)
        {
            using (StreamWriter wt = File.CreateText(pathjson))
            {
                var data = JsonConvert.SerializeObject(cart);
                wt.WriteLine(data);
            }
        }
        public static void StreamWriteAllBill(string path, Cart cart)
        {
            using (StreamWriter wt = File.CreateText(path))
            {
                var data = JsonConvert.SerializeObject(cart);
                wt.WriteLine(cart);
            }
        }
    }
}
