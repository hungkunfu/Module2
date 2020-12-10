using System;

namespace Mang_mot_Chieu_Day_du
{
    class Program
    {

        //Ham nhap mang

        public void setArray(ref int n, ref int[] a)

        {

            do

            {

                Console.Write("Nhap n (0<n<100): ");

                n = int.Parse(Console.ReadLine());

            } while (n >= 100 || n <= 0);

            for (int i = 0; i < n; i++)

            {

                Console.Write("Nhap a[{0}]: ", i);

                a[i] = int.Parse(Console.ReadLine().ToString());

            }

        }

        //Ham in tat ca cac phan tu trong mang

        public void print(int[] a, int n)

        {

            String tmp = "";

            for (int i = 0; i < n; i++)

            {

                tmp += a[i] + ", ";

            }

            Console.WriteLine("Day so vua nhap: " + tmp.Substring(0, tmp.Length - 2));

        }

        //Ham in tat ca cac phan tu chan trong mang theo thu tu nhap

        public void printEvenNumber(int[] a, int n)

        {

            String tmp = "";

            for (int i = 0; i < n; i++)

            {

                if (a[i] % 2 == 0)
                {

                    tmp += a[i] + ", ";

                }

            }

            if (tmp != "")

            {

                tmp = tmp.Substring(0, tmp.Length - 2);

                Console.WriteLine("Cac phan tu chan trong mang theo thu tu nhap: " + tmp);

            }

            else

            {

                Console.WriteLine("Mang khong co so chan!");

            }

        }

        //Ham in tat ca cac phan tu le trong mang nguoc thu tu nhap

        public void printOddNumber(int[] a, int n)

        {

            String tmp = "";

            for (int i = n - 1; i >= 0; i--)

            {

                if (a[i] % 2 == 1)

                {

                    tmp += a[i] + ", ";

                }

            }

            if (tmp != "")

            {

                tmp = tmp.Substring(0, tmp.Length - 2);

                Console.WriteLine("Cac phan tu le trong mang nguoc thu tu nhap: " + tmp);

            }

            else

            {

                Console.WriteLine("Mang khong co so le!");

            }

        }

        //Ham in tat ca cac phan tu o vi tri chan nguoc thu tu nhap

        public void printEvenIndex(int[] a, int n)

        {

            String tmp = "";

            if (n % 2 == 0) n--;

            for (int i = n - 1; i >= 0; i -= 2)

            {

                tmp += a[i] + ", ";

            }

            Console.WriteLine("Cac phan tu o vi tri chan nguoc thu tu nhap: " + tmp.Substring(0, tmp.Length - 2));

        }

        //Ham in tat ca cac phan tu o vi tri le theo thu tu nhap

        public void printOddIndex(int[] a, int n)

        {

            String tmp = "";

            for (int i = 1; i < n; i += 2)

                tmp += a[i] + ", ";

            Console.WriteLine("Cac phan tu o vi tri le theo thu tu nhap: " + tmp.Substring(0, tmp.Length - 2));

        }

        //Ham in tat ca cac phan tu am theo thu tu nhap

        public void printNegativeNumber(int[] a, int n)

        {

            String tmp = "";

            for (int i = 0; i < n; i++)

                if (a[i] < 0) tmp += a[i] + ", ";

            if (tmp != "")

            {

                tmp = tmp.Substring(0, tmp.Length - 2);

                Console.WriteLine("Cac phan tu am theo thu tu nhap: " + tmp);

            }

            else

            {

                Console.WriteLine("Mang khong co so am!");

            }

        }

        //Ham in tat ca cac phan tu duong nguoc thu tu nhap

        public void printPositiveNumbers(int[] a, int n)

        {

            String tmp = "";

            for (int i = n - 1; i >= 0; i--)

            {

                if (a[i] > 0) tmp += a[i] + ", ";

            }

            if (tmp != "")

            {

                tmp = tmp.Substring(0, tmp.Length - 2);

                Console.WriteLine("Cac phan tu duong nguoc thu tu nhap: " + tmp);

            }

            else

            {

                Console.WriteLine("Mang khong co so duong!");

            }

        }

