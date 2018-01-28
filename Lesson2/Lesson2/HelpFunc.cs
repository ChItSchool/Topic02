using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    /// <summary>
    /// Надає деякі додаткові функції для роботи з масивом
    /// </summary>
    public static class HelpFunc
    {
        /// <summary>
        /// Виводить в консоль всі значення змінних масива цілих чисел
        /// </summary>
        /// <param name="array"> Масив для виведення на екран </param>
        /// <param name="arrayName"></param>
        public static void PrintArray( int [] array, string arrayName = "" )
        {
            Console.WriteLine("Масив " + arrayName + ": ");

            for (int i = 0; i < array.Length; i++)
            {
                if ( i % 50 == 0 )
                    Console.WriteLine();

                Console.Write(array[i]);

                if ( i+1  < array.Length)
                    Console.Write(", ");
                else
                    Console.Write(".");
            }
        }

        /// <summary>
        /// Повертає новий масив, з рандомними значеннями
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int[] GetRandomArray(int length)
        {
            var array = new int[length];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next();

            return array;
        }

    }
}
