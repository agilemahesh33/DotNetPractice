using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class NumberToBinary
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number To convert into Binary");
            int num = int.Parse(Console.ReadLine());
            //int[] binary = new int[16];
            ArrayList binary = new ArrayList();

            //Console.WriteLine(num % 2);
            int multiplier = num;
            for (int i = 0; num > 0; i++)
            {
                binary.Add(num % 2);// binary[i] = num % 2;
                num = num / 2;
            }
            //Console.WriteLine(binary.Count);
            //binary.Reverse();
            for (int i = binary.Count-1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
        }
    }
}
