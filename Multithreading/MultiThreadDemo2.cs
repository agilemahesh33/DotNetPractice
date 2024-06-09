using System.Diagnostics;

namespace Multithreading
{
    internal class MultiThreadDemo2
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
                    Thread.Sleep(15000);
                    Console.WriteLine("Thread woke-up");
                }
            }
            sw.Stop();
            Console.WriteLine("Ticks 1 : " + sw.ElapsedTicks + " ms : " + sw.ElapsedMilliseconds);
            Console.WriteLine("Thread T1 is exiting");
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
            Console.WriteLine("Thread T2 is exiting");
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
            Console.WriteLine("Thread T3 is exiting");
        }

        //Parameterized Method call using Delegate in Multitreading
        static void Test4(object max)//ParameterizedThreadStart accepts only object as parameter
        {
            sw.Start();
            int num = Convert.ToInt32(max);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("Test4 " + i);
            }
            sw.Stop();
            Console.WriteLine("Ticks 4 : " + sw.ElapsedTicks + " ms : " + sw.ElapsedMilliseconds);
            Console.WriteLine("Thread T4 is exiting");
        }
        public static void Main()
        {
            //I //1. ThreadStart obj = new ThreadStart(Test1);  Or
            //2. ThreadStart obj = Test1;  or
            //3. ThreadStart obj = delegate { Test1(); }; or
            //4. ThreadStart obj = () => Test1(); or
            //5. ThreadStart obj = () => { // Method body };
            //Thread T = new Thread(obj);
            //T.Start();
            //I or II
            //II. Thread T = new Thread(Test1); T.Start();
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);
            T1.Start();T2.Start();T3.Start();

            ParameterizedThreadStart objPara = new ParameterizedThreadStart (Test4);// Instantiation of Delegate
            Thread thr = new Thread(objPara); //Creating Thread and pass object of ParameterizedThreadStart as parameter
            thr.Start(15);//Passing parameter to the method
            Console.WriteLine("Thread Main is exiting");
        }
    }
}
