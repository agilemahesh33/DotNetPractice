using System;
using System.Collections;

public class Program
{
	public static void Main()
	{
		ArrayList al = new ArrayList();
		Console.WriteLine("Initial Capacity : " + al.Capacity);
		al.Add('A');
		Console.WriteLine("Capacity After 1st Element : " + al.Capacity);
		
		al.Add(false);
		al.Add("Mahesh");
		al.Add(120.34f);
		al.Add(false);
		Console.WriteLine("Capacity After 5th Element : " + al.Capacity);
		Console.WriteLine("------------------");
		for (int i=0; i<al.Count;i ++)
			Console.WriteLine(al[i]);
		al.Add(true);
		Console.WriteLine("Capacity After 6th Element : " + al.Capacity);
		Console.WriteLine("------------------");
		for (int i=0; i<al.Count;i ++)
			Console.WriteLine(al[i]);
		al.Remove(false);
		Console.WriteLine("Capacity After removing false Element : " + al.Capacity);
		Console.WriteLine("------------------");
		foreach (Object obj in al)
			Console.WriteLine(obj);
		al.TrimToSize();
		Console.WriteLine("Capacity After TrimToSize() : " + al.Capacity);
		Console.WriteLine("------------------");
	}
}
