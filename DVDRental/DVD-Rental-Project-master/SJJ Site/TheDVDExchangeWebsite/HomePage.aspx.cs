using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Project;
//2/23/17
//Sam Kelsey, Jacob Homanics, Jordyn DiSanzo
//This class opens the database connection and stores into a session


public partial class HomePage : System.Web.UI.Page
{
    public ErrorMessage em = new ErrorMessage();
    //Initializes the dbConnection to the database
    static SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=TheDVDExchangeDatabase ;Integrated Security=true");
    //Initializes bool that is used to check if the user

    public SQLConnections skwal = new SQLConnections();

    //is currently logged in
    public bool loggedIn = false;

    
    public  Movie movie = new Movie();



    protected void Page_Load(object sender, EventArgs e)
    {

        Session["movieID"] = 0;
        

        skwal.closeDatabase();

        skwal.openDatabase();

        if (ErrorMessage.printMe)
        {
            Response.Write("<p>" + em.returnMessage() + "</p>");
            ErrorMessage.printMe = false;
        }

        skwal.closeDatabase();




        //If statement checks to see whether or not to print a message

        //Sets the Session to the value of loggedIn
        if (Session["loginstatus"] != null)
        {
            loggedIn = (bool)Session["loginstatus"];

        }
        //Opens database Connection
        //    dbConnection.Open();
        //Sets the session to the dbConnection
        //   Session["DatabaseConnection"] = dbConnection;
        //Closes dbConnection
        //   dbConnection.Close();

    }
    protected void LoadSignUpPage(object sender, EventArgs e)
    {
        if (SQLConnections.loggedIn)
        {
            ErrorMessage.message = "You are currently logged in!";
            ErrorMessage.printMe = true;
            Response.Redirect("HomePage.aspx");
        }
        if (!SQLConnections.loggedIn)
        {
            Response.Redirect("SignUpPage.aspx");
        }

    }
    protected void LoadLoginPage(object sender, EventArgs e)
    {
        if (SQLConnections.loggedIn)
        {
            ErrorMessage.message = "You are currently logged in!";
            ErrorMessage.printMe = true;
            Response.Redirect("HomePage.aspx");
        }
        if (!SQLConnections.loggedIn)
        {

            Response.Redirect("LoginPage.aspx");

        }

    }
    protected void LoadBrowsePage(object sender, EventArgs e)
    {
        if (SQLConnections.loggedIn)
        {
            Response.Redirect("BrowsePage.aspx");
        }
        if (!SQLConnections.loggedIn)
        {
            ErrorMessage.message = "Print Me!";
            ErrorMessage.printMe = true;
            Response.Redirect("HomePage.aspx");
        }
    }

    protected void LogoutHandle(object sender, EventArgs e)
    {
        if (SQLConnections.loggedIn)
        {
            SQLConnections.loggedIn = false;
            ErrorMessage.message = "You have succesfully logged out!";
            ErrorMessage.printMe = true;

            Response.Redirect("HomePage.aspx");
        }
        else
        {
           
            ErrorMessage.message = "You are not even logged in!";
            ErrorMessage.printMe = true;

            Response.Redirect("HomePage.aspx");

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (SQLConnections.loggedIn)
        {
            Session["movieID"] = 12;

            Session["userID"] = SQLConnections.userID;
        Response.Redirect("CartPage.aspx");

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (SQLConnections.loggedIn)
        {
            Session["movieID"] = 4;

            Session["userID"] = SQLConnections.userID;
            Response.Redirect("CartPage.aspx");

        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (SQLConnections.loggedIn)
        {
            Session["movieID"] = 9;

            Session["userID"] = SQLConnections.userID;
            Response.Redirect("CartPage.aspx");

        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        if (SQLConnections.loggedIn)
        {
            Session["movieID"] = 15;

            Session["userID"] = SQLConnections.userID;
            Response.Redirect("CartPage.aspx");

        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        if (SQLConnections.loggedIn)
        {
            Session["movieID"] = 2;

            Session["userID"] = SQLConnections.userID;
            Response.Redirect("CartPage.aspx");

        }
    }

    protected void Cart_Click(object sender, EventArgs e)
    {
        if (SQLConnections.loggedIn)
        {
            Session["userID"] = SQLConnections.userID;
            Response.Redirect("ActualCartPage.aspx");

        }
    }
}