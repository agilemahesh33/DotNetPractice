using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class TestCustomer
    {
        static void Main()
        {
            Customer obj = new Customer(10001);
            Console.WriteLine($"Cust ID : {obj.CustId}");

            //obj.CustId = 1; // Invalid Because it is ReadOnly
            if (obj.Status)
                Console.WriteLine("Customer Status is Active ");
            else
                Console.WriteLine("Customer Status is InActive ");
            Console.WriteLine($"Customer Name : {obj.Name}");
            obj.Name = "Smith"; //Unable to Update Because Status is InActive
            Console.WriteLine($"Customer Name : {obj.Name}");
            Console.WriteLine($"Balance When Status is In-Active : {obj.Balance}");

            obj.Status = true;
            Console.WriteLine($"Customer Name : {obj.Name}");
            obj.Name = "Smith"; //Update Because Status is InActive
            Console.WriteLine($"Customer Name : {obj.Name}");
            Console.WriteLine($"Balance When Status is Active : {obj.Balance}");

            obj.Balance -= 4600;
            Console.WriteLine($"Balance When Transaction Failed : {obj.Balance}");
            obj.Balance -= 4600;
            Console.WriteLine($"Balance When Transaction Success : {obj.Balance}");

            Console.WriteLine($"Customer City : {obj.city}");
            obj.city = Cities.Pune;
            Console.WriteLine($"Customer City : {obj.city}");

            Console.WriteLine($"Customer Sate : {obj.state}");
            //obj.state = "Tamilandu"; //Invalid because set it only accessible to child class
            Console.WriteLine("Customer Country : " + obj.Country);
            Console.WriteLine("Customer Continent : " + obj.Continent);

        }
    }
}
