using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "acebisouzz";
            string a = "aeiou";
            char[] c = s.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (char item in c)
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                sb.Append(item);
            }
            string b = sb.ToString();
            if (a == b)
                Console.WriteLine("1");
            else
                Console.WriteLine("-1");
            
        }
    }
}
