using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Services
{
    public class TextService
    {

        public TextService()
        {
                
        }

        /// <summary>
        /// Повертає попереднє значення текстового поля
        /// </summary>
        public string Back()
        {
            return "";
        }

        /// <summary>
        /// Шукає індекс в text з якого починається входження якогось s в цей текст
        /// </summary>
        /// <param name="text">Текст в якому відбувається пошук</param>
        /// <param name="s"> стрічка яку шукають</param>
        /// <returns> 
        /// Якщо такого s немає в text повертається -1 
        /// іначе повертається індекст з якого починається входження s
        /// </returns>
        /// <example>
        /// Search("123","2") => 1
        /// Search("123","1") => 0
        /// Search("123","3") => 2
        /// Search("123","23") => 1
        /// Search("123","5") => -1
        /// Search("121","1") => 0
        /// </example>
        public int Search(string text, string s)
        {
            
            return 0;
        }
    }
}
