using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> arr = new List<int>() {1, 2, 7, 2, 4, 8, 9, 6, 8};
            
            var arr1 = arr.GroupBy(x => x).Where(g => g.Count() > 1).Select(y=> y.Key).ToList();

            arr.RemoveAll(ele => arr1.Contains(ele));

            int sum = arr.Where(i => i%2 == 0).Sum();

            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine(string.Join(", ", arr1));
            Console.WriteLine(sum);


        }
    }
}
