using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
    {
        public class ConvertValues
        {
            public void KilometerToMeter()
            {
                Console.Write("Enter the distance in kilometers (km): ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double kilometers))
                {
                    double meters = kilometers * 1000;
                    Console.WriteLine($"{kilometers} kilometers is equal to {meters} meters.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
