using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Файл с функциями возможностей на будущее
/// </summary>
namespace Ginger
{
    class Future
    {
        /*
            /// <summary>
            /// Простой вариант через запросы
            /// </summary>
            /// <returns></returns>
            public bool FirstCreateTables()
            {
                Init ini = new Init();
                /*string basename = "CompanyWorkers";
                string basefileext = ".db3";
                string basepath = Path.Combine(ini.LocalUserPath, basename + basefileext);
                int i = 0;

                string connectionstring = ini.DbConnectString;

                try
                {
                    using (SqlConnection connection = new SqlConnection())
                    {
                        connection.ConnectionString = connectionstring;
                        connection.Open();

                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            // 1.
                            command.CommandText = @"CREATE TABLE [master] (
                    [Id] INT IDENTITY (1,1) PRIMARY KEY,
                    [name] char(100) NOT NULL,
                    [value] char(100) NOT NULL
                    );";
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();
                            // 1.1 Настройки
                            command.CommandText = "INSERT INTO [master] " +
                                "(name, value) VALUES ('dbversion', '1');";
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();

                            // 2. Основная база
                            command.CommandText = @"CREATE TABLE [Appartments] (
                    [Id] INT IDENTITY (1,1) PRIMARY KEY,
                    [Rooms] char(5) NOT NULL,
                    [Address] NVARCHAR(250) NOT NULL,
                    [NumberAppt] char(4) NOT NULL,
                    [District] char(100) NOT NULL,
                    [DateCall] date,
                    [DateFree] date,
                    [Elite] bit
                    );";
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();

                            // 3. Архив
                            command.CommandText = @"CREATE TABLE [Archive] (
                    [Id] INT IDENTITY (1,1) PRIMARY KEY,
                    [Rooms] char(5) NOT NULL,
                    [Address] NVARCHAR(250) NOT NULL,
                    [NumberAppt] char(4) NOT NULL,
                    [District] char(100) NOT NULL,
                    [DateCall] date,
                    [DateFree] date,
                    [Elite] bit
                    );";
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();

                        }
                    }
                }
                catch (SqlException ex)
                { Logger.WriteLog(ex.Message); }
                catch (Exception ex)
                { Logger.WriteLog(ex.Message); }


                return true;
            }*/

            /// <summary>
            /// Функция из DalADO.cs - возможность варьировать названия базы данных
            /// </summary>
            /// <returns></returns>
            /*public bool FirstCreateTables()
            {
                Init ini = new Init();
                string basename = "CompanyWorkers";
                string basefileext = ".db3";
                string basepath = Path.Combine(ini.LocalUserPath, basename + basefileext);
                int i = 0;

                while (true)
                {
                    if (!File.Exists(basepath))
                    {
                        SQLiteConnection.CreateFile(basepath);
                        ini.DbConnectString = "Data Source = " + basepath;
                        ini.SaveAllParameters();
                        break;
                    }
                    else
                    {
                        basepath = Path.Combine(ini.LocalUserPath, basename + i.ToString() + basefileext);
                        i++;
                    }
                }

                SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");

                using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
                {
                    connection.ConnectionString = ini.DbConnectString;
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        // 1.
                        command.CommandText = @"CREATE TABLE [master] (
                        [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                        [name] char(100) NOT NULL,
                        [value] char(100) NOT NULL
                        );";
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        // 1.1 Настройки
                        command.CommandText = "INSERT INTO [master] " +
                            "(name, value) VALUES ('dbversion', '1');";
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();

                        // 2. Основная база
                        command.CommandText = @"CREATE TABLE [Appartments] (
                        [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                        [Rooms] char(5) NOT NULL,
                        [Address] char(250) NOT NULL,
                        [NumberAppt] char(4) NOT NULL,
                        [District] char(100) NOT NULL,
                        [DateCall] date,
                        [DateFree] date,
                        [Elite] BOOLEAN
                        );";
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();

                        // 3. Архив
                        command.CommandText = @"CREATE TABLE [Archive] (
                        [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                        [Rooms] char(5) NOT NULL,
                        [Address] char(250) NOT NULL,
                        [NumberAppt] char(4) NOT NULL,
                        [District] char(100) NOT NULL,
                        [DateCall] date,
                        [DateFree] date,
                        [Elite] BOOLEAN
                        );";
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();

                    }
                }

                return true;
            }*/

        }
}
