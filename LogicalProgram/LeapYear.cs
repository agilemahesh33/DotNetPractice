using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    /// <summary>
    /// Leap Year is basically dicided by no of days fall in the Yeaer 
    /// if days in a year 366 then Leap Year
    /// else common year / Tropical Year
    /// </summary>
    internal class LeapYear
    {
        public static void CheckLeap(int Year)
        {
            if ((Year % 4) == 0)
            {
                if ((Year % 4) == 100)
                {
                    if (Year % 100 == 0)
                    {
                        Console.WriteLine("Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("Common Year");
                    }
                }
                else
                {
                    Console.WriteLine("Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Common Year");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Year in 4 digits : ");
            CheckLeap(int.Parse(Console.ReadLine()));        
        }
    }
}
