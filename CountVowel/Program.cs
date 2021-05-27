using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripprob4
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                UserProgramCode p = new UserProgramCode();
                Console.WriteLine(" Enter string to count Vowels");
                string st = Console.ReadLine();
                int ans = p.countVowels(st);
                Console.WriteLine(ans);
                Console.ReadKey();
            } while (true);
        }
    }
}
class UserProgramCode
{
    public int countVowels(string st)
    {
        st.ToLower();
        int count = 0;
        if (!st.All(char.IsLetter))
        {
            //Console.WriteLine("Input contains digit/special Symbols also");
            count = -1;
            goto finish;
        }
        char[] arr = st.ToCharArray();
        foreach (var c in arr)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                count++;
            }
        }
    finish:
        return count;
    }
}