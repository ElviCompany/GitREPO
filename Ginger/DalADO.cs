using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Windows;

/// <summary>
/// Data Access Layer - работа с базой данных с помощью ADO
/// </summary>
namespace Ginger
{
    public class ADOContext : DataContext
    {
        public ADOContext(string connection) : base(connection) { }
        public Table<Appartment> Appartments;
        public Table<GingerSettings> Masters;
        public Table<Comment> Comments;
        public Table<Picture> Pictures;
    }

    class DalADO
    {
        const int PROGRAM_DB_VERSION = 1;

        /// <summary>
        /// Загружаем таблицу квартир
        /// Используем ADO с прямым SQL-запросом к базе, для скорости
        /// </summary>
        /// <param name="Status">0 - активный, 1 - сдана, 2 - архив</param>
        /// <returns></returns>
        public DataSet GetApptDS(byte Status=0)
        {
            DataSet ds;
            SqlDataAdapter adapter;
            //SqlCommandBuilder commandBuilder;
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            string sqltext = "SELECT" +
                "[ID], [Rooms], [Street], [HouseNumber], [NumberAppt], [District], [Price], [RentTime], [DateFree], [DateCall], [ShortNotes]" +
                "FROM [Appartments]" +
                "WHERE [Status] = @Status AND NOT [Deleted]='True';";

            ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sqltext, connection);
                    SqlParameter paramStatus = new SqlParameter(parameterName: "@Status",
                        dbType: SqlDbType.Char)
                    {
                        Value = Status
                    };
                    cmd.Parameters.Add(paramStatus);

                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds, "Appartments");
                }
            }
            catch (SqlException ex)
            { Logger.WriteLog(ex.Message); }
            catch (Exception ex )
            { Logger.WriteLog (ex.Message); }

            return ds;
        }

        #region Checking

        /// <summary>
        /// Проверка на соединение с базой (не с сервером)
        /// https://docs.microsoft.com/ru-ru/sql/relational-databases/server-management-objects-smo/create-program/connecting-to-an-instance-of-sql-server?view=sql-server-2017
        /// </summary>
        /// <returns></returns>
        public bool IsDbConnectionOK ()
        {
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (SqlException)
            { return false; }
            catch (Exception)
            { return false; }
        }

        /// <summary>
        /// Проверка на соединение с сервером (не с базой)
        /// </summary>
        /// <returns></returns>
        public bool IsSQLConnectionOK ()
        {
            return false;
        }
        public bool DbOlder()
        {
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            ADOContext db = new ADOContext(connectionstring);

            // Ищем в таблице квартир
            var record = db.GetTable<GingerSettings>().Where(a => (a.Name == "dbversion")).Single();
            int db_version = int.Parse(record.Value.Trim());

            if (db_version < PROGRAM_DB_VERSION)
                return true;
            else return false;
        }

        public bool DbNewer()
        {
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            ADOContext db = new ADOContext(connectionstring);

            // Ищем в таблице квартир
            var record = db.GetTable<GingerSettings>().Where(a => (a.Name == "dbversion")).Single();
            int db_version = int.Parse(record.Value.Trim());

            if (db_version > PROGRAM_DB_VERSION)
                return true;
            else return false;
        }

        #endregion Checking


        #region CRUDAppt
        public int AddRecord (Appartment appt)
        {
            int result;
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            ADOContext db = new ADOContext(connectionstring);

            // Вставляем в таблицу квартир
            appt.Status = 0; // По умолчанию только что добавленная квартира не может сразу попасть в архив
            appt.Deleted = false; // По умолчанию только что добавленная квартира не может быть удалена
            db.GetTable<Appartment>().InsertOnSubmit(appt);
            db.SubmitChanges();

            result = appt.Id;

            return result;
        }

        public Appartment GetRecord (int ID)
        {
            Appartment result = new Appartment();
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            ADOContext db = new ADOContext(connectionstring);

            // Ищем в таблице квартир
            result = db.GetTable<Appartment>().Where(a => (a.Id == ID)).Single();

            return result;
        }

        public void UpdateRecord (int ID, Appartment appt)
        {
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            ADOContext db = new ADOContext(connectionstring);
            // Ищем в таблице квартир
            Appartment apptfind = db.GetTable<Appartment>().Where(a => (a.Id == ID)).Single();
            // Копируем все свойства
            if (apptfind != null)
            {
                for (int i = 1; i <= (appt.FieldsCount); i++)
                {
                    apptfind[i] = appt[i];
                }
                db.SubmitChanges();
            }

        }

        /// <summary>
        /// Перенос квартиры по каталогам
        /// </summary>
        /// <param name="ID">Идентификатор записи</param>
        /// <param name="status">0 - активная, 1 - сдана, 2 - архив</param>
        public void ChangeStatus (int ID, byte status)
        {
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            ADOContext db = new ADOContext(connectionstring);
            // Ищем в таблице квартир
            Appartment apptfind = db.GetTable<Appartment>().Where(a => (a.Id == ID)).Single();
            // Копируем все свойства
            if (apptfind != null)
            {
                apptfind.Status = status;
                db.SubmitChanges();
            }
        }

        public void RealDeleteRecord(int ID)
        {
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            ADOContext db = new ADOContext(connectionstring);
            // Ищем в таблице квартир
            var apptfind = db.GetTable<Appartment>().Where(a => (a.Id == ID)).Single();
            if (apptfind != null)
            {
                db.GetTable<Appartment>().DeleteOnSubmit(apptfind);
                db.SubmitChanges();
            }
        }

        public void DeleteRecord (int ID)
        {
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            ADOContext db = new ADOContext(connectionstring);
            // Ищем в таблице квартир
            var apptfind = db.GetTable<Appartment>().Where(a => (a.Id == ID)).Single();
            if (apptfind != null)
            {
                apptfind.Deleted = true;
                db.SubmitChanges();
            }
        }

        #endregion CRUDAppt


        #region CRUDPicture
        public int AddPicture(Picture pict)
        {
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            ADOContext db = new ADOContext(connectionstring);

            // Вставляем в таблицу изображений
            db.GetTable<Picture>().InsertOnSubmit(pict);
            db.SubmitChanges();

            return pict.IdPicture;
        }

        public List<Picture> GetPictures(int? IDAppt)
        {
            //Picture result = new Picture();
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            ADOContext db = new ADOContext(connectionstring);

            // Ищем в таблице картинок
            var result = db.GetTable<Picture>().Where(a => (a.Id == IDAppt));

            return result.ToList();
        }

        public void DelPicture (int IDpicture)
        {
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            ADOContext db = new ADOContext(connectionstring);
            // Ищем в таблице изображений
            var pictures = db.GetTable<Picture>().Where(a => (a.IdPicture == IDpicture)).Single();
            if (pictures != null)
            {
                File.Delete(pictures.LinkPreview);
                File.Delete(pictures.Link);
                db.GetTable<Picture>().DeleteOnSubmit(pictures);
                db.SubmitChanges();
            }

        }

        /// <summary>
        /// Фиксация новых записей изображений. Если запись добавлять не будем (передумали),
        /// то в функцию попадет ID==null (это как сигнал), и в этом случае удаляем записи с Id == 0
        /// </summary>
        /// <param name="IDAppt"></param>
        public void PictureFixation(int? IDAppt)
        {
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            ADOContext db = new ADOContext(connectionstring);
            // Ищем в таблице изображений
            var pictures = db.GetTable<Picture>().Where(a => (a.Id == 0));
            // Копируем все свойства
            foreach (Picture p in pictures)
            {
                if (IDAppt != null)
                { p.Id = IDAppt; }
                else
                {
                    File.Delete(p.LinkPreview);
                    File.Delete(p.Link);
                    db.GetTable<Picture>().DeleteOnSubmit(p);
                }

            }

            db.SubmitChanges();

        }

        #endregion CRUDPicture
        public void InitDB ()
        {
            Init ini = new Init();
            string connectionstring = ini.DbConnectString;

            ADOContext db = new ADOContext(connectionstring);
            try
            {
                if (!db.DatabaseExists())
                    db.CreateDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.WriteLog(ex.Message);
            }

            // Инициализирующие значения
            GingerSettings mr = new GingerSettings("dbversion", "1");
            // Вставляем в таблицу квартир
            db.GetTable<GingerSettings>().InsertOnSubmit(mr);
            db.SubmitChanges();


            // Костыль, исправляющий создание связи между таблицами
            //SqlDataAdapter adapter;
            //SqlCommandBuilder commandBuilder;

            //string sqltext1 = "DROP FOREIGN_KEY";
            //string sqltext2 = "ADD CONSTRAINT FOREIGN_KEY";

        }
    }
}
