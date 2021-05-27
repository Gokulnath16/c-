using System.Linq;
using System;

namespace ReverseSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = 2;
            int length = 3;
            string s = "rajasthan";
            char[] characters = s.ToCharArray();
            Array.Reverse(characters);
            s = new string(characters);
            //Console.WriteLine(string.Join(",", s));
            string res = string.Join(" ", s.Substring(startIndex, length));
            Console.WriteLine(res);


        }
    }
}
