using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
public class update : MonoBehaviour
{
    private string conn, sqlQuery;
    IDbConnection dbconn;
    IDbCommand dbcmd;
    // Use this for initialization
    void Start()
    {
        conn = "URI=file:" + Application.dataPath + "/Plugins/Users.s3db"; //Path to database.
                                                                           //Deletvalue(6);
        Updatevalue("nigel", "w@gamil.com", "1st", 1);


    }

    /*

    private void Updatevalue(string name, string email, string address, int id)
    {
        using (dbconn = new SqliteConnection(conn))
        {

            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("UPDATE Usersinfo set Name =\"{0}\", Email =\"{1}\", Address =\"{2}\" WHERE ID =\"{3}\" ", name, email, address, id);// table name
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
    }
    */



    private void Updatevalue(string name, string email, string address, int id)
    {
        using (SqliteConnection dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); // Open connection to the database.

            SqliteCommand cmd = new SqliteCommand();

            // SQL String.
            String sql = "UPDATE  Usersinfo SET Name = @name, Email = @email, Address =@address WHERE id = @id";

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
