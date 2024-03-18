using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortAlgorithm
{
    public static class BubbleSort<T> where T : IComparable<T>
    {
        public static T[] SortAscending(T[] arr)
        {
            int arrLength = arr.Length;

            for (int i = 0; i < arrLength - 1; i++)
            {
                for (int j = 0; j < arrLength - i - 1; j++)
                {
                    //arr[j] > arr[j + 1]
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }

        public static T[] SortDescending(T[] arr)
        {
            int arrLength = arr.Length;

            for (int i = 0; i < arrLength - 1; i++)
            {
                for (int j = 0; j < arrLength - i - 1; j++)
                {
                    //arr[j] < arr[j + 1]
                    if (arr[j].CompareTo(arr[j + 1]) < 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
