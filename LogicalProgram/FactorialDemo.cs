using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class FactorialDemo
    {
        public static void findFactorial(int no)
        {
            int fact = 1;
            for (int i = no;  i >= 2; i--) 
            {
                fact = fact * i;
            }
            Console.WriteLine($"Factorial of {no} is {fact}");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter No to find Factorial : ");
            findFactorial(int.Parse(Console.ReadLine()));            
        }
    }
}
