using System;
using System.Collections;

public class Program
{
	public static void Main()
	{
		Stack s = new Stack();
		s.Push('A');
		s.Push(100);
		s.Push(false);
		s.Push("Mahesh");
		s.Push(34.56m);
		Console.WriteLine(" Count : " + s.Count);
		foreach(object obj in s)
			Console.WriteLine(obj);
		
			Console.WriteLine("--------------------" + s.Pop() + " Count : " + s.Count);
		
		foreach(object obj in s)
			Console.WriteLine(obj);
		
		Console.WriteLine("--------------------" + s.Peek() + " Count : " + s.Count);
		foreach(object obj in s)
			Console.WriteLine(obj);
		Console.WriteLine("--------------------" + s.Count);
	}
}
