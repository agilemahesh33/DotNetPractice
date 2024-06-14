using System;
class TDArray
{
	static void Main()
	{		
		Console.Clear();
		int x=0;
		int[,] arr= new int[4,5];
		Console.WriteLine("---------------------------Original Array ["+arr.GetLength(0)+","+arr.GetLength(1)+"]");		
		foreach(int i in arr)
			Console.Write(i + "-");
		for(int i=0;i<arr.GetLength(0);i++)
		{
			for(int j=0;j<arr.GetLength(1);j++)
			{
				//x+=5;
				arr[i,j]=i+j;
			}
		}		
		Console.WriteLine("---------------------------New Array ["+arr.GetLength(0)+","+arr.GetLength(1)+"]");		
		foreach(int i in arr)
			Console.Write(i + " ");
		Console.WriteLine("---------------------------New Array ["+arr.GetLength(0)+","+arr.GetLength(1)+"]");
		for(int i=0;i<arr.GetLength(0);i++)
		{
			for(int j=0;j<arr.GetLength(1);j++)
			{
				Console.Write(arr[i,j] + " ");		
			}
			Console.WriteLine();
		}
		int[,] brr= {
				{11,12,13,14,15},
				{21,22,23,24,25},
				{31,32,33,34,35,36},
				{41,42,43,44,45},
				{51,52,53,54,55},				
			     };
		Console.WriteLine("---------------------------Another New Array ["+brr.GetLength(0)+","+brr.GetLength(1)+"]");
		for(int i=0;i<brr.GetLength(0);i++)
		{
			for(int j=0;j<brr.GetLength(1);j++)
			{
				Console.Write(brr[i,j] + " ");		
			}
			Console.WriteLine();
		}
	Console.ReadLine();
	}
}	