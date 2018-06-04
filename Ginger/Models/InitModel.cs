using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ginger
{
    public partial class Init
    {
        //string localUserPath; // Путь к локальному каталогу пользователя (например, %AppData%)
        int minAge, maxAge; // Минимальной и максимально допустимый возраст в годах
        bool enableAI; // Включить запросы к Яндексу
        string dbConnectString; // Строка подключения к Яндексу
        string picturePath; // Путь к базе с изображениями
        string colorForDaysLittle; // Цвет строк, когда осталось мало дней
        string colorForDaysTooLittle; // Цвет строк, когда осталось совсем мало дней
        int daysLittle; // Осталось мало дней до освобождения квартиры
        int daysTooLittle; // Осталось совсем мало дней до освобождения квартиры
        string s_rezerved_01;
        string s_rezerved_02;
        string s_rezerved_03;
        string s_rezerved_04;
        string s_rezerved_05;
        string s_rezerved_06;
        string s_rezerved_07;
        int i_rezerved_01;
        int i_rezerved_02;
        int i_rezerved_03;
        int i_rezerved_04;
        int i_rezerved_05;
        int i_rezerved_06;
        int i_rezerved_07;
        bool b_rezerved_01;
        bool b_rezerved_02;
        bool b_rezerved_03;
        bool b_rezerved_04;
        bool b_rezerved_05;
        bool b_rezerved_06;
        bool b_rezerved_07;

        public Init(out int result)
        { result = LoadAllParameters(); }
        public Init()
        { LoadAllParameters(); }

        public string LocalUserPath
        { get { return GetSafeLocalUserPath(); } }  // Путь к локальному каталогу пользователя (например, %AppData%)

        public int Version { get { return version; } }
        public int MinAge
        {
            get { return minAge; }
            set { minAge = value; }
        }
        public int MaxAge
        {
            get { return maxAge; }
            set { maxAge = value; }
        }

        public string DbConnectString
        {
            get { return dbConnectString; }
            set { dbConnectString = value; }
        }

        public string PicturePath
        {
            get { return picturePath; }
            set { picturePath = value; }
        }
        public string ColorForDaysLittle
        {
            get { return colorForDaysLittle; }
            set { colorForDaysLittle = value; }
        }
        public string ColorForDaysTooLittle
        {
            get { return colorForDaysTooLittle; }
            set { colorForDaysTooLittle = value; }
        }

        public int DaysLittle
        {
            get { return daysLittle; }
            set { daysLittle = value; }
        }
        public int DaysTooLittle
        {
            get { return daysTooLittle; }
            set { daysTooLittle = value; }
        }


        public string S_rezerved_01
        {
            get { return s_rezerved_01; }
            set { s_rezerved_01 = value; }
        }

        public int I_rezerved_01
        {
            get { return i_rezerved_01; }
            set { i_rezerved_01 = value; }
        }

        public bool B_rezerved_01
        {
            get { return b_rezerved_01; }
            set { b_rezerved_01 = value; }
        }


        public bool EnableAI { get { return enableAI; } set { enableAI = value; } }

        // Опознавательные признаки компьютера
        public string GUID
        { get { return Get_GUID(); } }
        public string UUID
        { get { return Get_UUID(); } }
    }
}
