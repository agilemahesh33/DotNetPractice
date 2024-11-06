using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    /// <summary>
    /// Delegates are typesafe pointer to a function.
    /// Singlecast delegates points to single mehtod of a class and 
    /// returns result
    /// In contrast with singlecast delegate, 
    /// a SINGLE DELEGATE calls/points to the multiple methods if they satisfy few conditions
    /// Conditions for multicast delegates:
    ///     1. All mehtds must have same signature i.e. return type and parameters.
    ///     2. As if all the methods are returning values then the multicast delegate shows
    ///        only last value, all previous values will be overwritten.
    /// </summary>
        
    //Delegate Defined in namespace
    public delegate void RectDelegate(double width, double height);
    internal class DelegateMultiCast
    {
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            RectDelegate rdObj = new RectDelegate(rect.getArea);
            //RectDelegate rdObj = rect.getArea;        //Valid
            rdObj.Invoke(12.34, 56.78);
            rdObj = rect.getPerimeter;
            rdObj.Invoke(12.34, 56.78);  //getArea Values will be lost
        }
    }
    class Rectangle
    {
        public void getArea(double width, double height)
        {
            Console.WriteLine(width * height);
        }
        public void getPerimeter(double width, double height)
        {
            Console.WriteLine(2 * (width + height));
        }
    }
}
