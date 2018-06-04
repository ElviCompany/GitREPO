using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Отвечает за работу с конфигурационным файлом
/// </summary>
namespace Ginger
{
    public partial class Init
    {
        readonly int version = 3; // Версия формата ini-файла

        /// <summary>
        /// Извлекаем папку LOCALAPPDATA
        /// </summary>
        /// <returns></returns>
        string GetSafeLocalUserPath()
        {
            string safeLocalUserPath = "";
            //if (localUserPath == null)
            safeLocalUserPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Ginger");
            return safeLocalUserPath;
        }

        /// <summary>
        /// Функция считывает все параметры из Ini-файла
        /// </summary>
        /// <returns>0 - Успешно
        /// 1 - Файл с параметрами не найден
        /// 2 - Файл с параметрами повреждён (характер повреждений может быть разным)
        /// 3 - Версия файла ниже текущей версии (требуется обновление)
        /// 4 - Версия файла выше текущей версии (запуск в новой среде)
        /// </returns>
        int LoadAllParameters()
        {
            int result = 0;
            List<object> iniRAWparams = new List<object>();
            int? iniversion;
            Dictionary<string, string> iniparams = new Dictionary<string, string>();
            string IniFilePath;
            BinaryFormatter formatter = new BinaryFormatter();
            object obj;

            // Обнаруживаем файл с параметрами
            IniFilePath = Path.Combine(this.LocalUserPath, "people.dat");
            if (File.Exists(IniFilePath))
            {
                try
                {
                    using (Stream file = File.Open(IniFilePath, FileMode.Open))
                    {
                        obj = formatter.Deserialize(file);
                        iniRAWparams = obj as List<object>;
                        //iniparams = obj as Dictionary<string, string>;
                        // https://stackoverflow.com/questions/26383711/serialize-deserialize-a-list-of-objects-using-binaryformatter
                        //you may want to run some checks (objects is not null and contains 2 elements for example)
                        /*var nodes = iniparams[0] as List<TreeNode>;
                        var dictionary = iniparams[1] as Dictionary<int, Tuple<List<string>, List<string>>>;*/
                        iniversion = iniRAWparams[0] as int?;
                        iniparams = iniRAWparams[1] as Dictionary<string, string>;
                        //use nodes and dictionary
                    }
                }
                catch (System.Runtime.Serialization.SerializationException ex)
                {
                    iniversion = null;
                    iniparams = null;
                    Logger.EmailLog(ex.ToString()); // В Log-файл записать не получится, так неизвестен путь до него, ведь Ini-файл повреждён
                    return 2; // Считаем, что файл с настройками поврежден
                }
                catch (Exception ex)
                {
                    iniversion = null;
                    iniparams = null;
                    Logger.EmailLog(ex.ToString());
                    return 1; // Поскольку тип исключения не определён, считаем, что файл с настройками отсутствует, чтобы его пересоздать
                }
            }
            else // Файла с параметрами нет, устанавливаем ВСЕ значения по умолчанию и выходим
            {
                SetDefaultIniParam();
                //SaveAllParameters();
                return 1;
            }

            // Если в файле нет заголовка Version, значит, он однозначно повреждён
            // Устанавливаем параметры по умолчанию
            if (!iniversion.HasValue) { SetDefaultIniParam(); return 2; }

            // Если версия файла ниже текущей, требуемой программой
            if (iniversion < this.version) { return 3; }

            // Если версия файла ниже текущей, требуемой программой
            if (iniversion > this.version) { return 4; }

            // Устанавливаем параметры
            // Если какого-то нет, то устанавливаем его по умолчанию
            if (iniparams.ContainsKey("minAge"))
            { this.minAge = int.Parse(iniparams["minAge"]); }
            else
            { SetDefaultIniParam("minAge"); }
            if (iniparams.ContainsKey("maxAge"))
            { this.maxAge = int.Parse(iniparams["maxAge"]); }
            else
            { SetDefaultIniParam("maxAge"); }
            if (iniparams.ContainsKey("dbConnectString"))
            { this.dbConnectString = iniparams["dbConnectString"]; }
            else
            { SetDefaultIniParam("dbConnectString"); }

            if (iniparams.ContainsKey("enableAI"))
            { this.enableAI = bool.Parse(iniparams["enableAI"]); }
            else
            { SetDefaultIniParam("enableAI"); }

            if (iniparams.ContainsKey("picturePath"))
            { this.picturePath = iniparams["picturePath"]; }
            else
            { SetDefaultIniParam("picturePath"); }
            if (iniparams.ContainsKey("colorForDaysLittle"))
            { this.colorForDaysLittle = iniparams["colorForDaysLittle"]; }
            else
            { SetDefaultIniParam("colorForDaysLittle"); }
            if (iniparams.ContainsKey("colorForDaysTooLittle"))
            { this.colorForDaysTooLittle = iniparams["colorForDaysTooLittle"]; }
            else
            { SetDefaultIniParam("colorForDaysTooLittle"); }

            if (iniparams.ContainsKey("daysLittle"))
            { this.daysLittle = int.Parse(iniparams["daysLittle"]); }
            else
            { SetDefaultIniParam("daysLittle"); }

            if (iniparams.ContainsKey("daysTooLittle"))
            { this.daysTooLittle = int.Parse(iniparams["daysTooLittle"]); }
            else
            { SetDefaultIniParam("daysTooLittle"); }

            if (iniparams.ContainsKey("s_rezerved_01"))
            { this.s_rezerved_01 = iniparams["s_rezerved_01"]; }
            else
            { SetDefaultIniParam("s_rezerved_01"); }
            if (iniparams.ContainsKey("s_rezerved_02"))
            { this.s_rezerved_02 = iniparams["s_rezerved_02"]; }
            else
            { SetDefaultIniParam("s_rezerved_02"); }
            if (iniparams.ContainsKey("s_rezerved_03"))
            { this.s_rezerved_03 = iniparams["s_rezerved_03"]; }
            else
            { SetDefaultIniParam("s_rezerved_03"); }
            if (iniparams.ContainsKey("s_rezerved_04"))
            { this.s_rezerved_04 = iniparams["s_rezerved_04"]; }
            else
            { SetDefaultIniParam("s_rezerved_04"); }
            if (iniparams.ContainsKey("s_rezerved_05"))
            { this.s_rezerved_05 = iniparams["s_rezerved_05"]; }
            else
            { SetDefaultIniParam("s_rezerved_05"); }
            if (iniparams.ContainsKey("s_rezerved_06"))
            { this.s_rezerved_06 = iniparams["s_rezerved_06"]; }
            else
            { SetDefaultIniParam("s_rezerved_06"); }

            if (iniparams.ContainsKey("s_rezerved_07"))
            { this.s_rezerved_07 = iniparams["s_rezerved_07"]; }
            else
            { SetDefaultIniParam("s_rezerved_07"); }

            if (iniparams.ContainsKey("b_rezerved_01"))
            { this.b_rezerved_01 = bool.Parse(iniparams["b_rezerved_01"]); }
            else
            { SetDefaultIniParam("b_rezerved_01"); }

            if (iniparams.ContainsKey("b_rezerved_02"))
            { this.b_rezerved_02 = bool.Parse(iniparams["b_rezerved_02"]); }
            else
            { SetDefaultIniParam("b_rezerved_02"); }

            if (iniparams.ContainsKey("b_rezerved_03"))
            { this.b_rezerved_03 = bool.Parse(iniparams["b_rezerved_03"]); }
            else
            { SetDefaultIniParam("b_rezerved_03"); }

            if (iniparams.ContainsKey("b_rezerved_04"))
            { this.b_rezerved_04 = bool.Parse(iniparams["b_rezerved_04"]); }
            else
            { SetDefaultIniParam("b_rezerved_04"); }

            if (iniparams.ContainsKey("b_rezerved_05"))
            { this.b_rezerved_05 = bool.Parse(iniparams["b_rezerved_05"]); }
            else
            { SetDefaultIniParam("b_rezerved_05"); }

            if (iniparams.ContainsKey("b_rezerved_06"))
            { this.b_rezerved_06 = bool.Parse(iniparams["b_rezerved_06"]); }
            else
            { SetDefaultIniParam("b_rezerved_06"); }

            if (iniparams.ContainsKey("b_rezerved_07"))
            { this.b_rezerved_07 = bool.Parse(iniparams["b_rezerved_07"]); }
            else
            { SetDefaultIniParam("b_rezerved_07"); }

            if (iniparams.ContainsKey("i_rezerved_01"))
            { this.i_rezerved_01 = int.Parse(iniparams["i_rezerved_01"]); }
            else
            { SetDefaultIniParam("i_rezerved_01"); }

            if (iniparams.ContainsKey("i_rezerved_02"))
            { this.i_rezerved_02 = int.Parse(iniparams["i_rezerved_02"]); }
            else
            { SetDefaultIniParam("i_rezerved_02"); }

            if (iniparams.ContainsKey("i_rezerved_03"))
            { this.i_rezerved_03 = int.Parse(iniparams["i_rezerved_03"]); }
            else
            { SetDefaultIniParam("i_rezerved_03"); }

            if (iniparams.ContainsKey("i_rezerved_04"))
            { this.i_rezerved_04 = int.Parse(iniparams["i_rezerved_04"]); }
            else
            { SetDefaultIniParam("i_rezerved_04"); }

            if (iniparams.ContainsKey("i_rezerved_05"))
            { this.i_rezerved_05 = int.Parse(iniparams["i_rezerved_05"]); }
            else
            { SetDefaultIniParam("i_rezerved_05"); }

            if (iniparams.ContainsKey("i_rezerved_06"))
            { this.i_rezerved_06 = int.Parse(iniparams["i_rezerved_06"]); }
            else
            { SetDefaultIniParam("i_rezerved_06"); }

            if (iniparams.ContainsKey("i_rezerved_07"))
            { this.i_rezerved_07 = int.Parse(iniparams["i_rezerved_07"]); }
            else
            { SetDefaultIniParam("i_rezerved_07"); }

            // Если изменился GUID, программа была перемещена на другой компьютер
            /*if (iniparams.ContainsKey("GUID"))
            {
                if (this.GUID != iniparams["GUID"])
                    SetDefaultIniParam("GUID");
            }
            else SetDefaultIniParam("GUID");

            // Если изменился UUID, устанавливаем параметры по умолчанию
            if (iniparams.ContainsKey("UUID"))
            {
                if (this.UUID != iniparams["UUID"])
                    SetDefaultIniParam("UUID");
            }
            else SetDefaultIniParam("UUID"); // Если отсутствует, то тоже сбрасываем,*/

            result = 0;

            return result;
        }

