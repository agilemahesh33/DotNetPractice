using System;
using System.Collections;

public class ProgramGM
{
	public bool AreEqual<T>(T a,T b)
	{
		return a.Equals(b)?true:false;
	}
	public static void Main()
	{
		Program obj = new Program();
		Console.WriteLine(obj.AreEqual<int>(12,23));
		Console.WriteLine(obj.AreEqual<bool>(true,true));
		Console.WriteLine(obj.AreEqual<string>("Mahesh","MAhesh"));
		Console.WriteLine(obj.AreEqual<decimal>(12.23m,23.45m));
		Console.ReadLine();
	}
}
