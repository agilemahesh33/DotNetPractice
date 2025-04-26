using System;
class JumpStatement
{
	static int GetSum(int a, int b)
	{
		return a+b;
	}	
	static void Main()
	{ 
		int i=1000;
		Console.WriteLine("----------------goto lable-----------------------");
		goto abc;
		for(i=0;i<10;i++)
			Console.WriteLine(i);
		abc:
		Console.WriteLine(i);
		Console.WriteLine("----------------break-----------------------");
		for(i=0;i<10;i++)
		{
			Console.WriteLine(i);
			if(i==5)
				break;
		}
		Console.WriteLine("Value of i after break : " + i);
		Console.WriteLine("----------------continue-----------------------");
		for(i=i+1;i<10;i++)
		{
			Console.WriteLine(i);
			if(i==5||i==7)
				continue;
		}
		Console.WriteLine("----------------return value-----------------------");
		Console.WriteLine("Sum of two numbers : " + GetSum(10,20));		

		Console.WriteLine("----------------tryParse-----------------------");
		Console.WriteLine("Enter un-signed integer value : ");
		bool status=uint.TryParse(Console.ReadLine(),out uint x);
		if(status==true)
			Console.WriteLine("Please enter un-signed integer value Only : ");
		if(x==0||x==1)
			Console.WriteLine("Please enter number greater than 1 : ");
		Console.WriteLine("status : " + status + " x : " + x);

		Console.ReadLine();	
	}	
}