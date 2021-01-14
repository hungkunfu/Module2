using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoffees
{
    class Order
    {

        public string NameDrink { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int Total => Price * Count;
        public override string ToString()
        {
            return $"Tên Thức Uống : {NameDrink}\n Giá Tiền : {Price}\n Số Lượng : {Count}\n Tổng Tiền : {Total}\n";
        }
    }
}
