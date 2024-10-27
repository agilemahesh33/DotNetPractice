using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class SumOfDigits
    {
        public static void TotalOfDigits(int no)
        {
            int sum = 0;
            while (no > 0)
            {
                sum = sum + (no % 10);
                no /= 10;
            }
            Console.WriteLine($"Sum of Digits is : {sum} ");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number to find Sum of Digits");
            TotalOfDigits(int.Parse(Console.ReadLine()));
        }
    }
}
