using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                 @"Data Source=127.0.0.1\sqlexpress01;" +
                 "user id = admin;" +
                 "password = adminadmin;" +
                 "Initial Catalog=envdb;";// +
                                          //"MultipleActiveResultSets=true;";
            ChangeDB_Lib.Change_DB.connectionString = connstr;
            ChangeDB_Lib.Change_ActObj apiactobj = new ChangeDB_Lib.Change_ActObj();//здесь же происходит соединение


            //apiactobj.ConnectToDb(connstr);
            apiactobj.AddActObj("test_222", "бот");
            apiactobj.CloseConnection();
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
