using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    /// <summary>
    /// Delegates : It a Typesafe function pointer
    /// A Delegate is a user defined type like a class, structure, Inheritance etc.
    /// Every type in C# is defined under namespace, it is also possible to define inside a class.
    /// [Namespace : it is a logical container of types]
    /// Delegate holds the reference of a method and then call the method for execution
    /// Existing ways to call method are
    /// By Using instance of a class if it is a non-static mehtod.
    /// By using the name of the class if it is a static method.
    /// New and 3rd way of calling method is a using Delegate
    /// To call a method using delegate follow the below steps:
    ///     1. Define Delegate either in namespace or in a class
    ///         a. Delegate must have same return type as that of the method
    ///         b. Parameter datatype must be same as that of the method.
    ///     2. Instantiate Delegate 
    ///         It is a process of creating instance of delegate and 
    ///         require to pass method name as a parameter.
    ///         Instance created in static block cannot call nonstatic method directly.
    ///     3. Call the Delegate
    ///    
    /// Types of Delegate:
    /// 1. Singlecast Delegates
    /// 2. Multicast Delegates
    /// 3. Anonymous Delegates
    /// 4. Lambda Expression Delegates
    /// 5. Predefined Generic Delegates
    ///     5.1. Func
    ///     5.2. Action
    ///     5.3. Predicate
    /// </summary>
    internal class DelegateSingleCast
    {
        public delegate void AddDelegate(int x, int y);
        public delegate string SayDelegate(string s1);
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public string SayHello(string s)
        {
            return "Hello " + s + "! How you doing?";
        }
        public static void Main(string[] args)
        {
            DelegateSingleCast ds = new DelegateSingleCast();
            AddDelegate ad = new AddDelegate(ds.AddNums);
            ad.Invoke(13, 33);

            SayDelegate sd = new SayDelegate(ds.SayHello);
            Console.WriteLine(sd.Invoke("Mahesh"));
        }
    }
}
