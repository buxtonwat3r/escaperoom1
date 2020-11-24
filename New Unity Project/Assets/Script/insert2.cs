using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
public class insert2 : MonoBehaviour
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

        using (SqliteConnection dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); // Open connection to the database.

            SqliteCommand cmd = new SqliteCommand();

            // SQL String.
            String sql = "INSERT INTO Usersinfo(Name, Email, Address)   VALUES(@name,@email,@address)";

            cmd.CommandText = sql;
            cmd.Connection = dbconn;

            // SQL paramters
            cmd.Parameters.Add(new SqliteParameter("@name", name));
            cmd.Parameters.Add(new SqliteParameter("@email", email));
            cmd.Parameters.Add(new SqliteParameter("@address", address));

            cmd.ExecuteNonQuery();

            dbconn.Close(); // Close connection to the database.

        }

    }


}
