using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_03
{
    public static void Main()
    {
        Console.Write("Enter the distance in kilometers (km): ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double kilometers))
        {
            ConvertValues converter = new ConvertValues();
            double meters = converter.KilometerToMeter(kilometers);
            Console.WriteLine($"{kilometers} kilometers is equal to {meters} meters.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
