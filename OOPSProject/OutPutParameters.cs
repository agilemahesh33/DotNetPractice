namespace OOPSProject
{
    /// <summary>
    /// Question : how sto return multiple values from a method
    /// </summary>
    internal class OutPutParameters
    {
        public void Math1(int a , int b, out int c, out int d)
        {
            c = a+b;
            d = a*b;
        }
        public (int, int) Math2(int a, int b)
        {
            int c = a+b;
            int d = a*b;
            return (c, d);
        }
        public static void Main()
        {
            OutPutParameters p = new OutPutParameters();
            int sum1, prod1;
            p.Math1(2,4,out sum1,out prod1);
            Console.WriteLine("First Way : " + sum1 + " " + prod1);

            p.Math1(4, 6, out int sum2, out int prod2);
            Console.WriteLine("Second Way : " + sum2 + " " + prod2);

            (int sum3, int prod3) = p.Math2(10, 20);
            Console.WriteLine("Third Way : " + sum3 + " " + prod3);

            var (sum4, prod4) = p.Math2(20, 30);
            Console.WriteLine("Forth Way : " + sum4 + " " + prod4);
        }
    }
}
