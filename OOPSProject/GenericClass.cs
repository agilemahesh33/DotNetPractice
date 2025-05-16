using System;
using System.Collections;

public class GenericClass<T>
{
	public T Add(T a, T b)
	{
		dynamic d1 = a;
		dynamic d2 = b;
		return d1 + d2;
	}
	public T Sub(T a, T b)
	{
		dynamic d1 = a;
		dynamic d2 = b;
		return d1 - d2;
	}
	public T Mul(T a, T b)
	{
		dynamic d1 = a;
		dynamic d2 = b;
		return d1 * d2;
	}
	public T div(T a, T b)
	{
		dynamic d1 = a;
		dynamic d2 = b;
		return d1 / d2;
	}		
}
public class ProgramGC
{
	public bool AreEqual<T>(T a,T b)
	{
		return a.Equals(b)?true:false;
	}
	public static void Main()
	{
		GenericClass<int> obj1 = new GenericClass<int>();
		Console.WriteLine(obj1.Add(12,23));
		Console.WriteLine(obj1.Sub(123,23));
		Console.WriteLine(obj1.Mul(12,23));
		Console.WriteLine(obj1.div(123,23));
		
		Console.WriteLine("_____________________");
		
		GenericClass<double> obj2 = new GenericClass<double>();
		Console.WriteLine(obj2.Add(12.23,23.34));
		Console.WriteLine(obj2.Sub(123.45,23.56));
		Console.WriteLine(obj2.Mul(12.45,23.67));
		Console.WriteLine(obj2.div(123.33,23.33));
		Console.ReadLine();
	}
}
