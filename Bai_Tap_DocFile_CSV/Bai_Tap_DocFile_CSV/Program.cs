using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Globalization;
using System.Text;
namespace Bai_Tap_DocFile_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"H:\MODULE_2\Bai_Tap_DocFile_CSV\Bai_Tap_DocFile_CSV\File";
            string Input = "TextCSV.csv";
            string output = "output.csv";
            List<Student> liststuden = new List<Student>();
            using (StreamReader rd = new StreamReader($@"{path}\{Input}", Encoding.UTF8))
            {
                var csvreader = new CsvReader(rd, CultureInfo.CurrentCulture);
                liststuden = csvreader.GetRecords<Student>().ToList();
            }
            
            List<ResStudent> resStudents = new List<ResStudent>();

            foreach (Student res in liststuden)
            {
                ResStudent item = new ResStudent()
                {
                    Id = res.Id,
                    Dob = res.Dob,       
                    Math = res.Math,
                    Physics = res.Physics,
                    Chemistry = res.Chemistry
                };
                item.Genders(res.Gender);
                item.Name(res.FullName);
                resStudents.Add(item);
            }

            using (StreamWriter wt = new StreamWriter($@"{path}\{output}", append:false,  Encoding.UTF8))
            {
                
                var csv = new CsvWriter(wt, CultureInfo.InvariantCulture);
                csv.WriteRecords(resStudents);
            }
                  
        }
    }
}

