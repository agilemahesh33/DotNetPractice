<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class ClsMath : IMath1, IMath2
    {        
        public void Add(double x, double y) 
        {
            Console.WriteLine(x+y);
        }
        public void Sub(double x, double y) 
        { 
            Console.WriteLine(x-y); 
        }
        public void Mul(double x, double y)
        {
            Console.WriteLine(x * y);
        }
        public void Div(double x, double y)
        {
            Console.WriteLine(x / y);
        }
        public static void Main()
        {
            ClsMath obj = new ClsMath();
            obj.Add(1, 2);
            obj.Sub(3, 4);
            obj.Mul(5, 6);
            obj.Div(6, 7);            
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class ClsMath : IMath1, IMath2
    {        
        public void Add(double x, double y) 
        {
            Console.WriteLine(x+y);
        }
        public void Sub(double x, double y) 
        { 
            Console.WriteLine(x-y); 
        }
        public void Mul(double x, double y)
        {
            Console.WriteLine(x * y);
        }
        public void Div(double x, double y)
        {
            Console.WriteLine(x / y);
        }
        public static void Main()
        {
            ClsMath obj = new ClsMath();
            obj.Add(1, 2);
            obj.Sub(3, 4);
            obj.Mul(5, 6);
            obj.Div(6, 7);            
        }
    }
}
>>>>>>> fa505855352439e3f5b1b2b418f8a3fc27c5f3c2
