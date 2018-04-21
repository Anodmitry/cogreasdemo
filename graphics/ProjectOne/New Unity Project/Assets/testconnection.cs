using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;

public class testconnection : MonoBehaviour {

    void Start()
    {
        try
        {
            Debug.Log("Start");
            //была проблема с незакрытыми datareader
            //решена путём введения поля класса temp_reader типа datareader, в которое кладётся результат runsqlcommand во всех случаях
            //в свою очередь, при каждом вызове runsqlcommand вызывается метод, закрывающий temp_reader
            //"user id = admin; password = adminadmin; Initial Catalog=envdb;
            string connstr =
                 @"Data Source=127.0.0.1\sqlexpress;" +
                 "user id = admin;" +
                 "password = adminadmin;" +
                 "Initial Catalog=envdb_mini;";// +
                                               //"MultipleActiveResultSets=true;";


            SqlConnection dbconn = new SqlConnection(connstr);
            dbconn.Open();
            string sqlExpression = "INSERT INTO Table_1 (test) VALUES ('test4')";// "INSERT INTO Active_objects (ao_name, id_type) VALUES ('test_171117', '1')";
            SqlCommand thisCommand = new SqlCommand(sqlExpression, dbconn);
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            dbconn.Close();



            //ChangeDB_Lib.Change_DB.connectionString = connstr;
            //ChangeDB_Lib.Change_ActObj apiactobj = new ChangeDB_Lib.Change_ActObj();//здесь же происходит соединение


            //apiactobj.ConnectToDb(connstr);
            //apiactobj.AddActObj("test_222", "бот");
            //apiactobj.CloseConnection();
            Debug.Log("Success");
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
