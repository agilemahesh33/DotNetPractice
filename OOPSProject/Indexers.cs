using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    public class Employee1
    {
        int? _Id;
        string? _Name, _Job;
        double? _Salary;
        bool? _IsActive;
        public Employee1(int id)
        {
            _Id = id;
            _Name = "Mahesh";
            _Job = "Manager";
            _Salary = 50000.00;
            _IsActive = true;
        }
        public object? this[int Index]
        {
            get
            {
                if (Index == 1)
                {
                    return _Id;
                }
                else if (Index == 2)
                {
                    return _Name;
                }
                else if (Index == 3)
                {
                    return _Job;
                }
                else if (Index == 4)
                {
                    return _Salary;
                }
                else if (Index == 5)
                {
                    return _IsActive;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (Index == 2)
                {
                    _Name = (string?)value;
                }
                else if (Index == 3)
                {
                    _Job = (string?)value;
                }
                else if (Index == 4)
                {
                    _Salary = (double?)value;
                }
                else if (Index
                         == 5)
                {
                    _IsActive = (bool?)value;
                }
            }
        }
        public object? this[string Key]
        {
            get
            {
                if (Key.ToUpper() == "ID")
                    return _Id;
                else if (Key.ToUpper() == "NAME")
                    return _Name;
                else if (Key.ToUpper() == "JOB")
                    return _Job;
                else if (Key.ToUpper() == "SALARY")
                    return _Salary;
                else if (Key.ToUpper() == "STATUS")
                    return _IsActive;
                else
                    return null;
            }
            set
            {
                if (Key.ToLower() == "name")
                    _Name = (string?)value;
                else if (Key.ToLower() == "job")
                    _Job = (string?)value;
                else if (Key.ToLower() == "salary")
                    _Salary = (double?)value;
                else if (Key.ToLower() == "status")
                    _IsActive = (bool?)value;
            }
        }
    }
    internal class Indexers
    {
        public static void Main()
        {
            Employee1 emp = new Employee1(1005);
            Console.WriteLine($"Emplyee ID : {emp[1]}");
            Console.WriteLine($"Emplyee Name : {emp[2]}");
            Console.WriteLine($"Emplyee Job : {emp[3]}");
            Console.WriteLine($"Emplyee Salary : {emp[4]}");
            Console.WriteLine($"Emplyee Status : {emp[5]}");

            emp["Id"] = 1003;// Cant assing value bcoze we havent defined setter for ID

            emp[3] = "Sr. Manager";
            emp["Salary"] = 53000.33;
            Console.WriteLine($"____________________________________");
            Console.WriteLine($"Emplyee ID : {emp["Id"]}");
            Console.WriteLine($"Emplyee Name : {emp["name"]}");
            Console.WriteLine($"Emplyee Job : {emp["Job"]}");
            Console.WriteLine($"Emplyee Salary : {emp["SaLaRy"]}");
            Console.WriteLine($"Emplyee Status : {emp["Status"]}");
            Console.ReadLine();
        }
    }
}
