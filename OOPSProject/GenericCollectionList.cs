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
        }
    }
}
