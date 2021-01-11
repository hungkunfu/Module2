using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bai_Tap_Module2_Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\HungTran\Source\Repos\Bai_Tap_Module2_Bai1\Bai_Tap_Module2_Bai1\Object";
            string input = "input.json";
            string output1 = "output1.json";
            string output2 = "output2.json";
            string data;
            using(StreamReader rd = File.OpenText($@"{path}\{input}"))
            {
                data = rd.ReadToEnd();
            }
            Serialnumbers result = JsonConvert.DeserializeObject<Serialnumbers>(data);
            
           
            List<Resserialnumber> resserialnumber = new List<Resserialnumber>();
            foreach (serialnumber std in result.input)
            {
                var item = new Resserialnumber()
                {
                    a = std.a,
                    b = std.b,
                    c = std.c,

                };
                resserialnumber.Add(item);
            }
            using (StreamWriter sw = File.CreateText($@"{path}\{output1}"))
            {
                sw.Write(JsonConvert.SerializeObject(resserialnumber));
            }
            List<serialnumber> serialnumber = new List<serialnumber>();
            for (int i = 0; i < result.input.Count; i++)
            {
                result.input[i].a *= 2;
                result.input[i].b *= 2;
                result.input[i].c *= 2;
            }
            using (StreamWriter sw = File.CreateText($@"{path}\{output2}"))
            {
                sw.Write(JsonConvert.SerializeObject(result.input));
            }
        }
    }
    class Serialnumbers
    {
        public List<serialnumber> input { get; set; }
      
    }
    class serialnumber
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
      

    }
    class Resserialnumber: serialnumber
    {
        public double Averages => average();
        public double average()
        {
            return (a + b + c);
        }
        
    }


}
