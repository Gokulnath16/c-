using System;
using System.Collections.Generic;
using System.Linq;

namespace ImageTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            string[] arr = {"Employee.jpeg", "Purchase.jpeg", "whdd.png", "sd.ss"};
            List<string> extensions = new List<string>() {"jpeg","jfif","exif","tiff","raw","gif","bmp","png"};
            List<string> li = new List<string>(arr);
            List<string> GetImgType = new List<string>();
            List<string> GetUniqueType = new List<string>();
            List<string> res = new List<string>();

            
            foreach(string s in li) {
                string[] getEle = s.Split(".");
                GetImgType.Add(getEle[1]); 
                if(!GetUniqueType.Contains(getEle[1])) { GetUniqueType.Add(getEle[1]); }
            }

            int count;
            int otherCount = 0;

            foreach(string item in GetUniqueType) {
                if(extensions.Contains(item)) {
                    count = 0;
                    foreach(string i in GetImgType) {
                        if(i == item) { 
                            count++; 
                        }                         
                    }
                    res.Add(item);
                    res.Add(count.ToString());
                }
                else { otherCount++; }
            }
            
            res.Add("others");
            res.Add(otherCount.ToString());

            Console.WriteLine(string.Join(", ", GetImgType));
            Console.WriteLine(string.Join(", ", GetUniqueType));
            Console.WriteLine(string.Join(", ", res));


        }
    }
}
