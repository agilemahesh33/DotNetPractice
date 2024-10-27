using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    /// <summary>
    /// Input:153
    //Output: Yes
    //153 is an Armstrong number.
    //1*1*1 + 5*5*5 + 3*3*3 = 153
    //Input: 120
    //Output: No
    //120 is not a Armstrong number.
    //1*1*1 + 2*2*2 + 0*0*0 = 9
    //Input: 1253
    //Output: No
    //1253 is not a Armstrong Number
    //1*1*1*1 + 2*2*2*2 + 5*5*5*5 + 3*3*3*3 = 723
    //Input: 1634
    //Output: Yes
    //1*1*1*1 + 6*6*6*6 + 3*3*3*3 + 4*4*4*4 = 1634
    /// </summary>
    internal class AmstrongNumber
    {
        public static void CheckAmstrong(int no)
        {
            int pow= countDigit(no);
            Console.WriteLine($"Total Digits : {pow}");
            int sum = 0;
            int digit = 0;
            int temp = no;
            for (int i = 0; i < pow; i++)
            {
                digit = temp % 10;
                if (digit== 0)
                {
                   //Do nothing to sum 
                }
                else if (digit== 1)
                {
                    sum = sum + 1;
                }
                else
                {
                    sum = sum + MultiMbyN(digit, pow);
                }
                temp = temp / 10;
            }
            if (sum == no)
                Console.WriteLine($"{no} is a amstrong number");
            else 
                Console.WriteLine($"{no} is NOT a amstrong number");
        }
        static int MultiMbyN(int digit, int pow)
        {
            int temp = 1;
            for (int i = 0; i < pow; i++) 
            {
                temp *= digit;                    
            }
            return temp;
        }
        static int countDigit(int n)
        {
            //Case 1:
            //if (n % 10 == 0)
            //    return 1;
            //return 1 + countDigit(n % 10);
            //Case 2:
            //return(int)Math.Floor(Math.Log10(n) + 1);
            //Case 3:
            return n.ToString().Length;

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter No to Check Amstrong or not");
            CheckAmstrong(int.Parse(Console.ReadLine()));
        }
    }
}
