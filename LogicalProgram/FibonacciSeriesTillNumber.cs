using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class FibonacciSeriesTillNumber
    {
        public static void GenerateFibonacci(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("0");
            }
            else if (n == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                int no = 0;
                int no1 = 1;
                int result = 0;
                Console.Write(no + " ");
                while (result < n)
                {
                    result = no + no1;
                    no = no1;
                    no1 = result;
                    Console.Write(no + " ");
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Upper Bound for Fibonacci Series");
            GenerateFibonacci(int.Parse(Console.ReadLine()));  
        }
    }
}
