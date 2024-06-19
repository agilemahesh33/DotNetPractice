namespace OOPSProject
{
    /// <summary>
    /// Rules for consuming members within a class:
    /// Static Member => Static Block		    //Direct Access
    /// Static Member => Non - Static Block		//Direct Access
    /// Non-Static Member => Non - Static Block	//Direct Access
    /// Non-Static Member => Static Block		//Can be accessed only by using the class instance
    /// Rules for consuming members out of the class:
    /// Static Members				//Using class name
    /// Non-Static Members			//Using class instance
    /// </summary>
    internal class Methods
    {
        int x = 200;
        static int y = 200;
        public void Add()
        {
            Console.WriteLine(x + y);
        }
        public static void Sub()
        {
            Methods m = new Methods();
            Console.WriteLine(m.x - y);
        }
    }
    internal class TestMethod
    {
        static void Main()
        {
            Methods obj = new Methods();
            obj.Add();
            Methods.Sub();
            Console.ReadLine();
        }
    }
}
