using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    /// <summary>
    /// It is a shorthand for writing Anonymous methods
    /// No need to use Delegate keyword
    /// No need to pass parameter type
    /// </summary>
    public delegate string LambdaGreetingDelegate(string sname);
    internal class DelegateLambdaExpr
    {
        public static void Main(string[] args)
        {
            LambdaGreetingDelegate gdObj = (sname) =>
            {
                return "Hello " + sname;
            };
            string str = gdObj.Invoke("Mahesh");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
