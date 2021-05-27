using System;

namespace SumConnonElements
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Use first array to check the elements in other array
            //add matching ele in new arr

            int[] arr1 = {346, 545, 546, 8, 85};
            int[] arr2 = {8};
            int sum = 0;

            for(int i = 0; i < arr1.Length; i++) {
                if((Array.Exists(arr2, ele => ele == arr1[i])) == true) {
                    sum += arr1[i];
                }
            }

            if(sum == 0) {
                Console.WriteLine("No Ele");
            }
            else {
                Console.WriteLine(sum);
            }

        }
    }
}
