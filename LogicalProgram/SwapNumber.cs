namespace LogicalProgram
{
    internal class SwapNumber
    {
        public static (int x, int y) SwapNoSol1(int x, int y)
        {
            x= x*y; 
            y= x/y;
            x= x/y;
            return(x, y);
        }
        public static void SwapNoSol2(ref int x, ref int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;            
        }
        public static void Main()
        {
            int x = 10, y = 20;
            Console.WriteLine("Before Swap " + x + " :  " + y);
            (x, y) = SwapNoSol1(x, y);
            Console.WriteLine("After Swap " +  x + " :  " + y);
            int p = 30, q = 34;
            Console.WriteLine("Before Swap " + p + " :  " + q);
            SwapNoSol2 (ref p ,ref q);
            Console.WriteLine("After Swap " + p + " :  " + q);
        }
    }
}
