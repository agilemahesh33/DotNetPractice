namespace OOPSProject
{
    /// <summary>
    /// Program for demonstration of static and nostatic constructor call
    /// static Constructor is the first block of code that is executed before the Main()
    /// static Constructors use is to initialise only static and constant data members which is called only once.
    /// </summary>
    internal class Constructors
    {
        //static int x = 0;
        static Constructors()
        {
            Console.WriteLine("Static Constructor called");
        }
        Constructors()
        {
            Console.WriteLine("Non-Static Constructor called");
        }
        public static void Main()
        {
            Console.WriteLine("Main Method called");
            Constructors obj = new Constructors();
            Console.ReadLine();
        }
    }
}
