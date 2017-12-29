using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.OleDb;
using System.Data.SqlClient;

//список закомментированного
//GetListTables
//

//создаем объект главного класса changeobj
//так как у потомков были не закрыты датаридеры на том же соединении, то возникает проблема при возврате к основному объекту
//можно каждый раз открывать новое соединение при изменении разных сущностей
//или хранить для 4-х сущностей свои соединения


namespace ChangeDB_Lib
{
    public class Change_DB
    {
        //public OleDbConnection dbconn;
        public static string connectionString;
        public SqlConnection dbconn;
        public SqlDataReader temp_reader;

        //не определил конструктор, потому что тогда его придётся вызывать по base

        ~Change_DB()//деструктор, закрывающий соединение - хм, а правильное ли это место для закрытия соединения
        {
            //if(this.dbconn)//как проверить, что соединение и так не закрыто и надо ли??
            this.CloseConnection();
        }

        public bool CloseDataReader()
        {
            if (this.temp_reader == null || this.temp_reader.IsClosed) return false;
            temp_reader.Close();
            return true;
        }

        public void ConnectToDb(string connstr)
        {
            try
            {
                //connstr =
                // @"Data Source=127.0.0.1\sqlexpress01;" +
                // "user id = admin;" +
                // "password = adminadmin;" +
                // "Initial Catalog=envdb;" +
                // "MultipleActiveResultSets=true;";

                dbconn = new SqlConnection(connstr);
                dbconn.Open();

                //SqlConnection conn = new SqlConnection(cs);
                //conn.Open();
                //string sqlExpression = "INSERT INTO Active_objects (ao_name, id_type) VALUES ('test_171117', '1')";
                //SqlCommand thisCommand = new SqlCommand(sqlExpression, conn);
                //SqlDataReader thisReader = thisCommand.ExecuteReader();
                //int k = thisReader.FieldCount;
                //conn.Close();

                //test//throw new Exception("End!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void CloseConnection()
        {
            try
            {
                dbconn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public /*SqlDataReader*/void RunSqlCommand(string command)
        {
            try
            {
                this.CloseDataReader();//закрываем temp_reader
                SqlCommand thisCommand = dbconn.CreateCommand();
                thisCommand.CommandText = command;
                temp_reader = thisCommand.ExecuteReader();//возвращает результат выполнения
                //return thisReader;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
