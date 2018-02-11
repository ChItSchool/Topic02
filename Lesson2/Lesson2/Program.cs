using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = HelpFunc.GetRandomArray(50);
            HelpFunc.PrintArray(array);
            Console.WriteLine();
            HelpFunc.PrintArray(SelectionSort(array));
            Console.ReadKey();
        }

        static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int MinPos = GetMinPos(array, i, array.Length - 1);
                int a = array[i];
                array[i] = array[MinPos];
                array[MinPos] = a;
            }
            return array;
        }

        /// <summary>
        /// Видає позицію мінімального значення
        /// </summary>
        /// <returns></returns>
        static int GetMinPos(int [] array, int minPos, int maxPos)
        {
            int pos = minPos;

            for (int i = minPos; i <= maxPos; i++)
            {
                if (array[i] < array[pos])
                {
                    pos = i;
                }
            }
            return pos;
        }
    }
}
