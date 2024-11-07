using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; //to calculate total time required to execute
namespace OOPSProject
{
    internal class StringStringBuilderDemo
    {
        public static void Main(string[] args)
        {

            string str = "";
            Stopwatch sw = Stopwatch.StartNew();
            
            for (int i = 0; i < 100000; i++)
            {
                str = str + i;
            }
            sw.Stop();
            Console.WriteLine("Miliseconds for String : " + sw.ElapsedMilliseconds);
            StringBuilder sb = new StringBuilder();
            Stopwatch sw2 = Stopwatch.StartNew();
            for(int i = 0; i < 100000; i++)
            {
                sb.Append(i.ToString());
            }
            sw2.Stop();            
            Console.WriteLine("Miliseconds for StringBuilder : " + sw2.ElapsedMilliseconds);
        }        
    }
}
