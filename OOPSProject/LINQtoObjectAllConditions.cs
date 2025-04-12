using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class LINQtoObjectAllConditions
    {
        public static void Main()
        {
            string[] colors = { "Red", "Green", "Blue", "Yellow", "Orange", "Purple", "Black", "White", "Gray", "Pink" };

            Console.WriteLine("Get list of all colors:::::::::::");
            var coll1 = from i in colors select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all corlors in ascending order:::::::::::");
            coll1 = from i in colors orderby i select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors in descending order:::::::::::");
            coll1 = from i in colors orderby i descending select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose length is 5 chars:::::::::::");
            coll1 = from i in colors where i.Length > 5 select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name starts with 'B' chars:::::::::::");
            coll1 = from i in colors where i.StartsWith('B') select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name starts with 'B' chars:::::::::::");
            coll1 = from i in colors where i.IndexOf("B") ==0 select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name starts with 'B' chars:::::::::::");
            coll1 = from i in colors where i[0]=='B' select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name starts with 'B' chars:::::::::::");
            coll1 = from i in colors where i.Substring(0,1) == "B" select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name ends with 'e' chars:::::::::::");
            coll1 = from i in colors where i.Substring(i.Length-1) == "e" select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name ends with 'e' chars:::::::::::");
            coll1 = from i in colors where i[i.Length-1]=='e' select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name ends with 'e' chars:::::::::::");
            coll1 = from i in colors where i.IndexOf("e") == i.Length-1 select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name ends with 'e' chars:::::::::::");
            coll1 = from i in colors where i.EndsWith("e") select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name contains 'a' chars at 3rd place:::::::::::");
            coll1 = from i in colors where i[2] == 'a' select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name contains 'a' chars at 3rd place:::::::::::");
            coll1 = from i in colors where i.IndexOf("a") == 2 select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name contains 'a' chars at 3rd place:::::::::::");
            coll1 = from i in colors where i.Substring(2,1)== "a" select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name contains 'O'or'o' chars:::::::::::");
            coll1 = from i in colors where i.Contains('O') || i.Contains('o') select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name contains 'O'or'o' chars:::::::::::");
            coll1 = from i in colors where i.IndexOf('O') >= 0 || i.IndexOf('o') >= 0 select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name contains 'O'or'o' chars:::::::::::");
            coll1 = from i in colors where i.ToUpper().Contains('O') select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name contains 'O'or'o' chars:::::::::::");
            coll1 = from i in colors where i.ToLower().Contains('o') select i;
            Console.WriteLine(string.Join(", ", coll1));

            /////
            ///
            Console.WriteLine("Get the list of all colors whose name Does not contains 'O'or'o' chars:::::::::::");
            coll1 = from i in colors where i.Contains('O')==false && i.Contains('o')==false select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name Does not contains 'O'or'o' chars:::::::::::");
            coll1 = from i in colors where i.IndexOf('O') ==-1 || i.IndexOf('o') ==-1 select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name Does not contains 'O'or'o' chars:::::::::::");
            coll1 = from i in colors where i.ToUpper().Contains('O') ==false select i;
            Console.WriteLine(string.Join(", ", coll1));

            Console.WriteLine("Get the list of all colors whose name Does not contains 'O'or'o' chars:::::::::::");
            coll1 = from i in colors where i.ToLower().Contains('o') == false select i;
            Console.WriteLine(string.Join(", ", coll1));

        }
    }
}
