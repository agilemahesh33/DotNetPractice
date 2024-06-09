namespace OOPSProject
{
    /// <summary>
    /// Program to Demonstrate inout(ref)parameter i.e. passing and recieving values use same variable
    /// </summary>
    internal class InOutParameters
    {
        public void Factorial(ref uint no)
        {
            if (no == 0 || no == 1)
            {
                no = 1;
            }
            else
            {
                uint result = 1;
                for(uint i=no;i>=2; i--)
                {
                    result = i * result;
                }
                no = result;
            }
        }
        public static void Main(string[] args)
        {
            InOutParameters inout = new InOutParameters();
            uint no = 5;
            Console.WriteLine($"Factorial of {no} = ");
            inout.Factorial(ref no);
            Console.WriteLine(no);
        }
    }
}
