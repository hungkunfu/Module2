using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_Tap_DocFile_CSV
{
    class ResStudent
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public double Math { get; set; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Averagerate => SumDTB();
        public double SumDTB()
        {
            double SumDTB = 0.0;
            SumDTB = ((Math * 2) + Physics + Chemistry) / 4;
            return System.Math.Round(SumDTB, 2);
        }
        public void Name(string fullname)
        {
            string[] namestring = fullname.Split();
            FirstName = namestring[namestring.Length - 1];
            Array.Resize(ref namestring, namestring.Length - 1);
            LastName = String.Join(" ", namestring);
        }
        public void Genders(string gender)
        {
            if (gender == "1")
            {
                Gender = "Nam";
            }
            else
            {
                Gender = "Nu";
            }
        }


    }
}
