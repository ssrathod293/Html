using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string str = "shrikant";
            Console.WriteLine(String.Concat(str.OrderBy(s => s))); 
            */
            ///////////////////////
            /*
            var res=sortstring("shrikant");
            Console.WriteLine(res);*/

            ///word sort
            string s = "shrikant";
            char[] ch = s.ToArray();
            Array.Sort(ch);
            foreach (var item in ch)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in ch.Reverse())
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            string str = "shrikant,rathod,jaypal,omkar,dilip";
            var str1 = str.Split(',');
            foreach (var item in str1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Array.Sort(str1);
            foreach (var item in str1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in str1.Reverse())
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
            string num = "45,14,12,45,60,89,24";
            string[] num1 =num.Split(',');
            foreach (var item in num1)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Array.Sort(num1);
            foreach (var item in num1)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            foreach (var item in num1.Reverse())
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }
        static string sortstring(string input)
        {
            char[] character = input.ToArray();
            Array.Sort(character);
            return new string(character);
        }

    }
}
