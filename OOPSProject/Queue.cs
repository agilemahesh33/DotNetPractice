using System;
using System.Collections;

public class ProgramQ
{
	public static void Main()
	{
		Queue q = new Queue();
		q.Enqueue('A');
		q.Enqueue(100);
		q.Enqueue(false);
		q.Enqueue("Mahesh");
		q.Enqueue(34.56m);
		Console.WriteLine(" Count : " + q.Count);
		foreach(object obj in q)
			Console.WriteLine(obj);
		
			Console.WriteLine("--------------------" + q.Dequeue() + " Count : " + q.Count);
		
		foreach(object obj in q)
			Console.WriteLine(obj);
		
		Console.WriteLine("--------------------" + q.Peek() + " Count : " + q.Count);
		foreach(object obj in q)
			Console.WriteLine(obj);
		Console.WriteLine("--------------------" + q.Count);
	}
}
