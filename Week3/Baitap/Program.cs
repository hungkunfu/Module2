// using System;

// namespace Baitap
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {

//             int n1 = 5;
//             int n2 = 7;
//             System.Console.WriteLine($" n1 = {n1} n2 = {n2}");
//             Swap(ref n1, ref n2);
//             System.Console.WriteLine($" n1 = {n1} n2 = {n2}");
//             // FindPrimer(2, 6);
           

//         }
//         static void Swap(ref int a, ref int b)
//         {
//             int temp;
//             temp = a;
//             a = b;
//             b = temp;
//         }
//         static int FindPrimer(int N)
//         {
//             // int N;
//             if (N < 2)
//             {
//                 return false;
//             }
//             for(int i = 2; i < N; i++){
//                 if(N%i == 0){
//                     return false;
//                 }
//             }
//             return true;
//         }
//         // static int   
//     }
// }
