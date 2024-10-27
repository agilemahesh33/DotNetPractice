using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{   
    internal class NumberToWord
    {
        private static string Number_To_Word(int num)
        {
            if (num == 0)
                return "Zero";
            if (num < 0)
                return "Not Supported";
            var words = "";
            string[] strOnes = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirtee", "Forteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] strTens = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
            int crore = 0, lakhs = 0, thousands = 0, hundreds = 0, tens = 0, singles = 0;
            crore = num / 10000000; num = num - crore * 10000000;
            lakhs = num / 100000; num = num - lakhs * 100000;
            thousands = num / 1000; num = num - thousands * 1000;
            hundreds = num / 100; num = num - hundreds * 100;
            if (num > 19)
            {
                tens = num / 10;
                num = num - tens * 10;
            }
            singles = num;
            if (crore > 0)
            {
                if (crore > 19)
                    words += Number_To_Word(crore) + "Crores ";
                else
                    words += strOnes[crore - 1] + " Crore";
            }
            if (lakhs > 0)
            {
                if (lakhs > 19)
                    words += Number_To_Word(lakhs) + "Lakhs ";
                else
                    words += strOnes[lakhs - 1] + " Lakh ";
            }
            if (thousands > 0)
            {
                if (thousands > 19)
                    words += Number_To_Word(thousands) + "Thousands ";
                else
                    words += strOnes[thousands - 1] + " Thousand ";
            }
            if (hundreds > 0)
                words += strOnes[hundreds - 1] + " Hundred ";
            if (tens > 0)
                words += strOnes[tens - 1] + " ";
            if (singles > 0)
                words += strOnes[singles - 1] + " ";
            return words;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number to Say in Word : ");
            Console.WriteLine( Number_To_Word(int.Parse(Console.ReadLine())));
        }
    }
}
