<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>
<!DOCTYPE html>

    
       
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

 <body >
    <form id="form1" runat="server">


           
       
    <div>    
            <img alt="banner" class="auto-style1" style="width:100%" src="DVD%20rental%20banner.jpg" /><br /><br />
    </div>
        
          
    <div>
           <asp:Button ID="SignUpPageButton" runat="server" Text="Sign Up!" OnClick="LoadSignUpPage"/>
           <asp:Button ID="LoginPageButton" runat="server" Text="Login" OnClick="LoadLoginPage"/>
           <asp:Button ID="BrowsePageButton" runat="server" Text="Browse" OnClick="LoadBrowsePage"/>
           <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="LogoutHandle"/>

    </div>


        <hr style="width:1664px; margin-left: 0px;" />
           
     <h1 style="text-align:center">
       Welcome to the DVD Exchange where you can make connections, trade movies, watch movies, and blog about your thoughts! Check out this weeks featured movies!
    </h1>
        <br />
        <hr style="width:1665px; margin-left: 0px;" />
        <br />
         <h2 style="text-align:center">
                Featured Horror Movies
         </h2>
        <br />
        <hr style="width:1664px; margin-left: 0px;" />


            <div id="first" style="height: 220px; width: 280px">
            <h3 style="text-align:left">
             The Forest (2016, PG-13)
         </h3>
      
             <img src ="forestcover.jpg" style="width:142px;height:168px;" runat="server"/>

            <asp:Button ID="Button1" runat="server" Text="Add to Cart" />

         <div id="desc1" style="width:150px; height:132px;">
                    <h4 >
                        A woman goes into Japan's Suicide
                         Forest to find her twin sister, 
                        and confronts supernatural terror.
                    </h4>
                </div>
  
        </div>

        <div id="second" style="height: 220px; width: 280px">
            <h3 style="text-align:left">
             The Conjuring 2 (2016, R)
         </h3>
      
             <img src ="conjuringcover.jpg" style="width:142px;height:168px;" runat="server"/>

        <asp:Button ID="Button2" runat="server" Text="Add to Cart" />

                <div id="desc" style="width:150px; height:132px;">
                    <h4 >
                        Lorraine and Ed Warren travel
                        to north London to help a single
                        mother raising four children
                        alone in a house plagued by a 
                        malicious spirit.
                    </h4>
                </div>
        </div>

        <div id="third" style="height: 220px; width: 280px">
            <h3 style="text-align:left">
             Get Out (2017, R)
         </h3>
      
             <img src ="getout.jpg" style="width:142px;height:168px;" runat="server"/>

        <asp:Button ID="Button3" runat="server" Text="Add to Cart" />

                <div id="desc2" style="width:150px; height:132px;">
                    <h4 >
                        A young African-American man 
                        visits his Caucasian girlfriend's
                        mysterious family estate.
                    </h4>
                </div>
        </div>

        <div id="fourth" style="height: 220px; width: 280px">
            <h3 style="text-align:left">
             Unfriended (2014, R)
         </h3>
      
             <img src ="unfriendedcover.jpg" style="width:142px;height:168px;" runat="server"/>

        <asp:Button ID="Button4" runat="server" Text="Add to Cart" />

                <div id="desc3" style="width:150px; height:132px;">
                    <h4 >
                        A group of online chat room friends
                        find themselves haunted by a mysterious,
                        supernatural force using the account of 
                        their dead friend.
                    </h4>
                </div>
        </div>

        <div id="fifth" style="height: 220px; width: 280px">
            <h3 style="text-align:left">
             Sinister 2 (2015, R)
         </h3>
      
             <img src ="sinister2cover.jpg" style="width:142px;height:168px;" runat="server"/>

        <asp:Button ID="Button5" runat="server" Text="Add to Cart" />

                <div id="desc4" style="width:150px; height:132px;">
                    <h4 >
                        A young mother and her twin sons move
                        into a rural house that's marked for 
                        death.
                    </h4>
                </div>
        </div>

</form>
        
    

     </body>

