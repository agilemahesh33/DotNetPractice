namespace Multithreading
{
    /// <summary>
    /// In previous examples main thread gets exited befor completion of other 3 threads and 
    /// this should not happen. To avoid this use Thread.Join().
    /// </summary>
    internal class MultiThreadingDemo3_Join
    {
        static void Test1()
        {
            Console.WriteLine("Test1 Thead is starting");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Test1() : " + i);
                Thread.Sleep(5000); //delayed to test when main thread is exitin.i.e. at the end
            }
            Console.WriteLine("Test1 Thead is exiting");
        }
        static void Test2()
        {
            Console.WriteLine("Test2 Thead is starting");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Test2() : " + i);
            }
            Console.WriteLine("Test2 Thead is exiting");
        }
        static void Test3()
        {
            Console.WriteLine("Test3 Thead is starting");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Test3() : " + i);
            }
            Console.WriteLine("Test3 Thead is exiting");
        }
        static void Main()
        {
            Console.WriteLine("Main Thread Started");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();            t2.Start();            t3.Start();
            t1.Join(2000);             t2.Join();             t3.Join();//Without join random threads will call and/ exit any time
            Console.WriteLine("Main Thread is Exiting");
        }
    }
}
