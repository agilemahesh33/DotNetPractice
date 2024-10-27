using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class ReverseString
    {
        public static void GetReversedString(string str)
        {

            string reverse = string.Empty;
            foreach (char ch in str)
            {
                reverse = ch + reverse;
            }
            Console.WriteLine($"Original String {str} and Reversed String {reverse}");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String : ");
            GetReversedString(Console.ReadLine());
        }
    }
}
