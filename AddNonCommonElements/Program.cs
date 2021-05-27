using System;
using System.Collections.Generic;

namespace AddNonCommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li1 = new List<int>() {5, 9, 1, 0};
            List<int> li2 = new List<int>() {10, 9, 5};
            List<int> li3 = new List<int>();            

            foreach (int item in li1)   {
                if(li2.Contains(item)) {
                    li3.Add(item);
                }
            }

            int sum = 0;
            for(int i = 0; i < li1.Count; i++) {
                if(li3.Contains(li1[i]) == false) {
                    sum += li1[i];
                }
            }
            for(int j = 0; j < li2.Count; j++) {
                if(li3.Contains(li2[j]) == false) {
                    sum += li2[j];
                }
            }

            Console.WriteLine(sum);

        }
    }
}
