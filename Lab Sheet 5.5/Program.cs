using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_02
{
    using System;

    public class ArrayOperations
    {
        public int FindMinimum(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        public int FindMaximum(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        public double FindAverage(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }

        public int[] ReverseArray(int[] arr)
        {
            int[] reversedArray = new int[arr.Length];
            int j = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                reversedArray[j] = arr[i];
                j++;
            }

            return reversedArray;
        }
    }

}