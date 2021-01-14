using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AppCoffees
{
    class ManagementCoffee
    {
        public Dictionary<string, Table> table = new Dictionary<string, Table>();
        public Dictionary<string, Table> bill = new Dictionary<string, Table>();
        public void NewOrder(Table tables)
        {
            table.Add(tables.TableID, tables);
        }
        public void Show()
        {
            foreach (Table item in table.Values)
            {
                Console.WriteLine(item.Show());
            }
        }
        public Table CheckTableId(string tableid)
        {
            foreach (Table item in table.Values)
            {
                if (tableid.Equals(item.TableID))
                {
                    return item;
                }
            }
            return null;
        }
        public void Update(string tableid, Order order)
        {
            bool Istrue = false;
            foreach (Order item in table[tableid].orderlist)
            {
                if (item.NameDrink.Contains(order.NameDrink))
                {
                    item.Count += order.Count;
                    Istrue = true;
                    break;
                }
            }
            if (!Istrue)
            {
                table[tableid].orderlist.Add(order);
            }
        }
        public void RemoveTableId(string TableID)
        {
            bool check = false;
            foreach (Table item in table.Values)
            {
                if (TableID.Equals(item.TableID))
                {
                    check = true;
                    table.Remove(item.TableID);
                }
            }
            if (check == true)
            {
                Console.WriteLine();
                Console.WriteLine($"Bàn số {TableID} đã trống ! Sử Dụng được");
            }
            else
            {
                Console.WriteLine("Remove That bai ! ");
            }
        }
        public void RemoveDrink(string tableId, string name, int count)
        {
            foreach (Order item in table[tableId].orderlist)
            {
                if (item.NameDrink.ToLower().Equals(name.ToLower()))
                {
                    if (item.Count > count)
                    {
                        item.Count -= count;
                    }
                }
            }
        }
        public void Pay(string tableid)
        {
            Console.WriteLine(table[tableid].ShowPay());
            string fileName = $"Bill_{tableid}.json";
            string pathjson = @$"H:\MODULE_2\AppCoffees\AppCoffees\OderJson";

            using (StreamWriter wt = File.CreateText($@"{pathjson}\{fileName}"))
            {
                var data = JsonConvert.SerializeObject(table);
                wt.WriteLine(data);
            }

        }
        public void Search(string tableId)
        {
            Table item = CheckTableId(tableId);
            if (item != null)
            {
                Console.WriteLine(item.Show());
            }
            else
            {
                Console.WriteLine("Khong Tim Thay !");
            }

        }
        public void ShowBill()
        {

            string pathjson = @$"H:\MODULE_2\AppCoffees\AppCoffees\OderJson\AllBill.json";
            foreach (Table item in bill.Values)
            {
                Console.WriteLine(item.ShowBill());

                using (StreamWriter wt = File.CreateText($@"{pathjson}"))
                {
                    var data = JsonConvert.SerializeObject(table);
                    wt.WriteLine(data);
                }
            }

        }
        public void Datajson()
        {
            string path = @"H:\MODULE_2\AppCoffees\AppCoffees\Data";
            string fileName = "data.json";

        }
    }
}
