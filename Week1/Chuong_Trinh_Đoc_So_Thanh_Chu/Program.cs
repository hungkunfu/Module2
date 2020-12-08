using System;

namespace Chuong_Trinh_Đoc_So_Thanh_Chu
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;
            System.Console.WriteLine("Nhap vao Chu Can Doc");
            input = double.Parse(Console.ReadLine());


            if (input < 10)
            {
                switch (input)
                {
                    case 1:
                        System.Console.Write("one");
                        break;
                    case 2:
                        System.Console.Write("tow");
                        break;
                    case 3:
                        System.Console.Write("three");
                        break;
                    case 4:
                        System.Console.Write("for");
                        break;
                    case 5:
                        System.Console.Write("fire");
                        break;
                    case 6:
                        System.Console.Write("six");
                        break;
                    case 7:
                        System.Console.Write("seven");
                        break;
                    case 8:
                        System.Console.Write("eight");
                        break;
                    case 9:
                        System.Console.Write("night");
                        break;
                }


            }
            else if (input <= 20)
            {
                switch (input)
                {
                    case 10:
                        System.Console.Write("ten");
                        break;
                    case 11:
                        System.Console.Write("element");
                        break;
                    case 12:
                        System.Console.Write("eleven");
                        break;
                    case 13:
                        System.Console.Write("thirteen");
                        break;
                    case 14:
                        System.Console.Write("forteen");
                        break;
                    case 15:
                        System.Console.Write("fireteen");
                        break;
                    case 16:
                        System.Console.Write("sixteen");
                        break;
                    case 17:
                        System.Console.Write("seventeen");
                        break;
                    case 18:
                        System.Console.Write("eightteen");
                        break;
                    case 19:
                        System.Console.Write("nightteen");
                        break;
                    case 20:
                        System.Console.Write("twenty");
                        break;

                }


            }
            else if (input < 100)
            {
                switch (Math.Floor(input / 10))
                {
                    // case 0:
                    //     System.Console.WriteLine("");
                    //     break;
                    case 2:
                        System.Console.Write("twenty");
                        break;
                    case 3:
                        System.Console.Write("thirty");
                        break;
                    case 4:
                        System.Console.Write("forty");
                        break;
                    case 5:
                        System.Console.Write("firety");
                        break;
                    case 6:
                        System.Console.Write("sixty");
                        break;
                    case 7:
                        System.Console.Write("seventy");
                        break;
                    case 8:
                        System.Console.Write("eightty");
                        break;
                    case 9:
                        System.Console.Write("nightty");
                        break;


                }
                switch (input % 10)
                {
                    case 1:
                        System.Console.Write("one");
                        break;
                    case 2:
                        System.Console.Write("tow");
                        break;
                    case 3:
                        System.Console.Write("three");
                        break;
                    case 4:
                        System.Console.Write("for");
                        break;
                    case 5:
                        System.Console.Write("fire");
                        break;
                    case 6:
                        System.Console.Write("six");
                        break;
                    case 7:
                        System.Console.Write("seven");
                        break;
                    case 8:
                        System.Console.Write("eight");
                        break;
                    case 9:
                        System.Console.Write("night");
                        break;
                }
            }
            else if (input < 1000)
            {
                switch (Math.Floor(input / 100))
                {
                    case 1:
                        System.Console.Write("one hundred");
                        break;
                    case 2:
                        System.Console.Write("tow hundred");
                        break;
                    case 3:
                        System.Console.Write("three hundred");
                        break;
                    case 4:
                        System.Console.Write("for hundred");
                        break;
                    case 5:
                        System.Console.Write("fire hundred");
                        break;
                    case 6:
                        System.Console.Write("six hundred");
                        break;
                    case 7:
                        System.Console.Write("seven hundred");
                        break;
                    case 8:
                        System.Console.Write("eight hundred");
                        break;
                    case 9:
                        System.Console.Write("night hundred");
                        break;
                }
                if (Math.Floor((input / 10) % 10) == 1)
                {
                    switch (input % 10)
                    {

                        case 1:
                            System.Console.Write("  element");
                            break;
                        case 2:
                            System.Console.Write(" eleven");
                            break;
                        case 3:
                            System.Console.Write(" thirteen");
                            break;
                        case 4:
                            System.Console.Write(" forteen");
                            break;
                        case 5:
                            System.Console.Write(" fireteen");
                            break;
                        case 6:
                            System.Console.Write(" sixteen");
                            break;
                        case 7:
                            System.Console.Write(" seventeen");
                            break;
                        case 8:
                            System.Console.Write(" eightteen");
                            break;
                        case 9:
                            System.Console.Write(" nightteen");
                            break;

                    }
                }
                else
                {
                    switch (Math.Floor((input / 10) % 10))
                    {
                        case 2:
                            System.Console.Write(" twenty");
                            break;
                        case 3:
                            System.Console.Write(" thirty");
                            break;
                        case 4:
                            System.Console.Write(" forty");
                            break;
                        case 5:
                            System.Console.Write(" firety");
                            break;
                        case 6:
                            System.Console.Write(" sixty");
                            break;
                        case 7:
                            System.Console.Write(" seventy");
                            break;
                        case 8:
                            System.Console.Write(" eightty");
                            break;
                        case 9:
                            System.Console.Write(" nightty");
                            break;

                    }
                }

            }
            switch (input % 10)
            {
                case 1:
                    System.Console.Write(" one");
                    break;
                case 2:
                    System.Console.Write(" tow");
                    break;
                case 3:
                    System.Console.Write(" three");
                    break;
                case 4:
                    System.Console.Write(" for");
                    break;
                case 5:
                    System.Console.Write(" fire");
                    break;
                case 6:
                    System.Console.Write(" six");
                    break;
                case 7:
                    System.Console.Write(" seven");
                    break;
                case 8:
                    System.Console.Write(" eight");
                    break;
                case 9:
                    System.Console.Write(" night");
                    break;
            }

        }
    }
}
