using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalizer
{
    internal class DestructorDemo1
    {
        public DestructorDemo1()
        {
            Console.WriteLine("Instance Created");
        }
        ~DestructorDemo1() 
        { 
            Console.WriteLine("Instance is Destroyed");
        }
        public static void Main(string[] args)
        {
            DestructorDemo1 demo = new DestructorDemo1();
            DestructorDemo1 demo1 = new DestructorDemo1();
            DestructorDemo1 demo2 = new DestructorDemo1();
            demo1=null; demo2 = null; demo = null;GC.Collect();
            new DestructorDemo1(); //Un-named Instance
            Console.ReadLine();
        }
    }
}
