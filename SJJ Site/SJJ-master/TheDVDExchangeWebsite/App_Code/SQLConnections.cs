using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SQLConnections
/// </summary>
public class SQLConnections
{
    static SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=TheDVDExchangeDatabase ;Integrated Security=true");
    public SqlCommand cmd = new SqlCommand();
    public SqlDataReader reader;
    public SQLConnections()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void openDatabase()
    {
        //Opens database Connection
        dbConnection.Open();
       
    }

    public void closeDatabase()
    {
        //Closes dbConnection
        dbConnection.Close();
    }

    public bool executeLoginCheckCommand(string usernameText, string passwordText)
    {
        cmd.Connection = dbConnection;
        cmd.CommandText = "Select * from users where username = " + "'" + usernameText + "'";
        reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            // Response.Write(reader["username"]);
            // Response.Write(reader["userpassword"]);
            // Response.Write(reader["useremail"]);
            if (reader.GetValue(1).ToString() == usernameText && reader.GetValue(2).ToString() == passwordText)
            {
                ErrorMessage.message = "<p>You have been succesfully logged in!</p>";
                ErrorMessage.printMe = true;
                dbConnection.Close();
                return true;
            }
            else
            {
                ErrorMessage.message = "<p>Username or password is incorrect</p>";
                ErrorMessage.printMe = true;

                dbConnection.Close();
                return false;
              

            }

        }

        return false;
    }

 
}