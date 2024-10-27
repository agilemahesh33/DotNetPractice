using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class CombinedStringOperations
    {
        static char? conti ;
        public static void GetLength()
        {

        }
        public static void stringReverse()
        {

        }
        public static void Main(string[] args)
        {            
            do
            {
                Console.Write("Menu\n1.Get Length\n2.Reverse\nEnter Your Choice: ");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        GetLength();
                        break;
                    case 2:
                        stringReverse();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Do you want to contine (Y/N)");
                conti = char.Parse(Console.ReadLine());
            } while ((conti == 'Y') || (conti == 'y'));
        }
    }
}
