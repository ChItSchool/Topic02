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
            int[] array = HelpFunc.GetRandomArray(5);
            HelpFunc.PrintArray(array);
            Console.WriteLine();
            Console.WriteLine(GetMinPos(array));
            Console.ReadKey();
        }

        /// <summary>
        /// Видає позицію мінімального значення
        /// </summary>
        /// <returns></returns>
        static int GetMinPos(int [] array)
        {

            int pos = 0;

            for (int i = 0; i < array.Length; i++)
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
