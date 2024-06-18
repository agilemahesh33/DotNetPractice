using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    /// <summary>
    /// This program demonstrate the various types of Fields used during developement
    /// 1. Static : Single Copy per Class, Initialized Declared at a time during execution and can be modified in Static block only
    /// 2. Non- Static : n no of copies with n no of instances, initalization and declaration seperate, multiple copies can be modified  
    /// 3. Constant: cannot be Modified at all, Single Copy per class, At a time Declare and Initialize
    /// 4. ReadOnly : cannot be Modified at all, Multiple Copies (n copies with n instances), Separate Declare and Initialize
    /// </summary>
    internal class Fields
    {
        int x;
        static int y = 200;
        const float pi = 3.14f;
        readonly bool flag;
        public Fields(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        static void Main()
        {
            Console.WriteLine("Static Field y : " + y);
            Console.WriteLine("Constant Field pi : " + pi);
            y = 500;//Can be modified
            //pi = 5.6f; //Cannot be modified, throws error
            Console.WriteLine("Modified Static Field y : " + y);
            Console.WriteLine("---------------------------------");
            //Creating instance of class
            Fields f1 = new Fields(300, true);
            Fields f2 = new Fields(500, false);
            Console.WriteLine("Non Static Fields : " + f1.x + " " + f2.x);
            Console.WriteLine("ReadOnly Fields : " + f1.flag + " " + f2.flag);
            f1.x = 100;
            f2.x = 200;
            //f1.flag = false;//Cannot be modified, throws error
            //f2.flag = true;//Cannot be modified, throws error
            Console.WriteLine("Modified Non Static Fields : " + f1.x + " " + f2.x);
            Console.ReadLine();
        }
    }
}
