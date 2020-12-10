using System;

namespace Bai_Tap_Dem_So_Luong_Ki_Tu
{
    class Program
    {
        static void Main(string[] args)
        {
            string str; /* Khai bao mot chuoi */
            int bien_dem, l;

            Console.Write("\nDem so tu trong mot chuoi trong C#:\n");
            Console.Write("-------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();

            l = 0;
            bien_dem = 1;

            /* lap toi phan cuoi cua chuoi */
            while (l <= str.Length - 1)
            {
                /* kiem tra xem ky tu hien tai co phai la khoang trang 
                 * hay la ky tu new line hay ky tu tab */
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    bien_dem++;
                }

                l++;
            }

            Console.Write("Tong so tu co trong chuoi tren la: {0}\n", bien_dem);

            Console.ReadKey();
        }
    }
}
