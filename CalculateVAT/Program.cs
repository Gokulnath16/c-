using System;
using System.Collections.Generic;
using System.Text;
namespace testteckTest
{
    class vat
    {
        public static double vatt(char ch, double cost)
        {
            double tax = 0; if (cost < 0) tax = -1;
            else if (ch != 'M' && ch != 'V' && ch != 'C' && ch != 'E') tax = -1;
            else if (ch == 'M')
                tax = 0.09 * cost;
            else if (ch == 'V')
                tax = 0.05 * cost;
            else if (ch == 'C')
                tax = 0.12 * cost;
            else if (ch == 'E')
                tax = 0.625 * cost; return tax;
        }
    }
}
namespace testteckTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INPUT PLZZ...");
            char x = Convert.ToChar(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hello World!");
            Console.WriteLine("the tax is: " + vat.vatt(x, c));
        }
    }
}