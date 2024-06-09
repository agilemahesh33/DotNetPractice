using System.Diagnostics;
using System.Text;
using static System.Console;
namespace OOPSProject
{    
    /// <summary>
    /// Example to Demonstrate different types of variables and Field
    /// Also example of Static import Statement which allows us 
    /// to use Static members without using prefix
    /// </summary>
    internal class TypesDemo
    {
        static byte by;     //Field
        static int x;       //Field
        static short s;     //Field
        static long z;      //Field
        static sbyte sb;    //Field
        static ushort us;   //Field
        static uint ui;     //Field
        static ulong ul;    //Field
        static void Main()
        {
            Clear();
            WriteLine("Field by value is " + by + " and its type is : " + by.GetType());
            WriteLine("Field x value is " + x + " and its type is : " + x.GetType());
            WriteLine("Field s value is " + s + " and its type is : " + s.GetType());
            WriteLine("Field z value is " + z + " and its type is : " + z.GetType());
            WriteLine("Field sb value is " + sb + " and its type is : " + sb.GetType());
            WriteLine("Field us value is " + us + " and its type is : " + us.GetType());
            WriteLine("Field ui value is " + ui + " and its type is : " + ui.GetType());
            WriteLine("Field ul value is " + ul + " and its type is : " + ul.GetType());            
            int y = 10;                 //Variable
            Console.WriteLine("Variable y Value is " + y + " and its type is : " + y.GetType());
            float f = 3.14f;            //Variable
            Console.WriteLine("Variable f Value is " + f + " and its type is : " + f.GetType());
            double d = 3.14;            //Variable
            Console.WriteLine("Variable d Value is " + d + " and its type is : " + d.GetType());
            decimal de = 3.14m;         //Variable
            Console.WriteLine("Variable de Value is " + de + " and its type is : " + de.GetType());
            bool b  = true;             //Variable
            Console.WriteLine("Variable b Value is " + b + " and its type is : " + b.GetType());
            char ch= 'A';               //Variable
            Console.WriteLine("Variable y Value is " + ch + " and its type is : " + ch.GetType());
            string str = "STRING";      //Variable
            Console.WriteLine("Variable str Value is " + str + " and its type is : " + str.GetType());
            DateTime dt = DateTime.Now;//Variable
            Console.WriteLine("Variable dt Value is " + dt + " and its type is : " + dt.GetType());
        }
    }
}
