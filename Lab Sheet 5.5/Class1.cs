using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_02
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] array = new int[10];
            Console.WriteLine("Enter 10 integer values:");

            for (int i = 0; i < array.Length; i++)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                    array[i] = value;
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer value.");
                    i--;
                }
            }

            ArrayOperations arrayOps = new ArrayOperations();

            int minimumValue = arrayOps.FindMinimum(array);
            int maximumValue = arrayOps.FindMaximum(array);
            double averageValue = arrayOps.FindAverage(array);
            int[] reversedArray = arrayOps.ReverseArray(array);

            Console.WriteLine($"Minimum value: {minimumValue}");
            Console.WriteLine($"Maximum value: {maximumValue}");
            Console.WriteLine($"Average value: {averageValue:F2}");

            Console.WriteLine("Array in reverse order:");
            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.Write($"{reversedArray[i]} ");
            }
        }
    }

}