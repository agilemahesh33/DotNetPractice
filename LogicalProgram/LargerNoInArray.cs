using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class LargerNoInArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How Many Elements in Array ? ");
            int UB = int.Parse(Console.ReadLine());
            int[] array = new int[UB];
            int max = 0;
            Console.WriteLine($"Enter {UB} Elements in Array ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your Array is : ");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            for (int i = 0;i < array.Length;i++)
            {
                if(array[i] >max) 
                    max = array[i];
            }
            Console.WriteLine($"Larger Number is : {max}");
        }
    }
}
