using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;

public class ConnectDB : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        //beginning of manipulations with db
        try
        {
            Debug.Log("Start");
            string connstr =
                 @"Data Source=127.0.0.1\sqlexpress;" +
                 "user id = admin;" +
                 "password = adminadmin;" +
                 "Initial Catalog=envdb_mini;"+
                 "Integrated Security = True";// +
                                               //"MultipleActiveResultSets=true;";
            SqlConnection dbconn = new SqlConnection(connstr);
            dbconn.Open();
            Debug.Log("Start2");
            string sqlExpression = "INSERT INTO Table_1 (test) VALUES ('test04')";// "INSERT INTO Active_objects (ao_name, id_type) VALUES ('test_171117', '1')";
            SqlCommand thisCommand = new SqlCommand(sqlExpression, dbconn);
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            dbconn.Close();

            Debug.Log("Success");
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message);
        }
        //end of manipulations with db
    }

    // Update is called once per frame
    void Update () {
		
	}
}