        //Ham tim phan tu lon nhat

        public int getMax(int[] a, int n)

        {

            int max = a[0];

            for (int i = 1; i < n; i++)

                if (max < a[i]) max = a[i];

            return max;

        }

        //Ham tim phan tu be nhat

        public int getMin(int[] a, int n)

        {

            int min = a[0];

            for (int i = 1; i < n; i++)

                if (min > a[i]) min = a[i];

            return min;

        }

        //Ham dem so phan tu le trong mang

        public int getCountOddNumber(int[] a, int n)

        {

            int count = 0;

            for (int i = 0; i < n; i++)

                if (a[i] % 2 == 1) count++;

            return count;

        }

        //Ham dem so phan tu am trong mang

        public int getCountNegativeNumber(int[] a, int n)

        {

            int count = 0;

            for (int i = 0; i < n; i++)

                if (a[i] < 0) count++;

            return count;

        }

        //Ham tinh tong cac phan tu trong mang

        public long getTotal(int[] a, int n)

        {

            long total = 0;

            for (int i = 0; i < n; i++)

                total += a[i];

            return total;

        }

        //Ham tinh tong cac phan tu o vi tri chan trong mang

        public long getTotalEvenIndex(int[] a, int n)

        {

            long total = 0;

            for (int i = 0; i < n; i += 2)

                total += a[i];

            return total;

        }

        //Ham xac dinh mot so co phai so nguyen to hay khong

        public Boolean isPrimeNumber(int n)

        {

            if (n < 2) return false;

            for (int i = 2; i < n; i++)

                if (n % i == 0) return false;

            return true;

        }

        //Ham in cac so nguyen to trong mang

        public void printPrimeNumber(int[] a, int n)

        {

            String tmp = "";

            for (int i = 0; i < n; i++)

            {

                if (isPrimeNumber(a[i]))

                {

                    tmp += a[i] + ", ";

                }

            }

            if (tmp != "")

            {

                tmp = tmp.Substring(0, tmp.Length - 2);

                Console.WriteLine("Cac so nguyen to trong mang: " + tmp);

            }

            else

            {

                Console.WriteLine("Trong mang khong co so nguyen to");

            }

        }

        //Ham dem so luong cac so nguyen to trong mang

        public int getCountPrimeNumber(int[] a, int n)

        {

            int count = 0;

            for (int i = 0; i < n; i++)

            {

                if (isPrimeNumber(a[i]))

                {

                    count++;

                }

            }

            return count;

        }

        //Ham tinh tong cac so nguyen to trong mang

        public long getTotalPrimeNumber(int[] a, int n)

        {

            long total = 0;

            for (int i = 0; i < n; i++)

            {

                if (isPrimeNumber(a[i]))

                {

                    total += a[i];

                }

            }

            return total;

        }

        //Ham kiem tra mot so co phai so chinh phuong hay khong

        public Boolean isSquareNumber(int a)

        {

            Boolean kq = false;

            double x = Math.Sqrt(a);

            if ((int)x * x == a) { kq = true; }

            return kq;

        }

        //Ham in cac so chinh phuong trong mang

        public void printSquareNumber(int[] a, int n)

        {

            String tmp = "";

            for (int i = 0; i < n; i++)

            {

                if (isSquareNumber(a[i]))

                {

                    tmp += a[i] + ", ";

                }

            }

            if (tmp != "")

            {

                tmp = tmp.Substring(0, tmp.Length - 2);

                Console.WriteLine("Cac so chinh phuong trong mang: " + tmp);

            }

            else

            {

                Console.WriteLine("Trong mang khong co so chinh phuong");

            }

        }

        //Ham tinh tong cac so chinh phuong trong mang

        public long getTotalSquareNumber(int[] a, int n)

        {

            long total = 0;

            for (int i = 0; i < n; i++)

            {

                if (isSquareNumber(a[i]))

                {

                    total += a[i];

                }

            }

            return total;

        }

        //Ham kt 1 so phai so hoan thien khong

