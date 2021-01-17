using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Tap_Nhom_Module2_ShopCart
{
  public  class Order
    {
        public string NameSP { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int Total => Price * Count;
        public override string ToString()
        {
            return $"NameSP : {NameSP}\n Price : {Price}\n Count : {Count}\n Total : {Total}\n";
        }
    }
}
