using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ginger
{
    public static class Logger
    {
        /// <summary>
        /// Запись строки в лог-файл
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteLog(string msg)
        {
            Init IniParams = new Init();
            string LogFullPath;
            string FullMessageString = "";

            LogFullPath = Path.Combine(IniParams.LocalUserPath,
                                        "MSExcel.log");
            try
            {
                using (StreamWriter sw = new StreamWriter(LogFullPath, true, System.Text.Encoding.Default))
                {
                    FullMessageString = DateTime.Now.ToString();
                    FullMessageString += ": " + msg;

                    sw.WriteLine(FullMessageString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается произвести запись в файл журнала:" +
                    Environment.NewLine +
                    LogFullPath +
                    Environment.NewLine +
                    ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return;
        } // WriteLog

        /// <summary>
        /// Отправка сообщения по электронной почте, на тот случай,
        /// если нельзя записать в Log-файл, поскольку путь к Log-файлу хранится
        /// в Ini-файлу, а тот может быть недоступен
        /// </summary>
        /// <param name="msg"></param>
        public static void EmailLog (string msg)
        {
            return;
        }
    }
}
