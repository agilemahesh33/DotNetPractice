using System;
class FactorialInOutRef
{
	public void Factorial(ref uint no)
	{
		if(no==0||no==1)
			no=1;
		else
		{
			uint result=1;
			for(uint i=no; i>=2;i--)
				result=result * i;
			no=result;			
		}
	}
	static void Main()
	{
		uint no = 3;
		FactorialInOutRef ObjFact = new FactorialInOutRef();
		Console.WriteLine("Before Calling Method : " + no);
		ObjFact.Factorial(ref no);
		Console.WriteLine("After Calling Method : " + no);
		Console.ReadLine();
	}
}