using System;
class VarDynamic
{
	static void Main()
	{
		var i=100;
		Console.WriteLine("i=100 : " + i.GetType());
		var c='a';
		Console.WriteLine("c='a' : " + c.GetType());
		var f=45.65f;
		Console.WriteLine("f=45.65f : " + f.GetType());
		var b=true;
		Console.WriteLine("b=true : " + i.GetType());		
		string str1=null;
		string str2=null;
		Console.WriteLine(str1??str2);		
		str2="India";
		Console.WriteLine(str1??str2);		
		str1="Bharat";
		Console.WriteLine(str1??str2);	
		string str3="India";
		Console.WriteLine(str3);
		object obj = str3;
		Console.WriteLine(obj as string);		
		Console.WriteLine(i==100?"Hello 100":"Hello nothing");		
		if(str3 is string)
					Console.WriteLine("str3 is "+str3.GetType());
		Console.ReadLine();	
	}
}