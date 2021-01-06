using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cameraAndVideo
{
    class Database
    {
        #region Fields
        private static SQLiteConnection instance;
        #endregion Fields

        #region Constructors

        private Database()
        {

        }

        #endregion Constructors

        #region Methods

        public static SQLiteConnection GetInstance()
        {
            string AutoSurvSettings = "create table AutoSurvSettings (id integer NOT NULL, hours integer, minutes integer, primary key(id))";
            string RecordData = "create table RecordData (id uuid NOT NULL, startTime datetime, endTime datetime, fileName varchar(30), primary key(id))";

            if(instance == null)
            {
                instance = new SQLiteConnection("Data Source = database");

                if(!File.Exists("./database"))
                {
                    SQLiteConnection.CreateFile("database");

                    SQLiteCommand command1 = new SQLiteCommand(AutoSurvSettings, instance);
                    SQLiteCommand command2 = new SQLiteCommand(RecordData, instance);
             
                    instance.Open();

                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();

                    instance.Close();
                }
            }

            return instance;
        }

        #endregion Methods
    }
}
