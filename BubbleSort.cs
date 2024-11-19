using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        isSorted = false;
                    }
                }
            }
        }
    }
}
