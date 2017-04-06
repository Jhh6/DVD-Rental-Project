using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project;
public partial class SJJ_Site_TheDVDExchangeWebsite_ActualCartPage : System.Web.UI.Page
{
    public List<int> movieIDS = new List<int>();
    public SQLConnections skwal = new SQLConnections();
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Session["userid"]);

        SQLConnections.dbConnection.Open();
        skwal.cmd.Connection = SQLConnections.dbConnection;
        skwal.cmd.CommandText = "Select movieID from usersCart where userID = " + id;
        skwal.reader = skwal.cmd.ExecuteReader();
        int count = 0;
        while (skwal.reader.Read())
        {

            movieIDS.Add(skwal.reader.GetInt32(0));

        }

        skwal.reader.Close();

        for (int x = 0; x < movieIDS.Count;x++)
        {
            skwal.cmd.CommandText = "Select * from MOVIES where ID = " + movieIDS[x];
            skwal.reader2 = skwal.cmd.ExecuteReader();
            while (skwal.reader2.Read())
            {
                Response.Write(skwal.reader2.GetValue(1) + "</br>");
            }
            skwal.reader2.Close();

        }






        //   movieIDs.Add(skwal.reader.GetInt32(0));


        //   count++;

    }

    protected void SignUpPageButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}