using System;
class SDArray2
{
	static void Main()
	{
		

		Console.Clear();

		int[] arr={12,23,45,56,78,89,14,47,25,58,36,69,98,87,65,54,32,21,33};
		Console.WriteLine("---------------------------Original Array "+arr.Length);		
		foreach(int i in arr)
		{
			Console.WriteLine(i);
		}		
		Console.WriteLine("---------------------------Sort(Array arr)");		
		Array.Sort(arr);
		foreach(int i in arr)
		{
			Console.WriteLine(i);
		}		
		Console.WriteLine("---------------------------Reverse(Array arr)");		
		Array.Reverse(arr);
		Array.Reverse(arr);
		foreach(int i in arr)
		{
			Console.WriteLine(i);
		}		
		Console.WriteLine("---------------------------Copy(Array sarr, Array darr, int n)");		
		int[] destArr= new int[10];
		Array.Copy(arr,destArr,7);
		foreach(int i in destArr)
		{
			Console.WriteLine(i);
		}		
		Console.ReadLine();
	}
}