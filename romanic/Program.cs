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
            int result;
            string inputString;
            Console.WriteLine("Introduzca numero del 1 al 3,999: ");
            inputString = Console.ReadLine();
            Input_Validator(inputString);

        }

        public static int Input_Validator(string inputString)
        {
            int result;

            if (!string.IsNullOrEmpty(inputString))
            {
                try
                {
                    result = Int32.Parse(inputString);
                }
                catch (FormatException e)
                {
                    throw e;
                }
                return result;
            }
            else
            {
                ArgumentNullException e = new ArgumentNullException();
                throw e;
            };
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


