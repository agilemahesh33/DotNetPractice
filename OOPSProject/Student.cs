using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSProject
{
    /// <summary>
    /// Object initializers C#3.0
    /// Used to assign value to any accessible properties of an instance at creation time without having to
    /// explicitly invoke a parameterized constructor.
    /// </summary>    
    public class TestStudent
    {
        int? _id, _class;
        string? _name;
        float? _marks, _fees;
        public int? id { get { return _id; } set { _id = value; } }
        public int? Class { get { return _class; } set { _class = value; } }
        public string? name { get { return _name; } set { _name = value; } }
        public float? Marks { get { return _marks; } set { _marks = value; } }
        public float? Fees { get { return _fees; } set { _fees = value; } }
        public override string ToString()
        {
            return $"ID : {_id} \nName : {_name} \n Class : {_class} \n Marks : {_marks} \n Fees : {_fees}";
        }
    }
    internal class Student
    {
        static void Main()
        {
            TestStudent s1 = new TestStudent { id = 101, name = "Mahesh", Class = 10 };
            TestStudent s2 = new TestStudent { id = 101, Class = 10, Marks = 560.2f };
            TestStudent s3 = new TestStudent { id = 101, name = "Ramesh", Class = 10 };
            TestStudent s4 = new TestStudent { id = 101, name = "Haresh", Class = 10 };
            TestStudent s5 = new TestStudent { id = 101, name = "Ganesh", Class = 10 };
            TestStudent s6 = new TestStudent{id = 101, Class = 10};
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.ReadLine();
        }
    }
}
