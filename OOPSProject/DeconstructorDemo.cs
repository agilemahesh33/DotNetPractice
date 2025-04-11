using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    public class Teacher
    {
        int? _Id;
        string? _Name, _Subject, _Designation;
        double? _Salary;

        public Teacher(int? id, string? name, string? subject, string? designation, double? salary)
        {
            _Id = id;
            _Name = name;
            _Subject = subject;
            _Designation = designation;
            _Salary = salary;
        }
        public void Deconstruct(out int? id,out string? name,out string? subject,out string? designation,out double? salary)
        {
            id = this._Id;
            name = this._Name;
            subject = this._Subject;
            designation = this._Designation;
            salary = this._Salary;
        }
    }
    internal class DeconstructorDemo
    {
        public static void Main()
        {
            Teacher obj = new Teacher(1005, "Mahesh", "Dot Net", "Lecturer", 330000.98);
            (int? id1, string? name1, string? subject1, string? designation1, double? salary1) = obj;
            Console.WriteLine("ID : "+ id1);
            Console.WriteLine("Name : " + name1);
            Console.WriteLine("Subject : " + subject1);
            Console.WriteLine("Designation : " + designation1);
            Console.WriteLine("Salary : " + salary1);
            Console.ReadLine();
        }
    }
}
