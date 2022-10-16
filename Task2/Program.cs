using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str2 = "";
            string str3 = "";
            foreach (char c in str)
            {
                str2 = c + str2.Trim().ToLower();
                str3 = str3.Trim().ToLower() + c;
            }
            if (str2 == str3)
            {
                Console.WriteLine("Фраза является палиндромом");
            }
            else
            {
                Console.WriteLine("Фраза не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
