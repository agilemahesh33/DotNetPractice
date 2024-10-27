using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PalindromeNumber
    {
        public static void checkPalindrom(int n)
        {
            int reverse = 0;
            int temp = n;
            while (temp != 0)
            {
                reverse = (reverse * 10) + (temp % 10);
                temp = temp / 10;
            }
            Console.WriteLine(reverse);
            if (reverse == n) 
                Console.WriteLine("Palindrome Number");
            else
                Console.WriteLine("Not Palindrome Number");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number To check Palindrome or not : ");            
            checkPalindrom(int.Parse(Console.ReadLine()));
        }
    }
}
