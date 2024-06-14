namespace OOPSProject
{
    /// <summary>
    /// This example demonstrates the different ways to the parameters and 
    /// get multiple returning values from method 
    /// default paramter type is input and other two are out and ref (see example InOutParameters)
    /// </summary>
    internal class MethodParameters
    {
        //return multiple values from method using out keyword
        public void Math1(int a , int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
        }
        //return multiple values from the method using return keyword
        public (int, int ) Math2(int a, int b)
        {
            int c = a + b;
            int d = a - b;
            return (c, d);
        }
        public static void Main()
        {
            MethodParameters MP = new MethodParameters();
            int sum = 0;
            int diff = 0;
            int one = 30;
            int two = 20;

            //Style 1 of calling w/o return 
            MP.Math1(one, two, out sum, out diff);
            Console.WriteLine("Addition of " +one + "+" + two +"=" + sum);
            Console.WriteLine("Substraction of " + one + "-" + two + "=" + diff);

            //Style 2 of calling w/o return
            MP.Math1(one,two,out int s,out int d);
            Console.WriteLine("Addition of " + one + "+" + two + "=" + s);
            Console.WriteLine("Substraction of " + one + "-" + two + "=" + d);
            
            //Style 3 of calling with return
            (int ss, int dd) = MP.Math2(one, two);
            Console.WriteLine("Addition of " + one + "+" + two + "=" + ss);
            Console.WriteLine("Substraction of " + one + "-" + two + "=" + dd);
            
            //Style 4 of calling with return
            var(sss,ddd) = MP.Math2(one,two);
            Console.WriteLine("Addition of " + one + "+" + two + "=" + ss);
            Console.WriteLine("Substraction of " + one + "-" + two + "=" + dd);
            Console.ReadLine();
        }
    }
}
