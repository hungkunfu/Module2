using System;

namespace Bai_Tap_Them_Phan_Tu_Vao_Mang
{
    public class MainClass
    {
        public static void Main()
        {
            int[] myArray = new int[] { 12, 5, 3, 0, 45, 39, 92, 664, 0, 4483 };

            myArray = InsertNumber(myArray, insert, 0);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
        }


    }
}