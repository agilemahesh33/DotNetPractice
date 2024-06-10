using System;
class ConditionalLooping
{
	static void Main()
	{	
		Console.Clear();
		int? i=null;	
		Console.WriteLine("----------------For Loop-----------------------");
		for(i=0;i<10;i++)
			Console.WriteLine(i);
		Console.WriteLine("----------------While Loop-----------------------" + i);		
		while(i>=1)
		{
			Console.WriteLine(i);
			i--;
		}
		Console.WriteLine("----------------do While-----------------------" + i);		
		do
		{
			Console.WriteLine(i);
			i++;
		}while(i<=10);
		
		Console.WriteLine("----------------foreach-----------------------" + i);		
		int[] arr = {1,2,3,4,5,6};
		foreach(int j in arr)
		{
			Console.WriteLine(j);		
		}
		string[] arr1 = {"asdf","dgssdfg","werwer","tyutyt"};
		foreach(string j in arr1)
		{
			Console.WriteLine(j);		
		}

		Console.ReadLine();	

	}
}