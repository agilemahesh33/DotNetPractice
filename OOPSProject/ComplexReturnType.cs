namespace OOPSProject
{
    /// <summary>
    /// This example demonstrate the user defined datatype i.e Complex type
    /// </summary>
    class Employee
    {
        public int? empid;
        public string? empName;
        public int? age;
        public double? salary;
    }
    internal class ComplexReturnType
    {
        public Employee GetEmployee(int empID)
        {
            Employee emp = new Employee();
            emp.empid = 101;
            emp.empName = "Mahesh";
            emp.age = 33;
            emp.salary = 70033;
            return emp;
        }
        static void Main()
        {
            ComplexReturnType CR = new ComplexReturnType();
            Employee emp = CR.GetEmployee(101);
            Console.WriteLine("Employee ID : " + emp.empid + " Name: " + emp.empName + " Age : " + emp.age + " Salary : " + emp.salary);
            Console.ReadLine();
        }
    }
}