        public Boolean isPerfectNumber(int n)

        {

            if (n < 0) return false;

            int sum = 1;

            for (int i = 2; i < n; i++)

            {

                if (n % i == 0)

                {

                    sum += i;

                    if (sum > n) return false;

                }

            }

            return sum == n;

        }

        //Ham in cac so hoan thien trong mang

        public void printPerfectNumber(int[] a, int n)

        {

            String tmp = "";

            for (int i = 0; i < n; i++)

            {

                if (isPerfectNumber(a[i]))

                {

                    tmp += a[i] + ", ";

                }

            }

            if (tmp != "")

            {

                tmp = tmp.Substring(0, tmp.Length - 2);

                Console.WriteLine("Cac so hoan thien trong mang: " + tmp);

            }

            else

            {

                Console.WriteLine("Trong mang khong co so hoan thien");

            }

        }

        //Ham tim vi tri xuat hien dau tien cua phan tu x trong mang

        public int getFirstPosition(int[] a, int n, int x)

        {

            for (int i = 0; i < n; i++)

            {

                if (a[i] == x)

                {

                    return i;

                }

            }

            return -1;

        }

        //Ham dem so lan xuat hien cua phan tu x trong mang

        public int getCountEqual(int[] a, int n, int x)

        {

            int count = 0;

            for (int i = 0; i < n; i++)

            {

                if (a[i] == x)

                {

                    count++;

                }

            }

            return count;

        }

        //Ham in ra tat ca vi tri cua x trong mang

        public void printIndexByValue(int[] a, int n, int x)

        {

            String tmp = "";

            for (int i = 0; i < n; i++)

            {

                if (a[i] == x)

                {

                    tmp += a[i] + ", ";

                }

            }

            if (tmp != "")

            {

                tmp = tmp.Substring(0, tmp.Length - 2);

                Console.WriteLine("Cac vi tri xuat hien cua {0} trong mang: {1} ", x, tmp);

            }

            else

            {

                Console.WriteLine("Trong mang khong co so phan tu " + x);

            }

        }

        //Ham them 1 phan tu vao cuoi mang

        public void insertLast(ref int[] a, ref int n, int x)

        {

            a[n] = x;

            n++;

        }

        //Ham them 1 phan tu vao dau mang

        public void insertFirst(ref int[] a, ref int n, int x)

        {

            for (int i = n; i > 0; i--)

            {

                a[i] = a[i - 1];

            }

            a[0] = x;

            n++;

        }

        //Ham chen 1 phan tu vao dung vi tri

        public void insertAt(ref int[] a, ref int n, int x, int k)

        {

            if (k == 0)

            {

                insertFirst(ref a, ref n, x);

            }

            else

            {

                if (k == n)

                {

                    insertLast(ref a, ref n, x);

                }

                else

                {

                    for (int i = n; i > k; i--)

                    {

                        a[i] = a[i - 1];

                    }

                    a[k] = x;

                    n++;

                }

            }

        }

        //Ham xoa 1 phan tu cuoi khoi mang

        public void removeLast(int[] a, ref int n)

        {

            if (n == 0) return;

            n--;

        }

        //Ham xoa 1 phan tu dau cua mang

        public void removeFirst(ref int[] a, ref int n)

        {

            if (n == 0) return;

            for (int i = 0; i < n - 1; i++)

            {

                a[i] = a[i + 1];

            }

            n--;

        }

        //Ham xoa mot phan tu tai vi tri k

        public void removeAt(ref int[] a, ref int n, int k)

        {

            if (k < 0 || k >= n) return;

            if (k == 0)

            {

                removeFirst(ref a, ref n);

            }

            else

            {

                if (k == n - 1) { removeLast(a, ref n); }

                else

                {

                    for (int i = k; i < n - 1; i++)

                    {

                        a[i] = a[i + 1];

                    }

                    n--;

                }

            }

        }

        //Ham xoa x dua vao vi tri xuat hien dau tien cua x

        public void removeFirst(ref int[] a, ref int n, int x)

        {

            int pos = getFirstPosition(a, n, x);

            removeAt(ref a, ref n, pos);

        }

