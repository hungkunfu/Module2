// using System;

// namespace Class_Bai1
// {
//     internal class NewBaseType
//     {
//         static void Main(string[] args)
//         {
//             SimpleCircle cirle1 = new SimpleCircle();
//             System.Console.WriteLine("the area of radius " + cirle1.radius + " is " + cirle1.GetAre());
//             // SimpleCircle cirle2 = new SimpleCircle(25);
//             System.Console.WriteLine("the area of radius " + cirle2.radius + " is " + cirle2.GetAre());
//             cirle2.radius = 100;
           
//         }
//         class SimpleCircle
//         {
//             public double radius;
//             public SimpleCircle()
//             {
//                 radius = 1;
//             }
//             public double GetAre()
//             {
//                 return radius * radius * Math.PI;
//             }
//             public double GetPerimeter()
//             {
//                 return 2 * radius * Math.PI;
//             }
//             public void SetRadius(double newRadius)
//             {
//                 radius = newRadius;

//             }
            
//         }
//     }
// }
