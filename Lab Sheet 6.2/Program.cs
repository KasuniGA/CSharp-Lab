using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_02
{

    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter the size of the arrays: ");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                int[] array1 = new int[size];
                int[] array2 = new int[size];

                Console.WriteLine("\nEnter values for the first array:");
                for (int i = 0; i < size; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        array1[i] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer value.");
                        i--;
                    }
                }

                Console.WriteLine("\nEnter values for the second array:");
                for (int i = 0; i < size; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        array2[i] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer value.");
                        i--;
                    }
                }

                // Scalar Sum
                int scalarSum = 0;
                for (int i = 0; i < size; i++)
                {
                    scalarSum += array1[i] + array2[i];
                }
                Console.WriteLine("\nScalar Sum: " + scalarSum);

                // Vector Sum
                int[] vectorSumArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    vectorSumArray[i] = array1[i] + array2[i];
                }
                Console.WriteLine("\nVector Sum:");
                DisplayArray(vectorSumArray);

                // Vector Product
                int[] vectorProductArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    vectorProductArray[i] = array1[i] * array2[i];
                }
                Console.WriteLine("\nVector Product:");
                DisplayArray(vectorProductArray);

                // Scalar Product
                int scalarProduct = 0;
                for (int i = 0; i < size; i++)
                {
                    scalarProduct += array1[i] * array2[i];
                }
                Console.WriteLine("\nScalar Product: " + scalarProduct);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer for the array size.");
            }
        }

        private static void DisplayArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

}