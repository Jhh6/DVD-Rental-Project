<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BrowsePage.aspx.cs" Inherits="SJJ_Site_TheDVDExchangeWebsite_BrowsePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1250px;
            height: 300px;
        }

        p
        {
            color:white;
        }
        </style>

    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>    
            <img alt="banner" class="auto-style1" style="width:100%" src="DVD%20rental%20banner.jpg" /><br /><br />
    </div>

        <hr style="width:1665px; margin-left: 0px;" />
           
     <h1 style="text-align:center; color:white">
       Browse our database by genre for all of your favorite movies!
    </h1>
        <br />
        <hr style="width:1665px; margin-left: 0px;" />
        <br />

        <div id="first" style="height: 220px; width: 280px; color:white">
            <h3 style="text-align:left">
             HORROR
         </h3>
      
             <img src ="tab.jpg" style="width:142px;height:168px;" runat="server"/>
            <asp:ImageButton ID="HorrorButton" runat="server" Height="168px" Width="142px"
                OnClick="ImageButton_Click" />
            &nbsp;

        </div>


        <br />
        <hr style="width:1665px; margin-left: 0px;" />
        <br />

        <div id="ComedyHolder" style="height: 220px; width: 280px; color:white">
            <h3 style="text-align:left">
             COMEDY
         </h3>
      
             <img src ="tab.jpg" style="width:142px;height:168px;" runat="server"/>
            <asp:ImageButton ID="ComedyButton" runat="server" Height="168px" Width="142px"
                OnClick="ImageButton_Click2" />
            &nbsp;

        </div>

    </form>
</body>
</html>
