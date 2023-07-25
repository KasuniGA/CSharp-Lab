using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Question_02.Program;

namespace Question_02
{
    public class Program1
    {
        public static void Main()
        {
            Console.Write("Enter the distance in kilometers (km): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double kilometers))
            {
                ConvertValues converter = new ConvertValues();
                converter.KilometerToMeter(kilometers);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }








}