using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    /// <summary>
    /// Anonymous method is an inline mehtod and it does not have a name
    /// i.e. it has only body
    /// We can define it using a delegate.
    /// i.e. without binding named method to delegate we can bind the body to the delegate
    /// 
    /// </summary>
    /// 
    public delegate string GreetingsDelegate (string name);
    internal class DelegateAnonymous
    {
        public static string Greetings1(string name)
        {
            return "Hello " + name + "! How are you?" ;
        }
        public static void Main(string[] args)
        {
            //Siglecast way of calling a delegate
            DelegateAnonymous da = new DelegateAnonymous();
            GreetingsDelegate GDObj = new GreetingsDelegate(Greetings1);
            Console.WriteLine(GDObj.Invoke("Mahesh"));

            //Anonymous Delegate: Without Body
            //Advantages is less code and suggested only when less code is in method <15 LOC
            GreetingsDelegate gd = delegate (string name)
            {
                return "Hello " + name + "! from Anonymous Delegate";
            };
            Console.WriteLine(gd.Invoke("Mahesh"));
        }
    }
}
