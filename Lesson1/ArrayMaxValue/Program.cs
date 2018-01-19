using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 2, 3, 5, 8, 10 };
            Console.WriteLine("Максимальне значення масива: " + GetArrayMaxVal(Array));
        }

        static int GetArrayMaxVal(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    Console.WriteLine("max = " + array[i] );
                }
            }
            return max;
        }
    }
}
