using System;
using System.IO;
namespace TH_CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter source file: ");
            string sourcePath = Console.ReadLine();
            Console.WriteLine("Enter destination file: ");
            string destinationPath = Console.ReadLine();

            FileInfo source = new FileInfo(sourcePath);
            FileInfo des = new FileInfo(destinationPath);
            try
            {
                CopyFileUsingInfo(source, des);
                Console.WriteLine("Copy Completed");
            }
            catch (IOException e)
            {
                Console.WriteLine("Cannot Copy");
                Console.Error.WriteLine(e.Message);
            }
        }
        static void CopyFileUsingInfo(FileInfo source, FileInfo des)
        {
            Console.WriteLine("Start Copy FileInfo : ");
            source.CopyTo(des.FullName, true);
        }
        static void CopyFileUsingStream(FileInfo source, FileInfo des)
        {
            Console.WriteLine("Start copy using stream : ");
            StreamReader rd = null;
            StreamWriter wt = null;
            try
            {
                rd = new StreamReader(source.FullName);
                wt = new StreamWriter(des.FullName);
                char[] buffer = new char[1024];
                int lenght;
                while((lenght = rd.Read(buffer)) > 0 ){
                    wt.Write(buffer, 0, lenght);
                }

            }
            finally
            {
                rd.Close();
                rd.Dispose();
                wt.Close();
                wt.Dispose();
            }
           
        }
    }
}
