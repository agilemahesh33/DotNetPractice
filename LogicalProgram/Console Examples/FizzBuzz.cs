/*
Write a program that prints the numbers from 1 to 100. 
For multiplication of 3 print "Fizz" instead of number and 
For multiplication of 5 print "Buzz" instead of number and 
For multiplication of 3 and 5 print "FizzBuzz" instead of number else print number
*/

using System;
class FizzBuzz
{
	FizzBuzz(int n)
	{
		for(int i=1;i<=n;i++)
		{
			if((i%3==0) &(i%5==0))
			{
				Console.WriteLine(i+" FizzBuzz");
			}
			else if(i%3==0)
			{
				Console.WriteLine(i+" Fizz");
			}
			else if(i%5==0)
			{
				Console.WriteLine(i+" Buzz");
			}
			else
			{
				Console.WriteLine(i);				
			}
		}
	}
	public static void Main()
	{
		FizzBuzz obj = new FizzBuzz(100);	
	}
}