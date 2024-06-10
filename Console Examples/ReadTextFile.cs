using System;
using System.Text.RegularExpressions;
class ReadTextFile
{
	void PrintAndCountWord(string Sourcestr, string tofind)
	{
		int count=0;
		Console.WriteLine(tofind + " : " + Sourcestr);
		foreach(var str in Sourcestr)
		{
			if(str.ToString()==tofind.ToLower())
				count++;
		}
		Console.WriteLine(tofind + " : " + Sourcestr);
	}
	public static void Main()
	{
		ReadTextFile obj = new ReadTextFile();
		string text = System.IO.File.ReadAllText(@"D:\Dot Net Core NIT\CSharp Practice\ReadFile.txt");
		string textToLower = text.ToLower();

		Console.WriteLine(textToLower);
		Regex reg_exp = new Regex("[^a-z0-9]"); // Regular expressions to replace non-letter and non-number 												//characters with spaces. It uses the pattern [^a-z0-9].
							//The a-z0-9 part means any lowercase letter or a digit.
            	textToLower = reg_exp.Replace(textToLower, " ");

		Console.WriteLine(textToLower);

		string[] Value = textToLower.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries); 
		Console.WriteLine(textToLower);
		Console.WriteLine("Count : " + Value.GetLength(0));
		obj.PrintAndCountWord(text.ToLower(),"of");

		foreach(string str in Value)	
		{
			//Console.WriteLine(str);
			
		}

	}
}