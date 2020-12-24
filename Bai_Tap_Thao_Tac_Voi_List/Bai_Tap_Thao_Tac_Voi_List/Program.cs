using System;
using System.Collections;
using System.Collections.Generic;

namespace Bai_Tap_Thao_Tac_Voi_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>()
            {
                new Animal("lion"),
                new Animal("cat"),
                new Animal("dog"),
                new Animal("elephant")
            };
           

            Console.WriteLine("Danh sach Chua xoa");
            foreach (var item in animalList)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Danh sach da xoa dog \n");
            animalList.RemoveAt(2);
            foreach (var item in animalList)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Danh sach Sap sau khi sap sep \n");
            animalList.Sort(new SortPersonByName());
            foreach (var item in animalList)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }

    }
   

}
