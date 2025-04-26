using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class GenericCollectionList
    {
        public static void Main()
        {
            List<int> Coll = new List<int>();
            Coll.Add(10);
            Coll.Add(20);
            Coll.Add(30);
            Coll.Add(40);
            Coll.Add(50);
            for (int i = 0; i < Coll.Count; i++)
            {
                Console.WriteLine(Coll[i]);
            }
            Console.WriteLine("________________________");
            Coll.Insert(3, 33);
            foreach (int i in Coll)
            {
                Console.WriteLine(i);
            }            
            Console.WriteLine("________________________");
            Coll.Remove(40);
            foreach (int i in Coll)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("***************************************");
            List<int> L = new List<int>() { 10, 20, 30, 40, 50 };
            List<string> L2 = new List<string>() { "Red", "Blue", "Green", "White", "Yellow" };
            List<int> S = new List<int>() 
            { 83, 47, 92, 56, 68, 11, 75, 24, 39, 88, 61, 96, 13, 59, 44, 71, 28, 99, 62, 86, 33, 58, 21, 95, 77};
            List<int> T = new List<int>();
            Console.WriteLine("Integer List : ");
            foreach (int i in L)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("String List : ");
            foreach (string str in L2)
            {
                Console.WriteLine(str);
            }
            foreach (int i in S)
            {
                if(i > 40) 
                    T.Add(i);
            }
            Console.WriteLine("Source : ");
            foreach (int i in S)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Target >40 : ");
            foreach (int i in T)
            {
                Console.WriteLine(i);
            }
            T.Sort();
            T.Reverse();
            Console.WriteLine(String.Join(", ", T));
        }
    }
}
