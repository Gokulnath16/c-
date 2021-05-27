using System;
using System.Collections.Generic;

namespace SortList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string>() {"write", "read", "edit"};
            char c = 'e';
            List<string> li = new List<string>();

            foreach(string i in s) {
                if(i.StartsWith(Convert.ToString(c))) {
                    li.Add(i);
                }
            }

            foreach(string i in li) {
                s.Remove(i);
            }            
            s.Sort();
            Console.WriteLine(string.Join(", ", s));
            
        }
    }
}
