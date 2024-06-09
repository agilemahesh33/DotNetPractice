
namespace Multithreading
{
    internal class MultiThreadingDemo6_Priorities
    {
        static long count1, count2;
        public static void IncrementCount1()
        {
            while (true)
            {
                count1 += 1;
            }
        }
        public static void IncrementCount2()
        {
            while (true)
            {
                count2 += 1;
            }
        }
        public static void Main()
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);
            //to set priorities 
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;
            t1.Start(); t2.Start();
            //lets make main thread sleep for 5000ms
            Console.WriteLine("Main Thread Sleeping");
            Thread.Sleep(5000);
            Console.WriteLine("Main Thread Woke-up");
            //to Terminate a thread use Abort()
            t1.Abort();            t2.Abort();
            //t1.Interrupt();        t2.Interrupt();
            t1.Join();            t2.Join();  
            Console.WriteLine("count1 " + count2);
            Console.WriteLine("count2 " + count2);            
        }
    }
}
