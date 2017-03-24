using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project;
public partial class SJJ_Site_TheDVDExchangeWebsite_CartPage : System.Web.UI.Page
{
    public SQLConnections skwal = new SQLConnections();

    private int userID;

    private int movieID;

    protected void Page_Load(object sender, EventArgs e)
    {
        skwal.closeDatabase();

        skwal.openDatabase();

        userID = Convert.ToInt32(Session["userID"]);
        movieID = Convert.ToInt32(Session["movieID"]);

        

        skwal.addMovieToCart(userID,movieID);

    }
}