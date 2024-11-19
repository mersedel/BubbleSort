using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal static class ArrayWriter
    {
        internal static void WriteArray<T>(T[] array)
        {
            WriteArray(array, ' ', false);
        }


        internal static void WriteArray<T>(T[] array, char separator, bool spaceAfterSeparator)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);


                if (i < array.Length - 1)
                {
                    if (spaceAfterSeparator) Console.Write(separator + ' ');

                    if (!spaceAfterSeparator) Console.Write(separator);
                }
            }
        }
    }
}
