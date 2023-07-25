using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{
    public class ArrayProcessor
    {
        public int[] CreateArrayWithZeroPadding(int size)
        {
            int[] array = new int[size * 2]; // Double the size to accommodate zero padding.
            return array;
        }
    }

}