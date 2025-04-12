using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    public class Customer1
    {
        public int Id {  get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public double? Balance { get; set; }
        public bool? Status { get; set; }

        public override string ToString() =>
            $"Id : {Id}\n Name : {Name}\n City : {City}\n Balance : {Balance}\n Status : {Status}";        
    }
    internal class LINQtoUserDefinedType
    {
        public static void Main()
        {
            //Create Instance of Customer1 Class using Object Initializers
            Customer1 customer1 = new Customer1() { Id = 101, Name = "Scott", City = "Delhi", Balance = 15000.00, Status = true };
            Customer1 customer2 = new Customer1() { Id = 102, Name = "Dave", City = "Mumbai", Balance = 10000.00, Status = true };
            Customer1 customer3 = new Customer1() { Id = 103, Name = "Sunitha", City = "Chennai", Balance = 15600.00, Status = false };
            Customer1 customer4 = new Customer1() { Id = 104, Name = "David", City = "Delhi", Balance = 22000.00, Status = true };
            Customer1 customer5 = new Customer1() { Id = 105, Name = "Mahesh", City = "Kolkata", Balance = 34000.00, Status = true };
            Customer1 customer6 = new Customer1() { Id = 106, Name = "Ramesh", City = "Hyderabad", Balance = 19000.00, Status = true };
            Customer1 customer7 = new Customer1() { Id = 107, Name = "Ganesh", City = "Mumbai", Balance = 16500.00, Status = true };
            Customer1 customer8 = new Customer1() { Id = 108, Name = "Umesh", City = "Bengaluru", Balance = 34600.00, Status = false };
            Customer1 customer9 = new Customer1() { Id = 109, Name = "Haresh", City = "Chennai", Balance = 63000.00, Status = true };
            Customer1 customer10 = new Customer1() { Id = 110, Name = "Shital", City = "Delhi", Balance = 9500.00, Status = true };
            Customer1 customer11 = new Customer1() { Id = 111, Name = "Arun", City = "Hyderabad", Balance = 9800.00, Status = true };
            Customer1 customer12 = new Customer1() { Id = 112, Name = "Suman", City = "Kolkata", Balance = 13200.00, Status = true };
            Customer1 customer13 = new Customer1() { Id = 113, Name = "Arohi", City = "Bengaluru", Balance = 47700.00, Status = true };
            Customer1 customer14 = new Customer1() { Id = 114, Name = "Pankaj", City = "Hyderabad", Balance = 26900.00, Status = false };
            Customer1 customer15 = new Customer1() { Id = 115, Name = "Vivek", City = "Delhi", Balance = 17400.00, Status = true };


            List<Customer1> Custs = new List<Customer1>()
            {
                customer1,
                customer2,
                customer3,
                customer4,
                customer5,
                customer6,
                customer7,
                customer8,
                customer9,
                customer10,
                customer11,
                customer12,
                customer13,
                customer14,
                customer15
            };
            //Implement LINQ Queries for fetching the data from the list using LINQ to Object.
            //Fetching all rows and columns from the list un-conditionally
            var coll1 = from c in Custs select c;
            Console.WriteLine(string.Join("\n", coll1));
            Console.WriteLine("____________________________________________");
            //Fetchin sleected column and giving alias names to column
            //coll = from c in Custs select new (c.Id, c.Name, c.Status );
            var coll2 = from c in Custs
                       select new
                       {
                           CustID = c.Id,
                           CustName = c.Name,
                           IsActive = c.Status
                       };
            Console.WriteLine(string.Join("\n", coll2));
            Console.WriteLine("____________________________________________");
            //Order By Clause
            var coll3 = from c in Custs orderby c.Balance descending select c;
            Console.WriteLine(string.Join("\n", coll3));
            Console.WriteLine("____________________________________________");

            var coll4 = from c in Custs orderby c.Name select c;
            Console.WriteLine(string.Join("\n", coll4));
            Console.WriteLine("____________________________________________");
            //Where Clause

            var coll5 = from c in Custs where c.Balance > 25000 select c;
            Console.WriteLine(string.Join("\n", coll5));
            Console.WriteLine("____________________________________________");

            dynamic colls = from c in Custs where c.City == "Delhi" select c;
            Console.WriteLine(string.Join("\n", colls));
            Console.WriteLine("____________________________________________");

            colls = from c in Custs where c.City == "Hyderabad" && c.Balance < 20000 select c;
            Console.WriteLine(string.Join("\n", colls));
            Console.WriteLine("____________________________________________");

            colls = from c in Custs where c.City == "Chennai" || c.Balance > 30000 select c;
            Console.WriteLine(string.Join("\n", colls));
            Console.WriteLine("____________________________________________");

            //Group by clause
            colls = from c in Custs group c by c.City into G select new { City = G.Key, Customers = G.Count() };
            Console.WriteLine(string.Join("\n", colls));
            Console.WriteLine("____________________________________________");

            colls = from c in Custs group c by c.City into G select new { City = G.Key, MaxBalance = G.Max(c => c.Balance) };
            Console.WriteLine(string.Join("\n", colls));
            Console.WriteLine("____________________________________________");

            colls = from c in Custs group c by c.City into G select new { City = G.Key, MinBalance = G.Min(c => c.Balance) };
            Console.WriteLine(string.Join("\n", colls));
            Console.WriteLine("____________________________________________");

            colls = from c in Custs group c by c.City into G select new { City = G.Key, AvgBalance = G.Average(c => c.Balance) };
            Console.WriteLine(string.Join("\n", colls));
            Console.WriteLine("____________________________________________");

            colls = from c in Custs group c by c.City into G select new { City = G.Key, TotalBalance = G.Sum(c => c.Balance) };
            Console.WriteLine(string.Join("\n", colls));
            Console.WriteLine("____________________________________________");

            //Having(Where) Clause
            colls = from c in Custs group c by c.City into G  where G.Count()>2 
                    select new { City = G.Key, Customers =G.Count()};
            Console.WriteLine(string.Join("\n", colls));
            Console.WriteLine("____________________________________________");

            colls = from c in Custs group c by c.City into G where G.Max(c=>c.Balance)>25000 
                    select new { City = G.Key, MaxBalance = G.Max(c => c.Balance) };
            Console.WriteLine(string.Join("\n", colls));
            Console.WriteLine("____________________________________________");

            colls = from c in Custs group c by c.City into G where G.Min(c=>c.Balance)<10000 
                    select new { City = G.Key, MaxBalance = G.Max(c => c.Balance) };
            Console.WriteLine(string.Join("\n", colls));
            Console.WriteLine("____________________________________________");
        }
    }
}
