using static System.Console;
class DataTypes
{
	static int x;			//Field (Global Scope)
	static short s;
	static void Main()
	{		
		Clear();
		WriteLine("Static Namespace introduced in C#6.0");
		int y = 10;		//Variable (Local Scope)
		WriteLine($"The Value of x:{x} and Value of y:{y}");
		WriteLine("--------------------------------------------------------");
		WriteLine("Varaible y value is : "+ y + " and its type is : "+ y.GetType() + " its Size is : " + System.Runtime.InteropServices.Marshal.SizeOf(y));

		WriteLine("Varaible s value is : "+ s + ", its type is : "+ s.GetType() + " its Size is : " + System.Runtime.InteropServices.Marshal.SizeOf(s));
		float f=3.14f;
		WriteLine("Varaible f value is : "+ f + ", its type is : "+ f.GetType() + " its Size is : " + System.Runtime.InteropServices.Marshal.SizeOf(f));
		ReadLine();		
	}
}