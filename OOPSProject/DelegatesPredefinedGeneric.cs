using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    /// <summary>
    /// Predefined Generic Delegates
    /// There are few delegates that are system defined and 
    /// can be used on some conditions
    ///     1. func :
    ///         It is used when a method returns a value. 
    ///         It has 17 Overloads (16 I/P and 1 O/P)
    ///     2. action :
    ///         It is used when a method returns a void.
    ///         It has 16 overloads(16 Inputs)
    ///     3. predicate
    ///         It is used when a method returns a boolean.
    /// </summary>
    /// After Output using Singlecast comment delegates and
    /// anonymous mothods and write using lambda expression
    /// 

    //public delegate double Delegate1(int x, float y, double z);
    //public delegate void Delegate2(int x, float y, double z);
    //public delegate bool Delegate3(string str);
    internal class DelegatesPredefinedGeneric
    {
        //public static double AddNum1(int x, float y, double z)
        //{
        //    return x + y + z;
        //}
        //public static void AddNum2(int x, float y, double z)
        //{
        //    Console.WriteLine("Result : " + x + y + z);
        //}
        public static bool checkLength(string str)
        {
            if(str.Length>5) {return true;}
            else {return false;}
        }
        public static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = (x, y, z) =>
            {
                return x + y + z;
            };
            double result = obj1.Invoke(123, 45.67f, 123.33);
            Console.WriteLine(result);
            Action<int, float, double> obj2 = (x, y, z) =>
            {
                Console.WriteLine("Result : " + x + y + z);
            };            
            obj2.Invoke(123, 45.67f, 123.33);
            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 5) { return true; }
                else { return false; }
            };
            bool b = obj3.Invoke("Mahesh");
            Console.WriteLine(b);

            //Delegate1 obj1 = new Delegate1(AddNum1);
            //double result = obj1.Invoke(123,45.67f,123.33);
            //Console.WriteLine(result);            

            //Delegate2 obj2 = new Delegate2(AddNum2);
            //obj2.Invoke(123, 45.67f, 123.33);

            //Delegate3 obj3 = new Delegate3(checkLength);
            //bool b = obj3.Invoke("Mahesh");
            //Console.WriteLine(b);
        }
    }            
}
