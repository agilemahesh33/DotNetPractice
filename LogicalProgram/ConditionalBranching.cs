using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class ConditionalBranching
    {
        static void Main()
        {
            int y = 1;
            Console.WriteLine("----------------If Statement-----------------------");
            if (y == 1)
                Console.WriteLine("If statement executed");
            else
                Console.WriteLine("Else Statement excuted");
            Console.WriteLine("----------------Switch Case-----------------------");
            Console.WriteLine("Enter Number between 1-3:");
            int no = int.Parse(Console.ReadLine());
            switch (no)
            {
                case 1:
                    Console.WriteLine("Entered No is : " + no);
                    break;
                case 2:
                    Console.WriteLine("Entered No is : " + no);
                    break;
                case 3:
                    Console.WriteLine("Entered No is : " + no);
                    break;
                default:
                    Console.WriteLine("Entered No does not fall between 1-3");
                    break;
            }
            Console.ReadLine();
        }
    }
}