        //Ham xoa tat ca x trong mang

        public void removeAll(ref int[] a, ref int n, int x)

        {

            for (int i = 0; i < n; i++)

            {

                removeFirst(ref a, ref n, x);

            }

        }

        //Ham hoan vi hai so a,b

        public void swap(ref int a, ref int b)

        {

            int tmp = a;

            a = b;

            b = tmp;

        }

        //Ham sap mang tang dan

        public void ascSort(ref int[] a, int n)

        {

            for (int i = 0; i < n - 1; i++)

            {

                for (int j = i + 1; j < n; j++)

                {

                    if (a[i] > a[j]) swap(ref a[i], ref a[j]);

                }

            }

        }

        //Ham sap mang giam dan

        public void descSort(ref int[] a, int n)

        {

            for (int i = 0; i < n - 1; i++)

            {

                for (int j = i + 1; j < n; j++)

                {

                    if (a[i] < a[j]) swap(ref a[i], ref a[j]);

                }

            }

        }

        static void Main(string[] args)

        {

            Program p = new Program();

            //1. Cho phep nhap n so nguyen(0<n<100)

            int n = 0; int[] a = new int[100];

            p.setArray(ref n, ref a);

            //2. Xuat mang vua nhap

            p.print(a, n);

            //3. In 6 dong:

            //+ Cac phan tu chan theo thu tu nhap

            p.printEvenNumber(a, n);

            //+ Cac phan tu le nguoc thu tu nhap

            p.printOddNumber(a, n);

            //+ Cac phan tu o vi tri chan nguoc thu tu nhap

            p.printEvenIndex(a, n);

            //+ Cac phan tu o vi tri le theo thu tu nhap

            p.printOddIndex(a, n);

            //+ Cac phan tu am theo thu tu nhap

            p.printNegativeNumber(a, n);

            //+ Cac phan tu duong nguoc thu tu nhap

            p.printPositiveNumbers(a, n);

            //4. Tim phan tu lon nhat

            Console.WriteLine("Phan tu lon nhat: " + p.getMax(a, n));

            //5. Tim phan tu be nhat

            Console.WriteLine("Phan tu be nhat: " + p.getMin(a, n));

            //6. Dem so phan tu le trong mang

            Console.WriteLine("So phan tu le trong mang: " + p.getCountOddNumber(a, n));

            //7. Dem so phan tu am trong mang

            Console.WriteLine("So phan tu am trong mang: " + p.getCountNegativeNumber(a, n));

            //8. Tinh tong cac phan tu trong mang

            Console.WriteLine("Tong cac phan tu trong mang: " + p.getTotal(a, n));

            //9. Tinh tong cac phan tu o vi tri chan

            Console.WriteLine("Tong cac phan tu o vi tri chan trong mang: " + p.getTotalEvenIndex(a, n));

            //10. Loc cac so nguyen to trong mang

            p.printPrimeNumber(a, n);

            //11. Dem cac so nguyen to trong mang

            Console.WriteLine("So luong so nguyen to trong mang: " + p.getCountPrimeNumber(a, n));

            //12. Tinh tong cac so nguyen to trong mang

            Console.WriteLine("Tong cac so nguyen to trong mang: " + p.getTotalPrimeNumber(a, n));

            //13. Loc cac so chinh phuong trong mang

            p.printSquareNumber(a, n);

            //14. Tinh tong cac so chinh phuong trong mang

            Console.WriteLine("Tong cac so chinh phuong trong mang: " + p.getTotalSquareNumber(a, n));

            //15. In cac so hoan thien trong mang

            p.printPerfectNumber(a, n);

            //16. Nhap phan tu x, tim vi tri dau tien cua no trong

            //mang(neu khong co thi thong bao)

            int x;

            Console.Write("Nhap phan tu x, tim vi tri dau tien cua x trong mang\nx = ");

            x = int.Parse(Console.ReadLine().ToString());

            int pos = p.getFirstPosition(a, n, x);

            if (pos == -1)

            {

                Console.WriteLine("Khong tim thay {0} trong mang!", x);

            }

            else

            {

                Console.WriteLine("Vi tri xuat hien dau tien cua {0} trong mang: {1}", x, pos);

            }

            //17. Nhap phan tu x, dem so lan xuat hien cua no trong mang(neu khong co thi thong bao)

            Console.Write("Nhap phan tu x, dem so lan xuat hien cua x trong mang\nx = ");

            x = int.Parse(Console.ReadLine().ToString());

            int count = p.getCountEqual(a, n, x);

            Console.WriteLine("So lan xuat hien cua {0} trong mang: {1}", x, count);

            //18. Nhap phan tu x, in tat ca cac vi tri cua no trong mang(neu co)

            Console.Write("\nNhap phan tu x, in tat ca cac vi tri cua no trong mang\nx = ");

            x = int.Parse(Console.ReadLine().ToString());

            p.printIndexByValue(a, n, x);

            //19. Nhap phan tu x, them vao cuoi mang

            Console.Write("\nNhap phan tu x, them vao cuoi mang\nx = ");

            x = int.Parse(Console.ReadLine().ToString());

            p.insertLast(ref a, ref n, x);

            p.print(a, n);

            //20. Nhap phan tu x, them vao dau mang

            Console.Write("\nNhap phan tu x, them vao dau mang\nx = ");

            x = int.Parse(Console.ReadLine().ToString());

            p.insertFirst(ref a, ref n, x);

            p.print(a, n);

            //21. Nhap phan tu x, them vao vi tri k(0<k<n)

            Console.Write("\nNhap phan tu x, them vao vi tri thu k\nx = ");

            x = int.Parse(Console.ReadLine().ToString());

            Console.Write("\nk= ");

            int k;

            do

            {

                k = int.Parse(Console.ReadLine().ToString());

            } while (k <= 0 || k >= n);

            p.insertAt(ref a, ref n, x, k);

            p.print(a, n);

            //22. Nhap vi tri k(0<k<n), in phan tu tai k

            Console.Write("\nNhap vi tri k(0<k<n), in phan tu tai k\nk = ");

            do

            {

                k = int.Parse(Console.ReadLine().ToString());

            } while (k <= 0 || k >= n);

            Console.WriteLine("a[{0}] = {1}", k, a[k]);

            //23. Xoa phan tu cuoi mang

            Console.WriteLine("o0oXoa phan tu cuoi mang: ");

            p.removeLast(a, ref n);

            p.print(a, n);

            //24. Xoa phan tu dau mang

            Console.WriteLine("o0oXoa phan tu dau mang: ");

            p.removeFirst(ref a, ref n);

            p.print(a, n);

            //25. Nhap vi tri k(0<k<n), xoa phan tu tai vi tri k

            Console.Write("\nNhap vi tri k(0<k<n), xoa phan tu tai k\nk = ");

            do

            {

                k = int.Parse(Console.ReadLine().ToString());

            } while (k <= 0 || k >= n);

            p.removeAt(ref a, ref n, k);

            p.print(a, n);

            //26. Nhap phan tu x, xoa phan tu x dau tien trong mang

            Console.Write("\nNhap phan tu x, xoa phan tu x dau tien trong mang\nx = ");

            x = int.Parse(Console.ReadLine().ToString());

            p.removeFirst(ref a, ref n, x);

            p.print(a, n);

            //27. Nhap phan tu x, xoa tat ca cac phan tu x trong mang

            Console.Write("\nNhap phan tu x, xoa tat ca phan tu x trong mang\nx = ");

            x = int.Parse(Console.ReadLine().ToString());

            p.removeAll(ref a, ref n, x);

            p.print(a, n);

            //28. Sap xep mang tang dan

            Console.WriteLine("Sap xep mang tang dan");

            p.ascSort(ref a, n);

            p.print(a, n);

            //29. Sap xep mang giam dan

            Console.WriteLine("Sap xep mang giam dan");

            p.descSort(ref a, n);

            p.print(a, n);

            //Dung man hinh

            Console.ReadKey(true);

        }

    }

}



