using System;
using System.Collections;
using System.Collections.Generic;
namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<char> charater = new List<char>();
            //charater.InsertRange(0, new char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
            //int value = charater[6];

            try
            {
                List<char> charater = new List<char>();
                charater.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int value = charater[6];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()}, {ex.Message }");
                
            }
            
        }

    }
}

