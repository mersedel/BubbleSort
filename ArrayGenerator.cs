using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal static class ArrayGenerator
    {
        internal static int[] GenerateArray(int length, int minNum, int maxNum) 
        {
            Random rnd = new Random();

            int[] array = new int[length];

            foreach (int num in array)
            {
                array[num] = rnd.Next(minNum, maxNum);
            }

            return array;
        }
    }
}
