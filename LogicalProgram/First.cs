using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class First
    {
        static int x;    // Global Declaration called Field
        static void Main()
        {
            int y = 1; //Local declaration called variable
            Console.WriteLine($"Value of x : {x}");
            Console.WriteLine($"Value of y : {y}");
            Console.ReadLine();
        }
    }
}
