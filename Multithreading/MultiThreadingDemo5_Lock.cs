namespace Multithreading
{
    internal class MultiThreadingDemo5_Lock
    {
        /// <summary>
        /// Every Thread is waiting in Wait zone to 
        /// finish the execution of previous thread 
        /// and executing one after other
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Wait");
            lock (this)
            {
                Console.Write("[C# is a ");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented Language");
            }
        }
        public static void Main()
        {
            MultiThreadingDemo5_Lock obj = new MultiThreadingDemo5_Lock();
            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);
            t1.Start(); t2.Start(); t3.Start();
            Console.ReadLine();
        }
    }
}
