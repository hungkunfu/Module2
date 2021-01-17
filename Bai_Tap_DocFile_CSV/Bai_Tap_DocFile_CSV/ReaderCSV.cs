using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bai_Tap_DocFile_CSV
{
   public class ReaderCSV
    {
        public List<string> LoadCsvFile(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filePath));
            List<string> searchList = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                searchList.Add(line);
            }
            return searchList;
        }
    }
}
