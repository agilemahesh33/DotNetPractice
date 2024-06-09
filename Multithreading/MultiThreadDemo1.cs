using System.Diagnostics;

namespace Multithreading
{
    internal class MultiThreadDemo1
    {        
        static Stopwatch sw = new Stopwatch();
        static void Test1()
        {            
            sw.Start();
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test1 " + i);
                if (i == 50)
                {
                    Console.WriteLine("Thread Sleep");
                    Thread.Sleep(15000); //Puts the Current Thread To Sleep i.e. MainThread
                    Console.WriteLine("Thread woke-up");
                }
            }
            sw.Stop();
            Console.WriteLine("Ticks 1 : " + sw.ElapsedTicks + " ms : " + sw.ElapsedMilliseconds);
        }
        static void Test2()
        {
            sw.Start();      
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test2 " + i);                
            }
            sw.Stop();
            Console.WriteLine("Ticks 2 : " + sw.ElapsedTicks + " ms : " + sw.ElapsedMilliseconds);
        }
        static void Test3()
        {
            sw.Start();
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test3 " + i);
            }
            sw.Stop();
            Console.WriteLine("Ticks 3 : " + sw.ElapsedTicks + " ms : " + sw.ElapsedMilliseconds);
        }
        public static void Main()
        {
            Test1();
            Test2();
            Test3();
        }
    }
}
