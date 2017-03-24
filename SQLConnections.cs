using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SQLConnections
/// </summary>
/// 
namespace Project
{

    public class SQLConnections
    {

        public static bool loggedIn = false;
        public string hey;
        static SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=TheDVDExchangeDatabase ;Integrated Security=true");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        public static int userID = 0;
        public string userIDHolder;
        public SQLConnections()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public void addMovieToCart(int userID, int movieID)
        {
            cmd.Connection = dbConnection;

            cmd.CommandText = "Insert into usersCart (movieID,userID) values(" + movieID + "," + userID + ");";

            cmd.ExecuteScalar();
            //Closes database connection
            dbConnection.Close();
        }


        public void openDatabase()
        {
            //Opens database Connection
            dbConnection.Open();

        }


        public bool returnIt()
        {

            return loggedIn;
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
                    SQLConnections.userID = reader.GetInt32(0);

                  //  userID = Convert.ToInt32(userIDHolder);

                   
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
}