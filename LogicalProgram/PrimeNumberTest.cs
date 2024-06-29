namespace LogicalProgram
{
    /// <summary>
    /// Prime number Test : Thsere are two ways
    /// 1. Trial and error method : Dividing the number(N) till the half of the number(N) 
    /// if divisible by any one then not a prime number else prime number
    /// 2. Check the last digit of number(N) falls between 0 or 2 or 4 or 6 or 8 if it is then Not A Prime Number
    /// if doesn't fall between even single last digit then check total of digits is not divisible by half of number
    /// </summary>
    internal class PrimeNumberTest
    {
        public void PrimeTestSmallNum(int num)
        {
            Console.WriteLine("Small" + num);
            PrimeNumberTest.TestPrimeNo(num);
        }
        static void TestPrimeNo(int num)
        {
            // This logic works efficiently when no is smaller
            bool flag = true;
            if (num == 0 || num == 1)
                Console.WriteLine("Enter Number other than 0 and 1");
            else
            {
                int halfnum = num / 2;
                for (int i = 2; i <= halfnum; i++)
                {
                    if (num % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    Console.WriteLine("Prime Number");
                else
                    Console.WriteLine("Not a Prime Number");
            }
        }
        public void PrimeTestLargeNum(int num)
        {
            Console.WriteLine("Large" + num);
            if (num % 2 == 0)
            {
                Console.WriteLine("Not a Prime Number");
                goto xxx;
            }
            else
            {
                int tempno = num;
                int sumofdigits = 0;
                while (tempno > 0)
                {
                    sumofdigits = (tempno % 10) + sumofdigits;
                    tempno = tempno / 10;
                }
                PrimeNumberTest.TestPrimeNo(sumofdigits);
            }
            xxx:;
        }
        public static void Main()
        {
            PrimeNumberTest obj = new PrimeNumberTest();
            Console.WriteLine("Enter Number to Test : ");
            int num = Convert.ToInt32(Console.ReadLine());
            obj.PrimeTestSmallNum(num);
            obj.PrimeTestLargeNum(num);
        }
    }
}
