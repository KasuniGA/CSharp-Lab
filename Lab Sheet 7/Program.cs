using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Enter the size of the arrays: ");
                int size = int.Parse(Console.ReadLine());

                int[] array1 = new int[size];
                int[] array2 = new int[size];
                int[] resultArray = new int[size];

                // Input values for array1
                Console.WriteLine("Enter the elements for Array 1:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Element {i + 1}: ");
                    array1[i] = int.Parse(Console.ReadLine());
                }

                // Input values for array2
                Console.WriteLine("Enter the elements for Array 2:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Element {i + 1}: ");
                    array2[i] = int.Parse(Console.ReadLine());
                }

                // Scalar Sum
                int scalarSum = 0;
                for (int i = 0; i < size; i++)
                {
                    scalarSum += array1[i] + array2[i];
                }

                // Vector Sum
                for (int i = 0; i < size; i++)
                {
                    resultArray[i] = array1[i] + array2[i];
                }

                // Vector Product
                int[] vectorProductArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    vectorProductArray[i] = array1[i] * array2[i];
                }

                // Scalar Product
                int scalarProduct = 0;
                for (int i = 0; i < size; i++)
                {
                    scalarProduct += array1[i] * array2[i];
                }

                // Displaying results
                Console.WriteLine("\nScalar Sum: " + scalarSum);

                Console.WriteLine("\nVector Sum:");
                DisplayArray(resultArray);

                Console.WriteLine("\nVector Product:");
                DisplayArray(vectorProductArray);

                Console.WriteLine("\nScalar Product: " + scalarProduct);
            

            // Helper method to display an array
            static void DisplayArray(int[] array)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
}
