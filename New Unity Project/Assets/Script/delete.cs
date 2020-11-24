using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
public class delete : MonoBehaviour
{
    private string conn, sqlQuery;
    IDbConnection dbconn;
    IDbCommand dbcmd;
    // Use this for initialization
    void Start()
    {
        conn = "URI=file:" + Application.dataPath + "/Plugins/Users.s3db"; //Path to database.
                                                                           //Deletvalue(6);
        Deletvalue(7);


    }


    // Update is called once per frame
    private void Deletvalue(int id)
    {

        /*
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("Delete from Usersinfo WHERE ID=\"{0}\"", id);// table name
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
        */

        using (SqliteConnection dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); // Open connection to the database.

            SqliteCommand cmd = new SqliteCommand();

            // SQL String.
            String sql = "Delete from Usersinfo WHERE ID = @id";

            cmd.CommandText = sql;
            cmd.Connection = dbconn;

            // SQL paramters
            cmd.Parameters.Add(new SqliteParameter("@ID", id));

            cmd.ExecuteNonQuery();

            dbconn.Close(); // Close connection to the database.

        }

    }

}
