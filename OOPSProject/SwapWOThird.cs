using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class SwapWOThird
    {
        public static void Main()
        {
            Console.WriteLine("Enter Two Numbers : ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            int no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swap Using * and / \n no1 : " + no1 + " no2 : " + no2);
            no1 = no1 * no2; //a=50 (5*10)      
            no2 = no1 / no2; //b=5 (50/10)      
            no1 = no1 / no2; //a=10 (50/5)    
            Console.WriteLine("After Swap Using * and / \n no1 : " + no1 + " no2 : " + no2);

            Console.WriteLine("Reverse as it is user passed using + and -");
            Console.WriteLine("Before Swap \n no1 : " + no1 + " no2 : " + no2);
            no1 = no1 + no2; //a=50 (5*10)      
            no2 = no1 - no2; //b=5 (50/10)      
            no1 = no1 - no2; //a=10 (50/5)    
            Console.WriteLine("After Swap \n no1 : " + no1 + " no2 : " + no2);
        }
    }
}
