namespace Multithreading
{
    /// <summary>
    /// Context Switching between thread is done bitween t1,t2,t3 see the output
    /// </summary>
    internal class MultiThreadingDemo4_Lock
    {
        public void Display()
        {
            Console.Write("[C# is a ");
            Thread.Sleep(5000);
            Console.WriteLine("Object Oriented Language");
        }
        public static void Main()
        {
            MultiThreadingDemo4_Lock obj = new MultiThreadingDemo4_Lock();
            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);
            t1.Start();            t2.Start();            t3.Start();
            Console.ReadLine();
        }
    }
}
