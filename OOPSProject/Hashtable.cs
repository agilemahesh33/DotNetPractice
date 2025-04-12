using System;
using System.Collections;
//Output will change every time i.e. Sequence of adding values doesnot matter
public class Program
{
	public static void Main()
	{
		Hashtable emp = new Hashtable();
		Console.WriteLine("------------------");
		foreach (Object key in emp.Keys)
			Console.WriteLine($"{key} : {emp[key]}");		
		Console.WriteLine("------------------");
		emp.Add("Emp-Id : ", 1001);
		emp.Add("Emp-Name : ", "MAHESH");
		emp.Add("Emp-Job : ", "SOFTWARE ENGINEER");
		emp.Add("Emp-MgrID : ", 1003);
		emp.Add("Emp-Salary : ", 50033);
		emp.Add("Emp-Commission : ", 1001);
		emp.Add("Emp-Status", true);		
		Console.WriteLine("------------------");
		foreach (Object key in emp.Keys)
			Console.WriteLine($"{key} : {emp[key]}");		
		Console.ReadLine();
	}
}
