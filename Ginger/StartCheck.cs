using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Процедуры, связанные со стартом программы
/// </summary>
namespace Ginger
{
    public partial class Form1 : Form
    {
        const byte CHECK_OK = 0;
        const byte CHECK_EXIT = 1;
        const byte CHECK_SETTINGS = 2;

        /// <summary>
        /// Различные стартовые проверки
        /// </summary>
        /// <returns>0 - Ok, 1 - Exit Program, 2 - ShowSettings</returns>
        byte StartCheckList()
        {
            Init Ini;

            // 1. Выявляем возможные проблемы с файлом настроек
            // Проблемы:
            // - файл отсутствует. Это может означать либо первый запуск,
            //   либо перенос программы (по умыслу либо плановый)
            // - файл поврежден. Либо перенос программы, либо простое повреждение
            // - файл имеет другую версию, нежели предполагается в программе.
            //   Версия файла может быть ниже. Тогда нужно провести процедуры обновления
            //   Версия файла может быть выше. Тогда это странная ситуация - запустили
            //   устаревшую программу в обновленной среде. Стратегию надо продумать.
            // 2. Выявляем возможный перенос программы 
            // Признаки переноса:
            // - Если файл настроек отсутствует, см. пункт 1
            // - Если изменился GUID или UUID
            // - Если в файле настроек нет строки подключения к базе данных
            // 3. Проверка версии базы данных
            //   Если база данных более старая, чем предусмотрено программой, необходимо обновление базы
            //   Если база данных более новая, чем предусмотрено программой, работать нельзя, надо обновить программу

            Ini = new Init(out int IniFileLoadingCode);
            /*MessageBox.Show("Код ошибки: " + IniFileLoadingCode.ToString() + "\nConnectString: " +
                Ini.DbConnectString);*/
            //IniFileLoadingCode = 4;
            DalADO dal = new DalADO();
            UpdateProgram upd = new UpdateProgram();
            switch (IniFileLoadingCode)
            {
                case 0:
                    break;
                case 1: // Нет файла настроек
                    if (Dialogs.ControlAttentionFirstStart() == true)
                    {
                        Ini.SaveAllParameters(); // Создание файла с параметрами по умолчанию
                        MessageBox.Show("Настройки произведены. Перезапустите программу.");
                        return CHECK_EXIT;
                    }
                    else
                    {
                        MessageBox.Show("У вас нет прав запуска и настройки программы.\nПрограмма завершается.");
                        return CHECK_EXIT;
                    }
                case 2: // Повреждён
                    if (Dialogs.ControlAttentionUniversal() == true)
                    {
                        FormIniFilePath frm3 = new FormIniFilePath(Ini.LocalUserPath);
                        frm3.ShowDialog();
                        return CHECK_EXIT;
                    }
                    else
                    {
                        MessageBox.Show("У вас нет прав запуска и настройки программы.\nПрограмма завершается.");
                        return CHECK_EXIT;
                    }
                case 3: // Файл настроек старее
                    upd.UpdateIniFile();
                    return CHECK_OK; // Пока работает так, потом надо прописать логику
                case 4: // Файл настроек новее программы
                    MessageBox.Show("Несоответствие версии файла настроек.\n" +
                        "Возможно, программа некорректно скопирована. Продолжение работы невозможно.\n" +
                        "Программа завершается.");
                    return CHECK_EXIT; // Пока работает так, потом надо прописать логику
                default:
                    return CHECK_EXIT;
            }
            // if (GUIDorUUIDchanged()) {warning}
            if (dal.IsDbConnectionOK() == false)
            {
                if (Ini.DbConnectString.Trim() == String.Empty)
                {
                    // Не получается подключиться. Сделаем два варианта уведомлений
                    // Вариант 1. Пустая строка
                    if (Dialogs.ControlAttentionUniversal("\nПустая строка подключения к БД.\n" +
                      "Проверьте настройки") == true)
                    {
                        return CHECK_SETTINGS;
                    }
                    else
                    {
                        MessageBox.Show("Продолжение работы невозможно. Программа завершается.");
                        return CHECK_EXIT;
                    }
                } // if (Ini.DbConnectString.Trim() == String.Empty)
                // Вариант 2.
                if (Dialogs.ControlAttentionUniversal("\nВозможно, неверная строка подключения к БД.\n" +
                    "Проверьте настройки") == true)
                { return CHECK_SETTINGS; }
                else
                {
                    MessageBox.Show("Продолжение работы невозможно. Программа завершается.");
                    return CHECK_EXIT;
                }
            }
            else
            {
                if (dal.DbOlder()) { upd.UpdateDB(); }
                if (dal.DbNewer())
                {
                    MessageBox.Show("Несоответствие версии базы данных.\n" +
                        "Возможно, программа некорректно скопирована. Продолжение работы невозможно.\n" +
                        "Программа завершается.");
                    return CHECK_EXIT;
                }
            }
            return CHECK_OK;
        }
    }
}
