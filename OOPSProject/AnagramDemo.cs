namespace OOPSProject
{
    internal class AnagramDemo
    {
        /// <summary>
        /// WAP to check the String is anagram or not
        /// Ex : Kiran and iKnra are Anagram string
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String : ");
            string strSrc1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter String to Check anagram or not : ");
            string strSrc2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(strSrc1 + " " + strSrc2);
            bool b = false;
            if (strSrc1.Length != strSrc2.Length)
            {
                b = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not Anagram");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                foreach(var str in strSrc1)
                {
                    if(strSrc2.Contains(str))
                    {
                        b = true;
                        continue;
                    }
                    else 
                    {
                        b = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not Anagram");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
                if (b)
                { 
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("Anagram");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
