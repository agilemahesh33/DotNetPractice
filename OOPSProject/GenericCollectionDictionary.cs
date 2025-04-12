using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class GenericCollectionDictionary
    {
        public static void Main()
        {
            Dictionary<string, object?> Emp = new Dictionary<string, object?>();
            Emp.Add("Emp-Id : ", 1001);
            Emp.Add("Emp-Name : ", "MAHESH");
            Emp.Add("Emp-Job : ", "SOFTWARE ENGINEER");
            Emp.Add("Emp-MgrID : ", 1003);
            Emp.Add("Emp-Salary : ", 50033);
            Emp.Add("Emp-Commission : ", 1001);
            Emp.Add("Emp-Status", true);
            
            Console.WriteLine("------------------");
            foreach (string key in Emp.Keys)
                Console.WriteLine($"{key} : {Emp[key]}");
            Console.ReadLine();
        }
    }
}
