using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace derveninov01_kursovaya_prog3
{
    /// <summary>
    /// Помощник в работе с файлами
    /// </summary>
    class FileHelper
    {
        /// <summary>
        /// Сохранение опросника в файл
        /// </summary>
        public static void SaveQuest<Questionnaire>(Questionnaire obj, string filePath)
        {
            using (var fs = File.OpenWrite(filePath))
                new BinaryFormatter().Serialize(fs, obj);
        }

        /// <summary>
        /// Чтение опросника из файла
        /// </summary>
        public static Questionnaire LoadQuest<Questionnaire>(string filePath)
        {
            using (var fs = File.OpenRead(filePath))
                return (Questionnaire)new BinaryFormatter().Deserialize(fs);
        }
    }
}
