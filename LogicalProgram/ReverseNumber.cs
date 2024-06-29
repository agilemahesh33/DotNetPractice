using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    /// <summary>
    /// Program to reverse the given numbers 
    /// ex : 123 to 321
    /// </summary>
    internal class ReverseNumber
    {
        public static void ReverseDigits(ref int num)
        {
            int reminder = 0;
            int reverse =0;
            while (num != 0)
            {
                reminder = num % 10;
                reverse = reverse * 10 + reminder;
                num = num / 10;
            }
            num = reverse;
        }
        public static void Main()
        {
            Console.WriteLine("Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            ReverseDigits(ref num);
            Console.WriteLine("Reverse Number : " + num);
        }
    }
}
