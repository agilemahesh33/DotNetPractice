namespace Multithreading
{
    internal class ThreadDemo
    {
        static void Main()
        {
            Thread t = Thread.CurrentThread;
            t.Name= "Main Thread";  // Explicitly Given a name to Main Thread by default it has no name
            Console.WriteLine("Current Executing Thread is : "+ Thread.CurrentThread.Name);
            Console.WriteLine();
        }
    }
}
