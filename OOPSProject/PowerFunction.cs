namespace OOPSProject
{
    internal class PowerFunction
    {        
        /// <summary>
        /// Calculate n power m of given numbers
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = null;
            int? pow = 0;
            if (args.Length > 1)
            {
                num1 = int.Parse(args[0]);
                pow = num1;
                num2 = int.Parse(args[1]);
                for (int i = 1;i< num2; i++)
                {
                    pow = num1 * pow; 
                }
                Console.WriteLine(num1 + "^" + num2 + " = " + pow);
            }
        }
    }
}