        /// <summary>
        /// Функция сохраняет все параметры в Ini-файл
        /// </summary>
        /// <returns>Успешно/неуспешно</returns>
        public bool SaveAllParameters()
        {
            bool result = false;
            List<object> iniRAWparams = new List<object>();
            Dictionary<string, string> iniparams = new Dictionary<string, string>();
            string IniFileName;
            BinaryFormatter formatter = new BinaryFormatter();

            iniparams.Add("minAge", this.minAge.ToString());
            iniparams.Add("maxAge", this.maxAge.ToString());
            iniparams.Add("daysLittle", this.daysLittle.ToString());
            iniparams.Add("daysTooLittle", this.daysTooLittle.ToString());
            iniparams.Add("i_rezerved_01", this.i_rezerved_01.ToString());
            iniparams.Add("i_rezerved_02", this.i_rezerved_02.ToString());
            iniparams.Add("i_rezerved_03", this.i_rezerved_03.ToString());
            iniparams.Add("i_rezerved_04", this.i_rezerved_04.ToString());
            iniparams.Add("i_rezerved_05", this.i_rezerved_05.ToString());
            iniparams.Add("i_rezerved_06", this.i_rezerved_06.ToString());
            iniparams.Add("i_rezerved_07", this.i_rezerved_07.ToString());

            iniparams.Add("colorForDaysTooLittle", this.colorForDaysTooLittle);
            iniparams.Add("colorForDaysLittle", this.colorForDaysLittle);
            iniparams.Add("picturePath", this.picturePath);
            iniparams.Add("GUID", this.GUID);
            iniparams.Add("UUID", this.UUID);
            iniparams.Add("dbConnectString", this.dbConnectString);
            iniparams.Add("s_rezerved_01", this.s_rezerved_01);
            iniparams.Add("s_rezerved_02", this.s_rezerved_02);
            iniparams.Add("s_rezerved_03", this.s_rezerved_03);
            iniparams.Add("s_rezerved_04", this.s_rezerved_04);
            iniparams.Add("s_rezerved_05", this.s_rezerved_05);
            iniparams.Add("s_rezerved_06", this.s_rezerved_06);
            iniparams.Add("s_rezerved_07", this.s_rezerved_07);

            iniparams.Add("enableAI", this.enableAI.ToString());
            iniparams.Add("b_rezerved_01", this.b_rezerved_01.ToString());
            iniparams.Add("b_rezerved_02", this.b_rezerved_02.ToString());
            iniparams.Add("b_rezerved_03", this.b_rezerved_03.ToString());
            iniparams.Add("b_rezerved_04", this.b_rezerved_04.ToString());
            iniparams.Add("b_rezerved_05", this.b_rezerved_05.ToString());
            iniparams.Add("b_rezerved_06", this.b_rezerved_06.ToString());
            iniparams.Add("b_rezerved_07", this.b_rezerved_07.ToString());

            iniRAWparams.Add(this.version);
            iniRAWparams.Add(iniparams);

            try
            {
                // Удаляем файл с параметрами
                IniFileName = Path.Combine(LocalUserPath, "people.dat");
                if (File.Exists(IniFileName))
                {
                    File.Delete(IniFileName);
                }

                // Создаем каталог при необходимости
                if (!Directory.Exists(LocalUserPath))
                {
                    Directory.CreateDirectory(LocalUserPath);
                }

                // Пишем во вновь созданный файл
                using (FileStream fs = new FileStream(IniFileName, FileMode.OpenOrCreate))
                {
                    // сериализуем весь массив List <SerialIni>
                    formatter.Serialize(fs, iniRAWparams);
                }

                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании файла настроек\n" +
                    ex.Message);
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Процедура, запускаемая, если Ini-файл повреждён.
        /// В настоящий момент просто заглушка.
        /// </summary>
        void IniFileDamaged()
        { }

        /// <summary>
        /// Возвращает значения параметра по умолчанию
        /// на тот случай, если параметр был не найден в Ini-файле,
        /// либо при обновлении формата Ini-файла, если такого параметра раньше не было.
        /// </summary>
        /// <param name="ParamName">Имя параметра</param>
        /// <returns></returns>
        void SetDefaultIniParam(string ParamName)
        {
            switch (ParamName)
            {
                case "minAge":
                    minAge = 14;
                    break;
                case "maxAge":
                    maxAge = 90;
                    break;
                case "daysLittle":
                    daysLittle = 2;
                    break;
                case "daysTooLittle":
                    daysTooLittle = 1;
                    break;
                case "dbConnectString":
                    /*string baseName = "CompanyWorkers.db3";
                    dbConnectString = "Data Source = " + Path.Combine(GetSafeLocalUserPath(),  baseName);*/
                    dbConnectString = @"data source = (LocalDB)\MSSQLLocalDB; attachdbfilename = G:\l\GDB\CompanyWorkers.mdf; integrated security = False; connect timeout = 30";
                    //dbConnectString = @"data source = (LocalDB)\MSSQLLocalDB; attachdbfilename = C:\Distr\DB\CompanyWorkers.mdf; integrated security = False; connect timeout = 30";
                    break;
                case "colorForDaysTooLittle":
                    colorForDaysTooLittle = "Red";
                    break;
                case "colorForDaysLittle":
                    colorForDaysLittle = "LightBlue";
                    break;
                case "picturePath":
                    picturePath = "";
                    break;
                case "enableAI":
                    enableAI = false;
                    break;
                case "i_rezerved_01":
                    i_rezerved_01 = 0;
                    break;
                case "i_rezerved_02":
                    i_rezerved_02 = 0;
                    break;
                case "i_rezerved_03":
                    i_rezerved_03 = 0;
                    break;
                case "i_rezerved_04":
                    i_rezerved_04 = 0;
                    break;
                case "i_rezerved_05":
                    i_rezerved_05 = 0;
                    break;
                case "i_rezerved_06":
                    i_rezerved_06 = 0;
                    break;
                case "i_rezerved_07":
                    i_rezerved_07 = 0;
                    break;
                case "b_rezerved_01":
                    b_rezerved_01 = false;
                    break;
                case "b_rezerved_02":
                    b_rezerved_02 = false;
                    break;
                case "b_rezerved_03":
                    b_rezerved_03 = false;
                    break;
                case "b_rezerved_04":
                    b_rezerved_04 = false;
                    break;
                case "b_rezerved_05":
                    b_rezerved_05 = false;
                    break;
                case "b_rezerved_06":
                    b_rezerved_06 = false;
                    break;
                case "b_rezerved_07":
                    b_rezerved_07 = false;
                    break;
                case "s_rezerved_01":
                    s_rezerved_01 = "";
                    break;
                case "s_rezerved_02":
                    s_rezerved_02 = "";
                    break;
                case "s_rezerved_03":
                    s_rezerved_03 = "";
                    break;
                case "s_rezerved_04":
                    s_rezerved_04 = "";
                    break;
                case "s_rezerved_05":
                    s_rezerved_05 = "";
                    break;
                case "s_rezerved_06":
                    s_rezerved_06 = "";
                    break;
                case "s_rezerved_07":
                    s_rezerved_07 = "";
                    break;

            }
            return;
        }

        /// <summary>
        /// Перегруженный вариант функции, который устанавливает
        /// по умолчанию сразу все параметры
        /// </summary>
        void SetDefaultIniParam()
        {
            SetDefaultIniParam("minAge");
            SetDefaultIniParam("maxAge");
            SetDefaultIniParam("daysLittle");
            SetDefaultIniParam("daysTooLittle");
            SetDefaultIniParam("i_rezerved_01");
            SetDefaultIniParam("i_rezerved_02");
            SetDefaultIniParam("i_rezerved_03");
            SetDefaultIniParam("i_rezerved_04");
            SetDefaultIniParam("i_rezerved_05");
            SetDefaultIniParam("i_rezerved_06");
            SetDefaultIniParam("i_rezerved_07");

            SetDefaultIniParam("colorForDaysTooLittle");
            SetDefaultIniParam("colorForDaysLittle");
            SetDefaultIniParam("dbConnectString");
            SetDefaultIniParam("picturePath");
            SetDefaultIniParam("s_rezerved_01");
            SetDefaultIniParam("s_rezerved_02");
            SetDefaultIniParam("s_rezerved_03");
            SetDefaultIniParam("s_rezerved_04");
            SetDefaultIniParam("s_rezerved_05");
            SetDefaultIniParam("s_rezerved_06");
            SetDefaultIniParam("s_rezerved_07");

            SetDefaultIniParam("enableAI");
            SetDefaultIniParam("b_rezerved_01");
            SetDefaultIniParam("b_rezerved_02");
            SetDefaultIniParam("b_rezerved_03");
            SetDefaultIniParam("b_rezerved_04");
            SetDefaultIniParam("b_rezerved_05");
            SetDefaultIniParam("b_rezerved_06");
            SetDefaultIniParam("b_rezerved_07");

            return;
        }

        /// <summary>
        /// Получает UUID компьютера
        /// </summary>
        /// <returns></returns>
        public string Get_UUID()
        {
            string uuid;

            uuid = "";

            try
            {
                string ComputerName = "localhost";
                ManagementScope Scope;
                Scope = new ManagementScope(String.Format("\\\\{0}\\root\\CIMV2", ComputerName), null);
                Scope.Connect();
                ObjectQuery Query = new ObjectQuery("SELECT UUID FROM Win32_ComputerSystemProduct");
                ManagementObjectSearcher Searcher = new ManagementObjectSearcher(Scope, Query);

                foreach (ManagementObject WmiObject in Searcher.Get())
                {
                    uuid = uuid + WmiObject["UUID"];// String                     
                }
            }
            catch (Exception e)
            {
                uuid = String.Format("Exception {0} Trace {1}", e.Message, e.StackTrace);
            }

            return uuid;
        }

        /// <summary>
        /// Получает GUID из Active Directory (или локального компьютера, если он не в домене)
        /// </summary>
        /// <returns></returns>
        public string Get_GUID()
        {
            string strGUID = "";
            SecurityIdentifier guid;

            guid = new SecurityIdentifier((byte[])new DirectoryEntry(string.Format("WinNT://{0},Computer", Environment.MachineName)).Children.Cast<DirectoryEntry>().First().InvokeGet("objectSID"), 0).AccountDomainSid;
            strGUID = guid.ToString();

            return strGUID;
        }
    }
}
