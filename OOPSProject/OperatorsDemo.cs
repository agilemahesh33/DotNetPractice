
using System.Diagnostics;

namespace OOPSProject
{
    /// <summary>
    /// Miscellaneous Operators and (Coalesce)
    /// 
    /// </summary>
    internal class OperatorsDemo
    {
        static void Main()
        {
            Console.WriteLine("Operators Demo");
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(sizeof(short));
            Console.WriteLine(sizeof(long));
            Console.WriteLine(sizeof(sbyte));
            Console.WriteLine(sizeof(ushort));
            Console.WriteLine(sizeof(uint));
            Console.WriteLine(sizeof(ulong));
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(float));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(char));
            Console.WriteLine(sizeof(decimal));
            Console.WriteLine(sizeof(bool));
            //Console.WriteLine(sizeof(DateTime));
            //Console.WriteLine(sizeof(Guid));
            Console.WriteLine(sizeof(char));
            //Console.WriteLine(sizeof(String));
            //Console.WriteLine(sizeof(object));
            //Console.ReadLine();
            double d = 34.56;
            object obj1 = d;   //Boxing
            if (obj1 is double)   // is : is a type comparison operator
            {
                Console.WriteLine("d is type of System.Double");
            }
            string str1 = "Hello World";
            object obj2 = str1;    //Boxing
            string str2 = (string)obj2; //Unboxing
            string str3 = obj2 as string; // as :  is a type conversion Operator
            string str4 = obj2.ToString();
            int i = 100;
            Console.WriteLine(i == 100 ? "Hello India" : "Hello World"); //Ternery Operator
            string Country1 = null;
            string Country2 = null;
            string Country3 = "India";
            Console.WriteLine(Country1??Country1);
            Console.WriteLine(Country1 ?? Country2 ?? Country3); //India
            Country2 = "Bharat";
            Console.WriteLine(Country1 ?? Country2 ?? Country3);  //Bharat
            Console.WriteLine(Country2 ?? Country1 ?? Country3);  //Bharat
            Console.ReadLine();
        }
    }
}
