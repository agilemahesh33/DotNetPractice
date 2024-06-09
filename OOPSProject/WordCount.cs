using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class WordCount
    {
        public static void Main()
        {
            string Tags = "the cat the mat the sat my name is Arjun what is your name";
            Console.WriteLine(Tags);
            string[] words = Tags.Split(' ');
                        
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
