using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Services
{
    public class FileService
    {
        public FileService()
        {

        }

        /// <summary>
        /// Відкриває файл за вказаним шляхом
        /// </summary>
        /// <param name="path">
        /// шлях до файлу в файловій системі
        /// </param>
        /// <returns>
        /// Текст з даного файлу
        /// </returns>
        public string Open(string path)
        {
            string text = "";
            return text;
        }

        /// <summary>
        /// Створює новий  файл за вказаним шляхом
        /// </summary>
        /// <param name="path">шлях до папки де буде знаходитись новий файл </param>
        /// /// <param name="name"> Ім'я нового файлу</param>
        /// <returns>
        /// true коли вдалося створити файл
        /// false коли не вдалося створити файл
        /// </returns>
        public bool Create(string name,string path)
        {
            return false;
        }

        /// <summary>
        /// Зберігає оновлене значення в файл, який було відкрито
        /// </summary>
        /// <param name="text">
        /// значення яке потрібно записати
        /// </param>
        /// <returns>
        /// true коли вдалося зберегти зміни в файл
        /// false коли не вдалося зберегти зміни в файл
        /// </returns>
        public bool Save(string text)
        {
            return false;
        }
    }
}
