using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{
    public class MainClass
    {
        public static void Main()
        {
            Console.Write("Enter the size of the array: ");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                ArrayProcessor arrayProcessor = new ArrayProcessor();
                int[] array = arrayProcessor.CreateArrayWithZeroPadding(size);

                Console.WriteLine("Enter values for the array:");
                for (int i = 0; i < size; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        array[i] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer value.");
                        i--;
                    }
                }

                Console.WriteLine("\nValues inside the array:");
                foreach (int element in array)
                {
                    Console.Write($"{element} ");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer for the array size.");
            }
        }
    }

}