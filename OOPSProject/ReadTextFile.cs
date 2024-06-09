using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOPSProject
{    
    /// <summary>
    /// Read txt file and count Distinct Words with their occurance 
    /// </summary>
    internal class ReadTextFile
    {
        public static void Main()
        {
            ReadTextFile obj = new ReadTextFile();            
            string strSrc = System.IO.File.ReadAllText(@"D:\Dot Net Core NIT\CSharp Practice\ReadFile.txt"); //"the cat the mat the sat my name is Arjun what is your name";
            Console.WriteLine("Original : -------------------------------------------------" + strSrc);
            Regex reg_exp = new Regex("[^a-z0-9]");
            strSrc = reg_exp.Replace(strSrc.ToLower(), " ");
            Console.WriteLine("Replaced Lowercase : -------------------------------------------------" + strSrc);
            string[] words = strSrc.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> oddw = new Dictionary<string, int>();
            foreach (string item in words)
            {
                if (item != "")
                {
                    if (oddw.ContainsKey(item) == false)
                    {
                        oddw.Add(item, 1);
                    }
                    else
                    {
                        oddw[item]++;
                    }
                }
            }
            foreach (var item in oddw)
            {
                Console.WriteLine(item);
            }
        }
    }
}
