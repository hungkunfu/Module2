// using System;

// namespace Bai_Tap_Lam_Them
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int choice = -1;
//             while (choice != 0)
//             {
//                 Menu();
//                 choice = Int32.Parse(Console.ReadLine());
//                 switch (choice)
//                 {
//                     // case 1:
//                     //     Matrix();
//                     //     break;
//                     // case 2:
//                     //     Printmatrix();
//                     //     break;
//                     case 0:
//                         Environment.Exit(0);
//                         break;

//                 }
//             }
        
//         static void Menu()
//         {
            
//         }
//         static void Matrix()
//         {
//             Random rand = new Random();
//             int rows, column;
//             int[,] arr = new int[rows,column];
//             System.Console.WriteLine("Nhap vao row");
//             rows = Int32.Parse(Console.ReadKey());
//             System.Console.WriteLine("Nhap vao column");
//             column = Int32.Parse(Console.ReadLine());
//             for (int i = 0; i < row; i++)
//             {
//                 for (int j = 0; j < column; j++)
//                 {
//                     arr[i,j] = rand.Next(10, 100);
//                 }
//             }


//         }
        
        
//     }
// }
