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

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minNum, maxNum);
            }

            return array;
        }
    }
}
