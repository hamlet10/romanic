using System;
using System.Collections.Generic;
using System.Text;

namespace romanic
{

    public class Program
    {
        private static Dictionary<int, string> myDictionary = new Dictionary<int, string>()
{
    {1000, "M" },
    { 900, "CM" },
    {500, "D" },
    { 400, "CD" },
    {100, "C" },
    {50, "L" },
    { 40, "XL" },
    {10, "X" },
    { 9, "IX" },
    {5, "V" },
    { 4, "IV" },
    {1, "I" },

};

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string NumberToArabic(int number)
        {
            var roman = new StringBuilder();
            foreach (var item in myDictionary)
            {
                while (number >= item.Key)
                {
                    roman.Append(item.Value);
                    number -= item.Key;
                }
            }
            return roman.ToString();
        }
    }
}

