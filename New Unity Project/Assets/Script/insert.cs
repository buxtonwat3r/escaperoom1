using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
public class insert : MonoBehaviour
{
    private string conn, sqlQuery;
    IDbConnection dbconn;
    IDbCommand dbcmd;
    // Use this for initialization
    void Start()
    {
        conn = "URI=file:" + Application.dataPath + "/Plugins/Users.s3db"; //Path to database.
                                                                           //Deletvalue(6);
        insertvalue("matt", "matt@gmail.com", "sss");

    }





    private void insertvalue(string name, string email, string address)
    {
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("insert into Usersinfo (Name, Email, Address)  values(\"{0}\",\"{1}\",\"{2}\")", name, email, address);// table name
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
    }

}
