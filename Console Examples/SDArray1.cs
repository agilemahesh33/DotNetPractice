using System;
class First
{
	static void Main()
	{
		Console.Clear();
		int x=0;
		int[] arr = new int[6];
		Console.WriteLine("Accessing Value of a SD Array using for loop");
		for(int i=0;i<arr.Length;i++)
		{
			Console.WriteLine(i);
		}
		Console.WriteLine("Assigning values to SD Array using for loop");
		for(int i=0;i<arr.Length;i++)
		{
			x+=10;	
			arr[i]=x;
			Console.WriteLine(arr[i]);
		}
		Console.WriteLine("Accessing Value of a SD Array using foreach loop");
		foreach(int i in arr)
		{
			Console.WriteLine(i);
		}
		Console.WriteLine("Accessing Value of different types of SD Array using for & foreach loop");
		int[] arr1={10,20,30,40,50,60,70};
		double[] darr={12.34,56.78,89.10,23.45,67.89};
		string[] sarr={"Red","Blue","Green","Yellow","Magenta"};
		Console.WriteLine("int array");
		for(int i=0;i<arr1.Length;i++)
			Console.WriteLine(arr1[i]);
		Console.WriteLine("double array");
		for(int i=0;i<darr.Length;i++)
			Console.WriteLine(darr[i]);
		Console.WriteLine("string array");
		for(int i=0;i<sarr.Length;i++)
			Console.WriteLine(sarr[i]);

		Console.WriteLine("int array");
		foreach(int i in arr1)
			Console.WriteLine(i);
		Console.WriteLine("double array");
		foreach(double i in darr)
			Console.WriteLine(i);
		Console.WriteLine("string array");
		foreach(string i in sarr)
			Console.WriteLine(i);
		Console.WriteLine("-------------------------------------------------------------------");		

		Console.ReadLine();
	}
}