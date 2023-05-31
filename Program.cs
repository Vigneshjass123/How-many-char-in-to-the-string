using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_the_how_may_char_avaliable_in_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "success";
            int count = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            foreach(char b in s)
            {
                if(b=='s')
                {
                    count++;
                }
                if (b == 'u')
                {
                    count1++;
                }
                if (b == 'c')
                {
                    count2++;
                }
                if (b == 'e')
                {
                    count3++;
                }
            }
            Console.WriteLine("S = "+ count);
            Console.WriteLine("u = " + count1);
            Console.WriteLine("c = " + count2);
            Console.WriteLine("e = " + count3);
            Console.ReadLine();
        }
    }
}
