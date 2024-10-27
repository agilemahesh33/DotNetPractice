using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    internal class TestCustomer
    {
        Customer cust = new Customer(1001);
        Console.Writeline("Customer Id : "+ cust.cus);
    }
}
